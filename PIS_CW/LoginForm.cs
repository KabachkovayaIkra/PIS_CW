using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIS_CW
{
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_ExitSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string login = tb_Login.Text;
            string password = tb_Password.Text;

            //logic
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            // open registr form
        }
    }
}
