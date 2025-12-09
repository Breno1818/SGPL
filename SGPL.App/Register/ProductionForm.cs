using SGPL.App.Base;
using SGPL.App.ViewModel;
using SGPL.App.ViewModels;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGPL.App.Register
{
    public partial class ProductionForm : BaseForm
    {
        private readonly IBaseService<Production> _productionService;
        private readonly IBaseService<Feed> _feedService;
        private List<ProductionViewModel>? productions;

        public ProductionForm(IBaseService<Production> productionService, IBaseService<Feed> feedService)
        {
            _productionService = productionService;
            _feedService = feedService;
            InitializeComponent();
            LoadFeeds();
            PopulateGrid();
        }

        private void LoadFeeds()
        {
            cmbFeedType.DisplayMember = "FeedType";
            cmbFeedType.ValueMember = "Id";
            cmbFeedType.DataSource = _feedService.Get<FeedViewModel>().ToList();
        }

        private void FormToObject(Production production)
        {
            production.Product = txtProduct.Text;
            production.Quantity = int.TryParse(txtQuantity.Text, out var quantity) ? quantity : 0;

            if (int.TryParse(cmbFeedType.SelectedValue?.ToString(), out int feedId))
            {
                var feed = _feedService.GetById<Feed>(feedId);
                production.Feed = feed;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var production = _productionService.GetById<Production>(id);
                    FormToObject(production);
                    _productionService.Update<Production, Production, ProductionValidator>(production);
                }
                else
                {
                    var production = new Production();
                    FormToObject(production);
                    _productionService.Add<Production, Production, ProductionValidator>(production);
                }
                PopulateGrid();
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
                _productionService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            productions = _productionService.Get<ProductionViewModel>().ToList();
            dataGridViewList.DataSource = productions;
            if (dataGridViewList.Columns["Product"] != null)
                dataGridViewList.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
            if (dataGridViewList.Columns["FeedId"] != null)
                dataGridViewList.Columns["FeedId"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtProduct.Text = record.Cells["Product"].Value.ToString();
            txtQuantity.Text = record.Cells["Quantity"].Value.ToString();
            cmbFeedType.SelectedValue = record.Cells["FeedId"].Value;
        }
    }
}
