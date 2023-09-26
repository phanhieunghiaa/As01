using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetails : Form
    {

        public bool InsertOrUpdate { get; set; }
        public IMemberRepository memberRepository { get; set; }
        public MemberObject memberInfo { get; set; }

        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;

            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                txtMemberID.Enabled = false;

                txtMemberID.Text = memberInfo.MemID.ToString();
                txtMemberName.Text = memberInfo.MemName;
                txtEmail.Text = memberInfo.Email;
                txtPassword.Text = memberInfo.Password;
                txtConfirm.Text = memberInfo.Password;
                txtAddress.Text = memberInfo.Address;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong email format!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm must be the same Password!!!");
                }

                MemberObject member = new MemberObject
                {
                    MemID = memberInfo.MemID,
                    MemName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Address = txtAddress.Text,
                };
                memberRepository.UpdateMember(member);
                MessageBox.Show("Member updated!!", "Update member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsEmail(txtEmail.Text))
                {
                    throw new Exception("Wrong email format!!!");
                }
                if (!txtPassword.Text.Equals(txtConfirm.Text))
                {
                    throw new Exception("Confirm must be the same Password!!!");
                }

                MemberObject member = new MemberObject
                {
                    MemID = int.Parse(txtMemberID.Text),
                    MemName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Address = txtAddress.Text,
                };
                memberRepository.AddMember(member);
                MessageBox.Show("Member Added!!!", "Add member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add member", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static class Validation
        {
            public static bool IsEmail(string Email)
            {
                bool result = false;

                var CheckEmail = new EmailAddressAttribute();
                result = CheckEmail.IsValid(Email);
                return result;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
