namespace DEMOtivator
{
    partial class Verification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            this.btnEnter = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAuntification = new System.Windows.Forms.TabPage();
            this.tabRegistration = new System.Windows.Forms.TabPage();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.fieldLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fieldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabAuntification.SuspendLayout();
            this.tabRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Location = new System.Drawing.Point(40, 6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(100, 30);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnterClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAuntification);
            this.tabControl.Controls.Add(this.tabRegistration);
            this.tabControl.Location = new System.Drawing.Point(12, 100);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(191, 69);
            this.tabControl.TabIndex = 1;
            // 
            // tabAuntification
            // 
            this.tabAuntification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.tabAuntification.Controls.Add(this.btnEnter);
            this.tabAuntification.Location = new System.Drawing.Point(4, 22);
            this.tabAuntification.Name = "tabAuntification";
            this.tabAuntification.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuntification.Size = new System.Drawing.Size(183, 43);
            this.tabAuntification.TabIndex = 0;
            this.tabAuntification.Text = "Авторизация";
            // 
            // tabRegistration
            // 
            this.tabRegistration.Controls.Add(this.btnRegistration);
            this.tabRegistration.Location = new System.Drawing.Point(4, 22);
            this.tabRegistration.Name = "tabRegistration";
            this.tabRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistration.Size = new System.Drawing.Size(183, 43);
            this.tabRegistration.TabIndex = 1;
            this.tabRegistration.Text = "Регистрация";
            this.tabRegistration.UseVisualStyleBackColor = true;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Location = new System.Drawing.Point(27, 6);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(127, 30);
            this.btnRegistration.TabIndex = 5;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistrationClick);
            // 
            // fieldLogin
            // 
            this.fieldLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.fieldLogin.Location = new System.Drawing.Point(12, 22);
            this.fieldLogin.Name = "fieldLogin";
            this.fieldLogin.Size = new System.Drawing.Size(191, 22);
            this.fieldLogin.TabIndex = 2;
            this.fieldLogin.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // fieldPassword
            // 
            this.fieldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.fieldPassword.Location = new System.Drawing.Point(12, 63);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.Size = new System.Drawing.Size(191, 22);
            this.fieldPassword.TabIndex = 4;
            this.fieldPassword.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(217, 187);
            this.Controls.Add(this.fieldPassword);
            this.Controls.Add(this.fieldLogin);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Verification";
            this.Text = "Autorisation";
            this.Load += new System.EventHandler(this.VerificationLoad);
            this.tabControl.ResumeLayout(false);
            this.tabAuntification.ResumeLayout(false);
            this.tabRegistration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAuntification;
        private System.Windows.Forms.TabPage tabRegistration;
        private System.Windows.Forms.TextBox fieldLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fieldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistration;
    }
}