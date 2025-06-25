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
    public partial class ManagerForm: Form
    {
        private readonly FacadeDatabase _facade;
        public ManagerForm(FacadeDatabase facade)
        {
            InitializeComponent();
            _facade = facade;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {

        }

        private void cbEmployeeId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDealStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeVacancyStatus_Click(object sender, EventArgs e)
        {

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
