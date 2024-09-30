using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmPayFee : Form
    {
        Member theMember = new Member();
        public frmPayFee()
        {
            InitializeComponent();
        }
        

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void btnRetrFee_Click(object sender, System.EventArgs e)
        {
            string MemID = txtMemberID.Text;
            int id = Int32.Parse(MemID);
            if (theMember.getMemberToF(id) == true)
            {
                theMember.getMember(id);
                if (theMember.getFeeAmount() != 0)
                {
                    btnPayFee.Visible = true;
                    lblFeeAmount.Visible = true;
                    lblFeeAmount.Text = lblFeeAmount.Text + theMember.getFeeAmount();
                    lblBankCardNo.Visible = true;
                    lblCVV.Visible = true;
                    txtBankCardNo.Visible = true;
                    txtCVV.Visible = true;
                }
                else
                {
                    MessageBox.Show("No Fee due");
                    txtMemberID.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please try enter MemberID again\nMemberID must be all digits");
                txtMemberID.Text = "";
                txtMemberID.Focus();
            }
        }
        private void btnPayFee_Click(object sender, System.EventArgs e)
        {
            if (txtBankCardNo.Text.Length == 16 && txtCVV.Text.Length == 3)
            {
                MessageBox.Show("Fee paid\nBankCard: " + txtBankCardNo.Text);
                txtBankCardNo.Text = "";
                txtCVV.Text = "";
                theMember.updateFee("Sub");
                this.Close();
                frmPayFee frmPayFee = new frmPayFee();
                frmPayFee.Show();
            }
            else
            {
                MessageBox.Show("Please try again");
                txtBankCardNo.Text = "";
                txtCVV.Text = "";
                txtBankCardNo.Focus();
            }
        }
    }
}
