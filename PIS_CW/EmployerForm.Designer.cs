namespace PIS_CW
{
    partial class EmployerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpInfo = new System.Windows.Forms.TabPage();
            this.tbpDeals = new System.Windows.Forms.TabPage();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.cbDealStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblFEId = new System.Windows.Forms.Label();
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.tbpVacancies = new System.Windows.Forms.TabPage();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblPN = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.btnChangeVacancy = new System.Windows.Forms.Button();
            this.cbTypesOfBusiness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProfession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatusOfVacancy = new System.Windows.Forms.ComboBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rtbAdditionalInfo = new System.Windows.Forms.RichTextBox();
            this.cbVacancyStatusFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            this.tbpDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            this.tbpVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInfo);
            this.tabControl1.Controls.Add(this.tbpVacancies);
            this.tabControl1.Controls.Add(this.tbpDeals);
            this.tabControl1.Location = new System.Drawing.Point(-2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpInfo
            // 
            this.tbpInfo.Controls.Add(this.tbPhoneNumber);
            this.tbpInfo.Controls.Add(this.tbAdress);
            this.tbpInfo.Controls.Add(this.tbCompanyName);
            this.tbpInfo.Controls.Add(this.btnLogOut);
            this.tbpInfo.Controls.Add(this.btnSaveChanges);
            this.tbpInfo.Controls.Add(this.lblPN);
            this.tbpInfo.Controls.Add(this.btnClose);
            this.tbpInfo.Controls.Add(this.lblFN);
            this.tbpInfo.Controls.Add(this.lblLN);
            this.tbpInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpInfo.Name = "tbpInfo";
            this.tbpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfo.Size = new System.Drawing.Size(796, 420);
            this.tbpInfo.TabIndex = 0;
            this.tbpInfo.Text = "Информация";
            this.tbpInfo.UseVisualStyleBackColor = true;
            // 
            // tbpDeals
            // 
            this.tbpDeals.Controls.Add(this.btnSign);
            this.tbpDeals.Controls.Add(this.btnDecline);
            this.tbpDeals.Controls.Add(this.cbDealStatusFilter);
            this.tbpDeals.Controls.Add(this.lblFEId);
            this.tbpDeals.Controls.Add(this.dgvDeals);
            this.tbpDeals.Location = new System.Drawing.Point(4, 22);
            this.tbpDeals.Name = "tbpDeals";
            this.tbpDeals.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeals.Size = new System.Drawing.Size(796, 420);
            this.tbpDeals.TabIndex = 1;
            this.tbpDeals.Text = "Сделки";
            this.tbpDeals.UseVisualStyleBackColor = true;
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(573, 327);
            this.btnSign.Name = "btnSign";
            this.btnSign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSign.Size = new System.Drawing.Size(201, 37);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Согласиться на сделку";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(573, 370);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(201, 37);
            this.btnDecline.TabIndex = 3;
            this.btnDecline.Text = "Отклонить сделку";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // cbDealStatusFilter
            // 
            this.cbDealStatusFilter.FormattingEnabled = true;
            this.cbDealStatusFilter.Location = new System.Drawing.Point(573, 29);
            this.cbDealStatusFilter.Name = "cbDealStatusFilter";
            this.cbDealStatusFilter.Size = new System.Drawing.Size(212, 21);
            this.cbDealStatusFilter.TabIndex = 2;
            this.cbDealStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbDealStatusFilter_SelectedIndexChanged);
            // 
            // lblFEId
            // 
            this.lblFEId.AutoSize = true;
            this.lblFEId.Location = new System.Drawing.Point(570, 13);
            this.lblFEId.Name = "lblFEId";
            this.lblFEId.Size = new System.Drawing.Size(166, 13);
            this.lblFEId.TabIndex = 1;
            this.lblFEId.Text = "Фильтрация по статусу сделки";
            // 
            // dgvDeals
            // 
            this.dgvDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeals.Location = new System.Drawing.Point(12, 9);
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.Size = new System.Drawing.Size(536, 398);
            this.dgvDeals.TabIndex = 0;
            // 
            // tbpVacancies
            // 
            this.tbpVacancies.Controls.Add(this.cbVacancyStatusFilter);
            this.tbpVacancies.Controls.Add(this.label6);
            this.tbpVacancies.Controls.Add(this.rtbAdditionalInfo);
            this.tbpVacancies.Controls.Add(this.tbSalary);
            this.tbpVacancies.Controls.Add(this.tbProfession);
            this.tbpVacancies.Controls.Add(this.btnAddVacancy);
            this.tbpVacancies.Controls.Add(this.btnChangeVacancy);
            this.tbpVacancies.Controls.Add(this.cbStatusOfVacancy);
            this.tbpVacancies.Controls.Add(this.cbTypesOfBusiness);
            this.tbpVacancies.Controls.Add(this.label4);
            this.tbpVacancies.Controls.Add(this.label1);
            this.tbpVacancies.Controls.Add(this.label5);
            this.tbpVacancies.Controls.Add(this.label3);
            this.tbpVacancies.Controls.Add(this.label2);
            this.tbpVacancies.Controls.Add(this.dgvVacancies);
            this.tbpVacancies.Location = new System.Drawing.Point(4, 22);
            this.tbpVacancies.Name = "tbpVacancies";
            this.tbpVacancies.Size = new System.Drawing.Size(796, 420);
            this.tbpVacancies.TabIndex = 2;
            this.tbpVacancies.Text = "Вакансии";
            this.tbpVacancies.UseVisualStyleBackColor = true;
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(12, 11);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.Size = new System.Drawing.Size(536, 398);
            this.dgvVacancies.TabIndex = 4;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(18, 172);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(201, 20);
            this.tbPhoneNumber.TabIndex = 18;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(18, 99);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(201, 20);
            this.tbAdress.TabIndex = 20;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(18, 35);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(201, 20);
            this.tbCompanyName.TabIndex = 21;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(581, 332);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(201, 37);
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.Text = "Выйти из аккаунта";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(581, 289);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(201, 37);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPN.Location = new System.Drawing.Point(18, 145);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(162, 24);
            this.lblPN.TabIndex = 10;
            this.lblPN.Text = "Номер телефона";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(581, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 37);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Выйти из системы";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFN.Location = new System.Drawing.Point(14, 72);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(159, 24);
            this.lblFN.TabIndex = 12;
            this.lblFN.Text = "Адрес компании";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLN.Location = new System.Drawing.Point(14, 8);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(189, 24);
            this.lblLN.TabIndex = 13;
            this.lblLN.Text = "Название компании";
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(573, 325);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddVacancy.Size = new System.Drawing.Size(201, 37);
            this.btnAddVacancy.TabIndex = 9;
            this.btnAddVacancy.Text = "Добавить вакансию";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // btnChangeVacancy
            // 
            this.btnChangeVacancy.Location = new System.Drawing.Point(573, 368);
            this.btnChangeVacancy.Name = "btnChangeVacancy";
            this.btnChangeVacancy.Size = new System.Drawing.Size(201, 37);
            this.btnChangeVacancy.TabIndex = 10;
            this.btnChangeVacancy.Text = "Изменить вакансию";
            this.btnChangeVacancy.UseVisualStyleBackColor = true;
            this.btnChangeVacancy.Click += new System.EventHandler(this.btnChangeVacancy_Click);
            // 
            // cbTypesOfBusiness
            // 
            this.cbTypesOfBusiness.FormattingEnabled = true;
            this.cbTypesOfBusiness.Location = new System.Drawing.Point(573, 105);
            this.cbTypesOfBusiness.Name = "cbTypesOfBusiness";
            this.cbTypesOfBusiness.Size = new System.Drawing.Size(212, 21);
            this.cbTypesOfBusiness.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вид деятельности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Профессия";
            // 
            // tbProfession
            // 
            this.tbProfession.Location = new System.Drawing.Point(573, 67);
            this.tbProfession.Name = "tbProfession";
            this.tbProfession.Size = new System.Drawing.Size(212, 20);
            this.tbProfession.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Зарплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Статус вакансии";
            // 
            // cbStatusOfVacancy
            // 
            this.cbStatusOfVacancy.FormattingEnabled = true;
            this.cbStatusOfVacancy.Location = new System.Drawing.Point(573, 183);
            this.cbStatusOfVacancy.Name = "cbStatusOfVacancy";
            this.cbStatusOfVacancy.Size = new System.Drawing.Size(212, 21);
            this.cbStatusOfVacancy.TabIndex = 7;
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(573, 145);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(212, 20);
            this.tbSalary.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дополнительная информация";
            // 
            // rtbAdditionalInfo
            // 
            this.rtbAdditionalInfo.Location = new System.Drawing.Point(573, 223);
            this.rtbAdditionalInfo.Name = "rtbAdditionalInfo";
            this.rtbAdditionalInfo.Size = new System.Drawing.Size(212, 96);
            this.rtbAdditionalInfo.TabIndex = 12;
            this.rtbAdditionalInfo.Text = "";
            // 
            // cbVacancyStatusFilter
            // 
            this.cbVacancyStatusFilter.FormattingEnabled = true;
            this.cbVacancyStatusFilter.Location = new System.Drawing.Point(573, 27);
            this.cbVacancyStatusFilter.Name = "cbVacancyStatusFilter";
            this.cbVacancyStatusFilter.Size = new System.Drawing.Size(212, 21);
            this.cbVacancyStatusFilter.TabIndex = 14;
            this.cbVacancyStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cbVacancyStatusFilter_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Фильтрация по статусу вакансии";
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployerForm";
            this.Text = "EmployerForm";
            this.tabControl1.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            this.tbpInfo.PerformLayout();
            this.tbpDeals.ResumeLayout(false);
            this.tbpDeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            this.tbpVacancies.ResumeLayout(false);
            this.tbpVacancies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInfo;
        private System.Windows.Forms.TabPage tbpDeals;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.ComboBox cbDealStatusFilter;
        private System.Windows.Forms.Label lblFEId;
        private System.Windows.Forms.DataGridView dgvDeals;
        private System.Windows.Forms.TabPage tbpVacancies;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.TextBox tbProfession;
        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Button btnChangeVacancy;
        private System.Windows.Forms.ComboBox cbTypesOfBusiness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAdditionalInfo;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.ComboBox cbStatusOfVacancy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVacancyStatusFilter;
        private System.Windows.Forms.Label label6;
    }
}