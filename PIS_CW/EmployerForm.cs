﻿using System;
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
    public partial class EmployerForm: Form
    {
        private readonly FacadeDatabase _facade;
        public EmployerForm(FacadeDatabase facade)
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

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeVacancy_Click(object sender, EventArgs e)
        {

        }

        private void cbVacancyStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDealStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {

        }
    }
}
