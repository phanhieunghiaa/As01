namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbAddress = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            lbSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lbAddressFilter = new Label();
            cbAddress = new ComboBox();
            grFilter = new GroupBox();
            dgvList = new DataGridView();
            rdoID = new RadioButton();
            rdoName = new RadioButton();
            grFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(12, 9);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(84, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(12, 54);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 1;
            lbMemberName.Text = "Member Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(415, 9);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(415, 54);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(12, 101);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(62, 20);
            lbAddress.TabIndex = 4;
            lbAddress.Text = "Address";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(127, 6);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(264, 27);
            txtMemberID.TabIndex = 5;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(127, 51);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(264, 27);
            txtMemberName.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(127, 98);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(264, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(491, 6);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(491, 51);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 27);
            txtPassword.TabIndex = 9;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(97, 160);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(347, 160);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(592, 160);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(37, 237);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(53, 20);
            lbSearch.TabIndex = 13;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(96, 234);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(37, 280);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lbAddressFilter
            // 
            lbAddressFilter.AutoSize = true;
            lbAddressFilter.Location = new Point(8, 32);
            lbAddressFilter.Name = "lbAddressFilter";
            lbAddressFilter.Size = new Size(62, 20);
            lbAddressFilter.TabIndex = 16;
            lbAddressFilter.Text = "Address";
            // 
            // cbAddress
            // 
            cbAddress.FormattingEnabled = true;
            cbAddress.Location = new Point(76, 29);
            cbAddress.Name = "cbAddress";
            cbAddress.Size = new Size(176, 28);
            cbAddress.TabIndex = 17;
            cbAddress.SelectedIndexChanged += cbAddress_SelectedIndexChanged;
            // 
            // grFilter
            // 
            grFilter.Controls.Add(lbAddressFilter);
            grFilter.Controls.Add(cbAddress);
            grFilter.Location = new Point(491, 205);
            grFilter.Name = "grFilter";
            grFilter.Size = new Size(271, 81);
            grFilter.TabIndex = 18;
            grFilter.TabStop = false;
            grFilter.Text = "Filter";
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(37, 329);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.RowTemplate.Height = 29;
            dgvList.Size = new Size(726, 298);
            dgvList.TabIndex = 19;
            dgvList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // rdoID
            // 
            rdoID.AutoSize = true;
            rdoID.Location = new Point(246, 235);
            rdoID.Name = "rdoID";
            rdoID.Size = new Size(45, 24);
            rdoID.TabIndex = 20;
            rdoID.TabStop = true;
            rdoID.Text = "ID";
            rdoID.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            rdoName.AutoSize = true;
            rdoName.Location = new Point(246, 262);
            rdoName.Name = "rdoName";
            rdoName.Size = new Size(70, 24);
            rdoName.TabIndex = 21;
            rdoName.TabStop = true;
            rdoName.Text = "Name";
            rdoName.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(rdoName);
            Controls.Add(rdoID);
            Controls.Add(dgvList);
            Controls.Add(grFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbAddress);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbMemberName);
            Controls.Add(lbMemberID);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            grFilter.ResumeLayout(false);
            grFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberID;
        private Label lbMemberName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbAddress;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Label lbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lbAddressFilter;
        private ComboBox cbAddress;
        private GroupBox grFilter;
        private DataGridView dgvList;
        private RadioButton rdoID;
        private RadioButton rdoName;
    }
}