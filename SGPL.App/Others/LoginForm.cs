using SGPL.App.Infra;
using SGPL.App.Register;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;


namespace SGPL.App.Others
{
    public partial class LoginForm : MaterialForm
    {
        private readonly IBaseService<User> _userService;
        public LoginForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            User? user = GetUser(txtLogin.Text, txtPassword.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "SGPL",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!user.IsActive)
            {
                MessageBox.Show("User inactive!", "SGPL",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                user.LoginDate = DateTime.Now;
                user = _userService.Update<User, User, UserValidator>(user);
                MainForm.user = user;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? GetUser(string login, string password)
        {
            CheckUser();
            var user = _userService.Get<User>().Where(x => x.Login == login).FirstOrDefault();
            if (user == null)
                return null;
            return user.Password != password ? null : user;
        }
        private void CheckUser()
        {
            var users = _userService.Get<User>().ToList();
            if (!users.Any())
            {
                var user = new User
                {
                    Login = "admin",
                    Password = "admin",
                    Name = "admin",
                    IsActive = true,
                    RegisterDate = DateTime.Now,
                    Email = "admin@gmail.com"
                };
                _userService.Add<User, User, UserValidator>(user);
            }
        }
        private void lblDontHave_Click(object sender, EventArgs e)
        {
            UserForm.loginUser = true;
            var userForm = ConfigureDI.serviceProvider!.GetService<UserForm>();
            userForm!.ShowDialog();
        }
    }
}
