namespace PIS_CW
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_ExitSystem = new System.Windows.Forms.Button();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(37, 58);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(284, 20);
            this.tb_Login.TabIndex = 0;
            this.tb_Login.Text = "manager1";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(37, 192);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(139, 52);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(34, 42);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(38, 13);
            this.lbl_Login.TabIndex = 2;
            this.lbl_Login.Text = "Логин";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(37, 111);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(284, 20);
            this.tb_Password.TabIndex = 0;
            this.tb_Password.Text = "hashpass1";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(34, 95);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(45, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Пароль";
            // 
            // btn_ExitSystem
            // 
            this.btn_ExitSystem.Location = new System.Drawing.Point(37, 250);
            this.btn_ExitSystem.Name = "btn_ExitSystem";
            this.btn_ExitSystem.Size = new System.Drawing.Size(284, 52);
            this.btn_ExitSystem.TabIndex = 1;
            this.btn_ExitSystem.Text = "Выйти из системы";
            this.btn_ExitSystem.UseVisualStyleBackColor = true;
            this.btn_ExitSystem.Click += new System.EventHandler(this.btn_ExitSystem_Click);
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(182, 192);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(139, 52);
            this.btn_Registration.TabIndex = 3;
            this.btn_Registration.Text = "Зарегистрироваться";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 321);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.btn_ExitSystem);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_ExitSystem;
        private System.Windows.Forms.Button btn_Registration;
    }
}

