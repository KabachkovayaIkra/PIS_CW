using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace PIS_CW
{
    public partial class EmployeeForm: Form
    {
        private readonly FacadeDatabase _facade;
        public EmployeeForm(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApplyForVacancy_Click(object sender, EventArgs e)
        {

        }
    }
}
