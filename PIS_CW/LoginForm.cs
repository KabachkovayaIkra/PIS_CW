using System;
using System.Windows.Forms;
using DataAccess;

namespace PIS_CW
{
    public partial class LoginForm: Form
    {
        private readonly FacadeDatabase _facade;
        public LoginForm()
        {
            InitializeComponent();
            _facade = new FacadeDatabase();
        }

        private void btn_ExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text.Trim();
            string password = tb_Password.Text;


            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            if (_facade.TryLogin(login, password, out string role))
            {
                MessageBox.Show($"Добро пожаловать, {role}!");

                
                if (role == "Manager") new ManagerForm(_facade).ShowDialog();
                else if (role == "Employee") new EmployeeForm(_facade).ShowDialog();
                else if (role == "Employer") new EmployerForm(_facade).ShowDialog();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            var regForm = new RegistrationForm(_facade);
            regForm.ShowDialog();
        }
    }
}
