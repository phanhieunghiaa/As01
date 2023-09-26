namespace MyStoreWinApp
{
    partial class frmMemberDetails
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
            lbMemberID = new Label();
            lbMemberName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbConfirm = new Label();
            lbAddress = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(79, 40);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(79, 94);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(79, 151);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(79, 202);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Location = new Point(79, 257);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(62, 20);
            lbConfirm.TabIndex = 4;
            lbConfirm.Text = "Confirm";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(79, 310);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 5;
            lbAddress.Text = "Address";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(243, 37);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(243, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(243, 91);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(243, 27);
            txtMemberName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(243, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(243, 254);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(243, 27);
            txtConfirm.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(243, 307);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(243, 27);
            txtAddress.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(128, 386);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(339, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(128, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 464);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbAddress);
            Controls.Add(lbConfirm);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Name = "frmMemberDetails";
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbConfirm;
        private Label lbAddress;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private TextBox txtAddress;
        private Button btnUpdate;
        private Button btnCancel;
        private Button btnAdd;
    }
}