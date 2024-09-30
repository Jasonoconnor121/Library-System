using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmRemoveMember : Form
    {
        Member theMember = new Member();
        public frmRemoveMember()
        {
            InitializeComponent();
        }

        private void btnRetrieve_Click(object sender, System.EventArgs e)
        {
            string memID = txtMemID.Text;
            int id = Int32.Parse(memID);
            if (theMember.getMemberToF(id) == true)
            {
                int MembID = int.Parse(txtMemID.Text);
                theMember.getMember(MembID);
                txtForename.Visible = true;
                txtSurname.Visible = true;
                txtMemberID.Visible = true;
                txtStatus.Visible = true;
                txtStrike.Visible = true;
                btnRemoveMember.Visible = true;
                txtForename.Text = "Forename: " + theMember.getForeName();
                txtSurname.Text = "Surname: " + theMember.getSurName();
                txtMemberID.Text = "Member ID: " + MembID;
                txtStatus.Text = "Status: " + theMember.getStatus();
                txtStrike.Text = "Strikes recieved: " + theMember.getStrikeCount();
            }
            else
            {
                MessageBox.Show("Please enter a Valid Member ID\nMember IDs are comprised of digits only");
                txtMemID.Clear();
            }

        }

        private void btnRemoveMember_Click(object sender, System.EventArgs e)
        {
            if (theMember.getStrikeCount() < 3)
            {
                MessageBox.Show("Member must have at least 3 strikes to validate deactivation");
                return;
            }

            else
            {
                theMember.deactivateMember();
                txtForename.Visible = false;
                txtSurname.Visible = false;
                txtMemberID.Visible = false;
                txtStatus.Visible = false;
                txtStrike.Visible = false;
                btnRemoveMember.Visible = false;
                MessageBox.Show(txtMemberID.Text + " \nStatus: " + theMember.getStatus());

                txtForename.Clear();
                txtSurname.Clear();
                txtMemID.Clear();
                txtStatus.Clear();
                txtStrike.Clear();
                txtMemberID.Clear();
            }
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }
    }
}
