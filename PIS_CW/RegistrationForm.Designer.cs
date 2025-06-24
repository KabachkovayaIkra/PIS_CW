namespace PIS_CW
{
    partial class RegistrationForm
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
            this.btn_Registration = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(37, 155);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(284, 52);
            this.btn_Registration.TabIndex = 9;
            this.btn_Registration.Text = "Зарегистрироваться";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(34, 95);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 13);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Пароль";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(34, 42);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(38, 13);
            this.lbl_Login.TabIndex = 8;
            this.lbl_Login.Text = "Логин";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(37, 111);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(284, 20);
            this.tb_Password.TabIndex = 4;
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(37, 58);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(284, 20);
            this.tb_Login.TabIndex = 5;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 219);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Login;
    }
}