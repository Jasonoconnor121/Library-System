using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmViewMember : Form
    {
        Member theMember = new Member();
        public frmViewMember()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            string MemID = txtMemID.Text;
            int id = Int32.Parse(MemID);
            if (theMember.getMemberToF(id) == true)
            {
                int MembID = int.Parse(txtMemID.Text);
                theMember.getMember(MembID);
                lblForeName.Text += theMember.getForeName();
                lblForeName.Visible = true;
                lblSurName.Text += theMember.getSurName();
                lblSurName.Visible = true;
                lblHouseNo.Text += theMember.getHouseNo();
                lblHouseNo.Visible = true;
                lblStreet.Text += theMember.getStreet();
                lblStreet.Visible = true;
                lblTown.Text += theMember.getTown();
                lblTown.Visible = true;
                lblCounty.Text += theMember.getCounty();
                lblCounty.Visible = true;
                lblEirCode.Text += theMember.getEircode();
                lblEirCode.Visible = true;
                lblPhone.Text += theMember.getPhoneNo();
                lblPhone.Visible = true;
                lblEmail.Text += theMember.getEmail();
                lblEmail.Visible = true;
                lblStrike.Text += theMember.getStrikeCount();
                lblStrike.Visible = true;
                lblFee.Text += theMember.getFeeAmount();
                lblFee.Visible = true;
                btnPayFee.Visible = true;


            }
            else
            {
                MessageBox.Show("Please enter a Valid Member ID\nMember IDs are comprised of digits only");
                txtMemID.Clear();
                txtMemID.Focus();
            }
        }

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPayFee payFee = new frmPayFee();
            payFee.Show();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }
    }
}
