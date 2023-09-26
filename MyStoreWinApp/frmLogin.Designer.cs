namespace MyStoreWinApp
{
    partial class frmLogin
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
            lbLoginTitle = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbLoginTitle
            // 
            lbLoginTitle.AutoSize = true;
            lbLoginTitle.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbLoginTitle.ImageAlign = ContentAlignment.TopCenter;
            lbLoginTitle.Location = new Point(342, 21);
            lbLoginTitle.Name = "lbLoginTitle";
            lbLoginTitle.RightToLeft = RightToLeft.No;
            lbLoginTitle.Size = new Size(124, 40);
            lbLoginTitle.TabIndex = 0;
            lbLoginTitle.Text = "LOGIN";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(223, 123);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 19);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(223, 216);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(80, 19);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(223, 243);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(355, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(263, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(432, 352);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbLoginTitle);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLoginTitle;
        private Label lbEmail;
        private Label lbPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}