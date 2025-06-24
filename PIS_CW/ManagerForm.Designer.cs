namespace PIS_CW
{
    partial class ManagerForm
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblMN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.tbpDeals = new System.Windows.Forms.TabPage();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.cbDealStatus = new System.Windows.Forms.ComboBox();
            this.lblFDS = new System.Windows.Forms.Label();
            this.cbEmployeeId = new System.Windows.Forms.ComboBox();
            this.lblFEId = new System.Windows.Forms.Label();
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.tbpVacancies = new System.Windows.Forms.TabPage();
            this.btnChangeVacancyStatus = new System.Windows.Forms.Button();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.tbpTables = new System.Windows.Forms.TabPage();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            this.tbpDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
            this.tbpVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.tbpTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpInfo);
            this.tabControl1.Controls.Add(this.tbpDeals);
            this.tabControl1.Controls.Add(this.tbpVacancies);
            this.tabControl1.Controls.Add(this.tbpTables);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpInfo
            // 
            this.tbpInfo.Controls.Add(this.btnLogOut);
            this.tbpInfo.Controls.Add(this.btnClose);
            this.tbpInfo.Controls.Add(this.lblLogin);
            this.tbpInfo.Controls.Add(this.lblMiddleName);
            this.tbpInfo.Controls.Add(this.lblFirstName);
            this.tbpInfo.Controls.Add(this.lblLastName);
            this.tbpInfo.Controls.Add(this.lblL);
            this.tbpInfo.Controls.Add(this.lblMN);
            this.tbpInfo.Controls.Add(this.lblFN);
            this.tbpInfo.Controls.Add(this.lblLN);
            this.tbpInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpInfo.Name = "tbpInfo";
            this.tbpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfo.Size = new System.Drawing.Size(796, 420);
            this.tbpInfo.TabIndex = 0;
            this.tbpInfo.Text = "Информация о менеджере";
            this.tbpInfo.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(573, 327);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogOut.Size = new System.Drawing.Size(201, 37);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Выйти из аккаунта";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(573, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Выйтти из системы";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(9, 264);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(237, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Здесь должно быть login";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMiddleName.Location = new System.Drawing.Point(9, 200);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(280, 24);
            this.lblMiddleName.TabIndex = 0;
            this.lblMiddleName.Text = "Здесь должно быть отчество";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(9, 136);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(230, 24);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Здесь должно быть имя";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(9, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(276, 24);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Здесь должна быть Фамилия";
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL.Location = new System.Drawing.Point(9, 240);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(57, 24);
            this.lblL.TabIndex = 0;
            this.lblL.Text = "Login";
            // 
            // lblMN
            // 
            this.lblMN.AutoSize = true;
            this.lblMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMN.Location = new System.Drawing.Point(9, 176);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(98, 24);
            this.lblMN.TabIndex = 0;
            this.lblMN.Text = "Отчество";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFN.Location = new System.Drawing.Point(9, 112);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(46, 24);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "Имя";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLN.Location = new System.Drawing.Point(9, 48);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(91, 24);
            this.lblLN.TabIndex = 0;
            this.lblLN.Text = "Фамилия";
            // 
            // tbpDeals
            // 
            this.tbpDeals.Controls.Add(this.btnSign);
            this.tbpDeals.Controls.Add(this.btnDecline);
            this.tbpDeals.Controls.Add(this.cbDealStatus);
            this.tbpDeals.Controls.Add(this.lblFDS);
            this.tbpDeals.Controls.Add(this.cbEmployeeId);
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
            this.btnSign.Text = "Заключить сделку";
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
            // cbDealStatus
            // 
            this.cbDealStatus.FormattingEnabled = true;
            this.cbDealStatus.Location = new System.Drawing.Point(573, 67);
            this.cbDealStatus.Name = "cbDealStatus";
            this.cbDealStatus.Size = new System.Drawing.Size(212, 21);
            this.cbDealStatus.TabIndex = 2;
            this.cbDealStatus.SelectedIndexChanged += new System.EventHandler(this.cbDealStatus_SelectedIndexChanged);
            // 
            // lblFDS
            // 
            this.lblFDS.AutoSize = true;
            this.lblFDS.Location = new System.Drawing.Point(570, 51);
            this.lblFDS.Name = "lblFDS";
            this.lblFDS.Size = new System.Drawing.Size(143, 13);
            this.lblFDS.TabIndex = 1;
            this.lblFDS.Text = "Фильтрация по deal_status";
            // 
            // cbEmployeeId
            // 
            this.cbEmployeeId.FormattingEnabled = true;
            this.cbEmployeeId.Location = new System.Drawing.Point(573, 29);
            this.cbEmployeeId.Name = "cbEmployeeId";
            this.cbEmployeeId.Size = new System.Drawing.Size(212, 21);
            this.cbEmployeeId.TabIndex = 2;
            this.cbEmployeeId.SelectedIndexChanged += new System.EventHandler(this.cbEmployeeId_SelectedIndexChanged);
            // 
            // lblFEId
            // 
            this.lblFEId.AutoSize = true;
            this.lblFEId.Location = new System.Drawing.Point(570, 13);
            this.lblFEId.Name = "lblFEId";
            this.lblFEId.Size = new System.Drawing.Size(151, 13);
            this.lblFEId.TabIndex = 1;
            this.lblFEId.Text = "Фильтрация по employee_id ";
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
            this.tbpVacancies.Controls.Add(this.btnChangeVacancyStatus);
            this.tbpVacancies.Controls.Add(this.dgvVacancies);
            this.tbpVacancies.Location = new System.Drawing.Point(4, 22);
            this.tbpVacancies.Name = "tbpVacancies";
            this.tbpVacancies.Size = new System.Drawing.Size(796, 420);
            this.tbpVacancies.TabIndex = 2;
            this.tbpVacancies.Text = "Вакансии";
            this.tbpVacancies.UseVisualStyleBackColor = true;
            // 
            // btnChangeVacancyStatus
            // 
            this.btnChangeVacancyStatus.Location = new System.Drawing.Point(573, 372);
            this.btnChangeVacancyStatus.Name = "btnChangeVacancyStatus";
            this.btnChangeVacancyStatus.Size = new System.Drawing.Size(201, 37);
            this.btnChangeVacancyStatus.TabIndex = 10;
            this.btnChangeVacancyStatus.Text = "Сменить статус";
            this.btnChangeVacancyStatus.UseVisualStyleBackColor = true;
            this.btnChangeVacancyStatus.Click += new System.EventHandler(this.btnChangeVacancyStatus_Click);
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(12, 11);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.Size = new System.Drawing.Size(536, 398);
            this.dgvVacancies.TabIndex = 4;
            // 
            // tbpTables
            // 
            this.tbpTables.Controls.Add(this.cbTables);
            this.tbpTables.Controls.Add(this.lblTables);
            this.tbpTables.Controls.Add(this.dgvTables);
            this.tbpTables.Location = new System.Drawing.Point(4, 22);
            this.tbpTables.Name = "tbpTables";
            this.tbpTables.Size = new System.Drawing.Size(796, 420);
            this.tbpTables.TabIndex = 3;
            this.tbpTables.Text = "Таблицы";
            this.tbpTables.UseVisualStyleBackColor = true;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(573, 31);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(212, 21);
            this.cbTables.TabIndex = 8;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(570, 15);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(52, 13);
            this.lblTables.TabIndex = 6;
            this.lblTables.Text = "Таблицы";
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(12, 11);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.Size = new System.Drawing.Size(536, 398);
            this.dgvTables.TabIndex = 4;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.tabControl1.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            this.tbpInfo.PerformLayout();
            this.tbpDeals.ResumeLayout(false);
            this.tbpDeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            this.tbpVacancies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.tbpTables.ResumeLayout(false);
            this.tbpTables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInfo;
        private System.Windows.Forms.TabPage tbpDeals;
        private System.Windows.Forms.TabPage tbpVacancies;
        private System.Windows.Forms.TabPage tbpTables;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.ComboBox cbDealStatus;
        private System.Windows.Forms.Label lblFDS;
        private System.Windows.Forms.ComboBox cbEmployeeId;
        private System.Windows.Forms.Label lblFEId;
        private System.Windows.Forms.DataGridView dgvDeals;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Button btnChangeVacancyStatus;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.DataGridView dgvTables;
    }
}