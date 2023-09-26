using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {

        public MemberObject loginMember { get; set; }
        IMemberRepository memberRepository = new MemberRepository();

        BindingSource source;
        BindingSource AddressSource;

        bool search = false;
        bool filter = false;
        IEnumerable<MemberObject> dataSource;
        IEnumerable<MemberObject> searchResult;
        IEnumerable<MemberObject> filterResult;

        IEnumerable<string> ListAddress;

        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = false;
            txtMemberName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;
            btnLoad.Enabled = true;
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            grFilter.Enabled = false;
            dgvList.Enabled = false;
            rdoID.Checked = true;

        }

        private MemberObject GetMemberInfo()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemID = int.Parse(txtMemberID.Text),
                    MemName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Address = txtAddress.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Member Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return member;
        }

        private void LoadMemberList()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = filter ? filterResult : dataSource;
                if (!filter)
                {
                    ListAddress = from member in dataSource
                                  where !string.IsNullOrEmpty(member.Address.Trim())
                                  orderby member.Address ascending
                                  select member.Address;
                    ListAddress = ListAddress.Distinct();

                    ListAddress = ListAddress.Prepend("All");

                    if (dataSource.Count() > 0)
                    {
                        AddressSource = new BindingSource();
                        AddressSource.DataSource = ListAddress;
                        cbAddress.DataSource = null;
                        cbAddress.DataSource = AddressSource;
                    }
                }

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtAddress.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemID");
                txtMemberName.DataBindings.Add("Text", source, "MemName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtAddress.DataBindings.Add("Text", source, "Address");

                dgvList.DataSource = null;
                dgvList.DataSource = source;

                if (dataSource.Count() > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }

        private void LoadFullList()
        {
            search = false;
            filter = false;
            var members = memberRepository.GetMembersList();
            var memberList = from member in members
                             orderby member.MemName descending
                             select member;
            dataSource = memberList;
            searchResult = memberList;
            filterResult = memberList;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            dgvList.Enabled = true;
            btnLoad.Enabled = true;
            grFilter.Enabled = true;
            LoadFullList();
            LoadMemberList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                memberRepository = this.memberRepository,
                InsertOrUpdate = true,
                Text = "Add new member"
            };

            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MemberObject member = GetMemberInfo();
            if (member.MemID == loginMember.MemID)
            {
                MessageBox.Show("Cannot delete current account!!!", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Delete this member? \n" +
                $"Member ID: {member.MemID}\n" +
                $"Member Name: {member.MemName}\n" +
                $"Email: {member.Email}\n" +
                $"Address: {member.Address}",
                "Delete member", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    memberRepository.DeleteMember(member.MemID);
                    search = false;
                    LoadFullList();
                    LoadMemberList();
                }
            }

        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MemberObject member = GetMemberInfo();

            frmMemberDetails frmMemberDetails = new frmMemberDetails
            {
                memberRepository = this.memberRepository,
                InsertOrUpdate = false,
                memberInfo = member,
                Text = "Update member info"
            };

            if (frmMemberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadFullList();

                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text;
                if (rdoID.Checked)
                {
                    int searchID = int.Parse(searchValue);
                    IEnumerable<MemberObject> searchResult = memberRepository.SearchID(searchID);
                    if (searchResult.Any())
                    {
                        dataSource = searchResult;
                        this.searchResult = searchResult;
                        this.filterResult = searchResult;
                        filter = false;
                        search = true;
                        LoadMemberList();
                    }
                    else
                    {
                        MessageBox.Show("Found nothing!!!", "Search by ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (rdoName.Checked)
                {
                    string searchName = searchValue;
                    IEnumerable<MemberObject> searchResult = memberRepository.SearchName(searchName);
                    if (searchResult.Any())
                    {
                        dataSource = searchResult;
                        this.searchResult = searchResult;
                        this.filterResult = searchResult;
                        filter = false;
                        search = true;
                        LoadMemberList();
                    }
                    else
                    {
                        MessageBox.Show("Found nothing!!!", "Search by name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbAddress.DataSource != null)
                {
                    string address = cbAddress.SelectedItem.ToString();

                    if (!string.IsNullOrEmpty(address))
                    {
                        IEnumerable<MemberObject> searchResult;
                        
                        searchResult = memberRepository.SearchAddress(address, this.searchResult);
                        

                        if (searchResult.Any())
                        {
                            filter = true;
                            filterResult = searchResult;
                            LoadMemberList();
                        }
                        else
                        {
                            MessageBox.Show("Found nothing!!!", "Search member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
