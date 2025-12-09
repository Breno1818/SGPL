using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using SGPL.App.Infra;
using SGPL.App.Others;
using SGPL.App.Register;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Service;

namespace SGPL.App
{
    public partial class MainForm : MaterialForm
    {
        public static User user;
        private readonly IBaseService<User> _userService;
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IBaseService<User> userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.IsMdiContainer = true;
            LoadLogin();
            FormClosing += FormPrincipal_FormClosing;
        }

        private void LoadLogin()
        {
            using var login = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUser.Text = $"Usuário: {MainForm.user.Name}";
                }
            }
        }


        private void FormLoad<TForm>() where TForm : Form
        {
            var cad = _serviceProvider.GetService(typeof(TForm)) as TForm;
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<UserForm>();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<AnimalForm>();
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<FeedForm>();
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<ProductionForm>();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoad<SaleForm>();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
