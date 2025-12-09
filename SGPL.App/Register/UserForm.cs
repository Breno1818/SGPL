using SGPL.App.Base;
using SGPL.App.ViewModel;
using SGPL.Domain.Base;
using SGPL.Domain.Entities;
using SGPL.Service.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGPL.App.Register
{
    public partial class UserForm : BaseForm
    {
        private readonly IBaseService<User> _userService;
        private List<UserViewModel>? users;
        public static bool loginUser;

        public UserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
            PopulateGrid();
        }

        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Login = txtLogin.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.RegisterDate = DateTime.Now;
            user.IsActive = true;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int.TryParse(txtId.Text, out int id);
                    var user = _userService.GetById<User>(id);
                    FormToObject(user);
                    _userService.Update<User, User, UserValidator>(user);
                }
                else
                {
                    var user = new User();
                    FormToObject(user);
                    _userService.Add<User, User, UserValidator>(user);

                    if (loginUser)
                    {
                        MainForm.user = user;
                        loginUser = false;
                        DialogResult = DialogResult.OK;
                        Close();
                    }
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
                _userService.Delete(id);
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"SGPL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void PopulateGrid()
        {
            users = _userService.Get<UserViewModel>().ToList();
            dataGridViewList.DataSource = users;
            if (dataGridViewList.Columns["Name"] != null)
                dataGridViewList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewList.Columns["Id"] != null)
                dataGridViewList.Columns["Id"].Visible = false;
        }

        protected override void GridToForm(DataGridViewRow? record)
        {
            if (record == null) return;
            txtId.Text = record.Cells["Id"].Value.ToString();
            txtName.Text = record.Cells["Name"].Value.ToString();
            txtLogin.Text = record.Cells["Login"].Value.ToString();
            txtEmail.Text = record.Cells["Email"].Value.ToString();
            txtPassword.Text = record.Cells["Password"].Value.ToString();
        }
    }
}
