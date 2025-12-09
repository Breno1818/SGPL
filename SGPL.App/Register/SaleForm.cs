using SGPL.App.Base;
using SGPL.App.ViewModel;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SGPL.App.Register
{
    public partial class SaleForm : BaseForm
    {
        private List<SaleItemViewModel> _saleItems;
        private readonly IBaseService<Sale> _saleService;
        private readonly IBaseService<User> _userService;
        private readonly IBaseService<Production> _productionService;
        private List<SaleViewModel>? sales;

        public SaleForm(IBaseService<Sale> saleService, IBaseService<User> userService, IBaseService<Production> productionService)
        {
            _saleService = saleService;
            _userService = userService;
            _productionService = productionService;
            _saleItems = new List<SaleItemViewModel>();
            InitializeComponent();
            LoadCombos();
            PopulateGridItemsSale();
            New();
        }

        private void LoadCombos()
        {
            txtUser.DisplayMember = "Name";
            txtUser.ValueMember = "Id";
            txtUser.DataSource = _userService.Get<User>().ToList();

            txtProduct.DisplayMember = "Product";
            txtProduct.ValueMember = "Id";
            txtProduct.DataSource = _productionService.Get<Production>().ToList();
        }

        private void FormToObject(Sale sale)
        {
            sale.SaleDate = DateTime.Now;
            if (int.TryParse(txtUser.SelectedValue?.ToString(), out var idUser))
                sale.Salesman = _userService.GetById<User>(idUser);

            sale.SaleTotal = _saleItems.Sum(x => x.TotalPrice);
            sale.SaleItems.Clear();

            foreach (var item in _saleItems)
            {
                var production = _productionService.GetById<Production>(item.IdProduction);
                sale.SaleItems.Add(new SaleItem
                {
                    Sale = sale,
                    Production = production,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    TotalPrice = item.TotalPrice
                });
            }
        }

        protected override void New()
        {
            base.New();
            _saleItems.Clear();
            PopulateGridItemsSale();
            txtDateSale.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode && int.TryParse(txtId.Text, out var id))
                {
                    var sale = _saleService.GetById<Sale>(id);
                    FormToObject(sale);
                    _saleService.Update<Sale, Sale, SaleValidator>(sale);
                }
                else
                {
                    var sale = new Sale();
                    FormToObject(sale);
                    _saleService.Add<Sale, Sale, SaleValidator>(sale);
                }

                PopulateGrid();
                tabControlRegister.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Delete(int id)
        {
            try
            {
                _saleService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            var includes = new List<string> { "Salesman", "SaleItems", "SaleItems.Production" };
            sales = _saleService.Get<SaleViewModel>(includes).ToList();
            dataGridViewList.DataSource = sales;

            if (dataGridViewList.Columns["IdSalesman"] != null)
                dataGridViewList.Columns["IdSalesman"].Visible = false;

            if (dataGridViewList.Columns["SaleTotal"] != null)
            {
                dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Format = "C2";
                dataGridViewList.Columns["SaleTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            int.TryParse(record.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtUser.SelectedValue = record.Cells["IdSalesman"].Value;
            txtDateSale.Text = DateTime.TryParse(record.Cells["SaleDate"].Value.ToString(), out var date)
                ? date.ToString("g")
                : "";

            var sale = _saleService.GetById<Sale>(id);
            _saleItems = sale.SaleItems.Select(item => new SaleItemViewModel
            {
                Id = item.Id,
                IdProduction = item.Production!.Id,
                Production = item.Production!.Product,
                UnitPrice = item.UnitPrice,
                Quantity = item.Quantity,
                TotalPrice = item.TotalPrice
            }).ToList();

            PopulateGridItemsSale();
        }

        private void PopulateGridItemsSale()
        {
            var source = new BindingSource { DataSource = _saleItems };
            dataGridViewItems.DataSource = source;

            if (dataGridViewItems.Columns["Id"] != null)
                dataGridViewItems.Columns["Id"].Visible = false;

            if (dataGridViewItems.Columns["IdProduction"] != null)
                dataGridViewItems.Columns["IdProduction"].HeaderText = "Production";

            if (dataGridViewItems.Columns["UnitPrice"] != null)
            {
                dataGridViewItems.Columns["UnitPrice"].DefaultCellStyle.Format = "C2";
                dataGridViewItems.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridViewItems.Columns["TotalPrice"] != null)
            {
                dataGridViewItems.Columns["TotalPrice"].DefaultCellStyle.Format = "C2";
                dataGridViewItems.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dataGridViewItems.Columns["Quantity"] != null)
                dataGridViewItems.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProduct.SelectedValue?.ToString(), out var idProduction)) return;
            var production = _productionService.GetById<Production>(idProduction);

            var saleItem = new SaleItemViewModel
            {
                IdProduction = production.Id,
                Production = production.Product,
                UnitPrice = decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var uVal) ? uVal : 0,
                Quantity = int.TryParse(txtQuantity.Text, out var qtd) ? qtd : 0
            };

            saleItem.TotalPrice = saleItem.Quantity * saleItem.UnitPrice;
            _saleItems.Add(saleItem);

            CalcTotalSale();
            PopulateGridItemsSale();
        }

        private void txtUnitValue_Leave(object sender, EventArgs e)
        {
            txtUnitValue.Text = decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var value)
                ? value.ToString("C2")
                : string.Empty;
            CalcTotalItems();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalcTotalItems();
        }

        private void CalcTotalItems()
        {
            if (decimal.TryParse(txtUnitValue.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var unitValue) &&
                int.TryParse(txtQuantity.Text, out var quantity))
            {
                txtTotalValue.Text = (unitValue * quantity).ToString("C2");
            }
        }

        private void CalcTotalSale()
        {
            lblValue.Text = $"Total Value: {_saleItems.Sum(x => x.TotalPrice).ToString("C2")}";
            lblQuantityItems.Text = $"Products: {_saleItems.Sum(x => x.Quantity)}";
        }
    }
}
