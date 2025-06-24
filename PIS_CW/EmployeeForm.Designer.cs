namespace PIS_CW
{
    partial class EmployeeForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbQualificaton = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblI = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMN = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.tbpVacancies = new System.Windows.Forms.TabPage();
            this.btnApplyForVacancy = new System.Windows.Forms.Button();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.tbpDeals = new System.Windows.Forms.TabPage();
            this.dgvDeals = new System.Windows.Forms.DataGridView();
            this.cbTypeOfBusiness = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpInfo.SuspendLayout();
            this.tbpVacancies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.tbpDeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).BeginInit();
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
            this.tbpInfo.Controls.Add(this.richTextBox1);
            this.tbpInfo.Controls.Add(this.tbQualificaton);
            this.tbpInfo.Controls.Add(this.tbPhoneNumber);
            this.tbpInfo.Controls.Add(this.tbMiddleName);
            this.tbpInfo.Controls.Add(this.tbFirstName);
            this.tbpInfo.Controls.Add(this.tbLastName);
            this.tbpInfo.Controls.Add(this.btnLogOut);
            this.tbpInfo.Controls.Add(this.lblI);
            this.tbpInfo.Controls.Add(this.btnSaveChanges);
            this.tbpInfo.Controls.Add(this.lblQ);
            this.tbpInfo.Controls.Add(this.lblPN);
            this.tbpInfo.Controls.Add(this.btnClose);
            this.tbpInfo.Controls.Add(this.lblMN);
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(239, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(280, 273);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // tbQualificaton
            // 
            this.tbQualificaton.Location = new System.Drawing.Point(6, 283);
            this.tbQualificaton.Name = "tbQualificaton";
            this.tbQualificaton.Size = new System.Drawing.Size(201, 20);
            this.tbQualificaton.TabIndex = 6;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(6, 223);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(201, 20);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(10, 158);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(201, 20);
            this.tbMiddleName.TabIndex = 6;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(10, 94);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(201, 20);
            this.tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(10, 30);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(201, 20);
            this.tbLastName.TabIndex = 6;
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
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblI.Location = new System.Drawing.Point(239, 3);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(280, 24);
            this.lblI.TabIndex = 0;
            this.lblI.Text = "Дополнительная информация";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(573, 284);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(201, 37);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQ.Location = new System.Drawing.Point(6, 256);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(140, 24);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Квалификация";
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPN.Location = new System.Drawing.Point(6, 196);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(162, 24);
            this.lblPN.TabIndex = 0;
            this.lblPN.Text = "Номер телефона";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(573, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(201, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Выйти из системы";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMN
            // 
            this.lblMN.AutoSize = true;
            this.lblMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMN.Location = new System.Drawing.Point(6, 131);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(98, 24);
            this.lblMN.TabIndex = 0;
            this.lblMN.Text = "Отчество";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFN.Location = new System.Drawing.Point(6, 67);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(46, 24);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "Имя";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLN.Location = new System.Drawing.Point(6, 3);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(91, 24);
            this.lblLN.TabIndex = 0;
            this.lblLN.Text = "Фамилия";
            // 
            // tbpVacancies
            // 
            this.tbpVacancies.Controls.Add(this.cbTypeOfBusiness);
            this.tbpVacancies.Controls.Add(this.label1);
            this.tbpVacancies.Controls.Add(this.btnApplyForVacancy);
            this.tbpVacancies.Controls.Add(this.dgvVacancies);
            this.tbpVacancies.Location = new System.Drawing.Point(4, 22);
            this.tbpVacancies.Name = "tbpVacancies";
            this.tbpVacancies.Size = new System.Drawing.Size(796, 420);
            this.tbpVacancies.TabIndex = 2;
            this.tbpVacancies.Text = "Вакансии";
            this.tbpVacancies.UseVisualStyleBackColor = true;
            // 
            // btnApplyForVacancy
            // 
            this.btnApplyForVacancy.Location = new System.Drawing.Point(573, 372);
            this.btnApplyForVacancy.Name = "btnApplyForVacancy";
            this.btnApplyForVacancy.Size = new System.Drawing.Size(201, 37);
            this.btnApplyForVacancy.TabIndex = 10;
            this.btnApplyForVacancy.Text = "Подать кандидатуру";
            this.btnApplyForVacancy.UseVisualStyleBackColor = true;
            this.btnApplyForVacancy.Click += new System.EventHandler(this.btnApplyForVacancy_Click);
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(12, 11);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.Size = new System.Drawing.Size(536, 398);
            this.dgvVacancies.TabIndex = 4;
            // 
            // tbpDeals
            // 
            this.tbpDeals.Controls.Add(this.dgvDeals);
            this.tbpDeals.Location = new System.Drawing.Point(4, 22);
            this.tbpDeals.Name = "tbpDeals";
            this.tbpDeals.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeals.Size = new System.Drawing.Size(796, 420);
            this.tbpDeals.TabIndex = 1;
            this.tbpDeals.Text = "Сделки";
            this.tbpDeals.UseVisualStyleBackColor = true;
            // 
            // dgvDeals
            // 
            this.dgvDeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeals.Location = new System.Drawing.Point(12, 9);
            this.dgvDeals.Name = "dgvDeals";
            this.dgvDeals.Size = new System.Drawing.Size(536, 398);
            this.dgvDeals.TabIndex = 0;
            // 
            // cbTypeOfBusiness
            // 
            this.cbTypeOfBusiness.FormattingEnabled = true;
            this.cbTypeOfBusiness.Location = new System.Drawing.Point(573, 27);
            this.cbTypeOfBusiness.Name = "cbTypeOfBusiness";
            this.cbTypeOfBusiness.Size = new System.Drawing.Size(212, 21);
            this.cbTypeOfBusiness.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Фильтрация по виду деятельности";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tbpInfo.ResumeLayout(false);
            this.tbpInfo.PerformLayout();
            this.tbpVacancies.ResumeLayout(false);
            this.tbpVacancies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.tbpDeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpInfo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.TabPage tbpDeals;
        private System.Windows.Forms.DataGridView dgvDeals;
        private System.Windows.Forms.TabPage tbpVacancies;
        private System.Windows.Forms.Button btnApplyForVacancy;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblPN;
        private System.Windows.Forms.TextBox tbQualificaton;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.ComboBox cbTypeOfBusiness;
        private System.Windows.Forms.Label label1;
    }
}