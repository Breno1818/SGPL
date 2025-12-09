using SGPL.App.Base;
using SGPL.App.ViewModel;
using SGPL.App.ViewModels;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;


namespace SGPL.App.Register
{
    public partial class AnimalForm : BaseForm
    {
        private readonly IBaseService<Animal> _animalService;
        private readonly IBaseService<Production> _productionService;
        private List<AnimalViewModel>? animals;

        public AnimalForm(IBaseService<Animal> animalService, IBaseService<Production> productionService)
        {
            _animalService = animalService;
            _productionService = productionService;
            InitializeComponent();
            LoadProductions();
            PopulateGrid();
        }

        private void LoadProductions()
        {
            var productions = _productionService.Get<ProductionViewModel>().ToList();
            cmbProduction.DisplayMember = "Product";  
            cmbProduction.ValueMember = "Id";
            cmbProduction.DataSource = productions;
        }

        private void FormToObject(Animal animal)
        {
            animal.Name = txtName.Text;
            animal.Age = int.TryParse(txtAge.Text, out var age) ? age : 0;
            animal.Producer = chkProducer.Checked;

            if (int.TryParse(cmbProduction.SelectedValue?.ToString(), out int productionId))
            {
                var production = _productionService.GetById<Production>(productionId);
                animal.Production = production;
            }
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var animal = _animalService.GetById<Animal>(id);
                    FormToObject(animal);
                    _animalService.Update<Animal, Animal, AnimalValidator>(animal);
                }
                else
                {
                    var animal = new Animal();
                    FormToObject(animal);
                    _animalService.Add<Animal, Animal, AnimalValidator>(animal);
                }
                PopulateGrid(); // atualiza o DataGrid após salvar
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
                _animalService.Delete(id);
                PopulateGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            animals = _animalService.Get<AnimalViewModel>().ToList();
            dataGridViewList.DataSource = animals;

            if (dataGridViewList.Columns["Name"] != null)
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
            if (dataGridViewList.Columns["IdProduction"] != null)
                dataGridViewList.Columns["IdProduction"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;

            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtAge.Text = record.Cells["Age"].Value.ToString();
            chkProducer.Checked = (bool)record.Cells["Producer"].Value;
            cmbProduction.SelectedValue = record.Cells["IdProduction"].Value;
        }
    }
}
