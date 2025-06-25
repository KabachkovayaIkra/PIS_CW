using System;
using System.Windows.Forms;
using DataAccess;

namespace PIS_CW
{
    public partial class RegistrationForm: Form
    {
        private readonly FacadeDatabase _facade;
        public RegistrationForm(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }
      

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text.Trim();
            string password = tb_Password.Text;
            string role = cbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            if (_facade.TryRegister(login, password, role))
            {
                MessageBox.Show("Регистрация успешна. Теперь вы можете войти.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
            }
        }
    }
}
