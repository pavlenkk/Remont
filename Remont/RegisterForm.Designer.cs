namespace Remont
{
    partial class RegisterForm
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MidnightBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(495, 541);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(429, 105);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Зарегистрироваться";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.Location = new Point(610, 353);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(377, 50);
            txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtUsername.Location = new Point(610, 264);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(377, 50);
            txtUsername.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(392, 353);
            label3.Name = "label3";
            label3.Size = new Size(158, 50);
            label3.TabIndex = 8;
            label3.Text = "Пароль:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(392, 264);
            label2.Name = "label2";
            label2.Size = new Size(134, 50);
            label2.TabIndex = 7;
            label2.Text = "Логин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(473, 56);
            label1.Name = "label1";
            label1.Size = new Size(432, 92);
            label1.TabIndex = 6;
            label1.Text = "Регистрация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(392, 438);
            label4.Name = "label4";
            label4.Size = new Size(112, 50);
            label4.TabIndex = 12;
            label4.Text = "Роль:";
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "администратор", "сотрудник" });
            cmbRole.Location = new Point(610, 435);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(377, 53);
            cmbRole.TabIndex = 13;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 703);
            Controls.Add(cmbRole);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbRole;
    }
}