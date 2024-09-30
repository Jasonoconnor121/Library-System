using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {
        Member theMember = new Member();
        public frmUpdateMember()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void btnUpdateMember_Click(object sender, System.EventArgs e)
        {
            string final = "The following details have been updated: ";
            if (txtForeName.Text != string.Empty && txtForeName.Text.Any(char.IsDigit) == false)
            {
                string name = txtForeName.Text;
                final += "\nForename: " + name;
            }
            if (txtForeName.Text.Any(char.IsDigit) == true)
            {
                MessageBox.Show("Incorrect Forename - Must be comprised of letters");
                txtForeName.Text = string.Empty;
            }

            if (txtSurName.Text != string.Empty && txtSurName.Text.Any(char.IsDigit) == false)
            {
                string surname = txtSurName.Text;
                final += "\nSurname: " + surname;
            }
            if (txtSurName.Text.Any(char.IsDigit) == true)
            {
                MessageBox.Show("Incorrect Surname- Must be comprised of letters");
                txtSurName.Text = string.Empty;
            }

            if (txtPhone.Text != string.Empty && txtPhone.Text.Any(char.IsLetter) == false && txtPhone.Text.Length == 10)
            {
                string phone = txtPhone.Text;
                final += "\nPhone: " + phone;
            }
            if (txtPhone.Text.Any(char.IsLetter) == true || txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Incorrect Phone number- Must be 10 DIGITS");
            }

            if (txtEmail.Text != string.Empty)
            {
                string email = txtEmail.Text;
                final += "\nEmail: " + email;
            }
            if (txtHouseNo.Text != string.Empty)
            {
                string house = txtHouseNo.Text;
                final += "\nHouse No: " + house;
            }
            if (txtStreet.Text != string.Empty)
            {
                string street = txtStreet.Text;
                final += "\nStreet: " + street;
            }
            if (txtTown.Text != string.Empty)
            {
                string town = txtTown.Text;
                final += "\nTown: " + town;
            }
            if (txtCounty.Text != string.Empty)
            {
                string county = txtCounty.Text;
                final += "\nCounty: " + county;
            }
            if (txtEirCode.Text != string.Empty)
            {
                string eircode = txtEirCode.Text;
                final += "\nEirCode: " + eircode;
            }

            theMember.getMemberID();
            theMember.setForeName(txtForeName.Text);
            theMember.setSurName(txtSurName.Text);
            theMember.setHouseNo(txtHouseNo.Text);
            theMember.setStreet(txtStreet.Text);
            theMember.setTown(txtTown.Text);
            theMember.setCounty(txtCounty.Text);
            theMember.setEircode(txtEirCode.Text);
            theMember.setPhoneNo(txtPhone.Text);
            theMember.setEmail(txtEmail.Text);

            theMember.updateMember();



            MessageBox.Show(final);
            lblForeName.Visible = false;
            lblSurName.Visible = false;
            lblHouseNo.Visible = false;
            lblStreet.Visible = false;
            lblTown.Visible = false;
            lblCounty.Visible = false;
            lblEirCode.Visible = false;
            lblPhone.Visible = false;
            lblEmail.Visible = false;
            txtForeName.Visible = false;
            txtSurName.Visible = false;
            txtHouseNo.Visible = false;
            txtStreet.Visible = false;
            txtTown.Visible = false;
            txtCounty.Visible = false;
            txtEirCode.Visible = false;
            txtPhone.Visible = false;
            txtEmail.Visible = false;

            txtForeName.Clear();
            txtSurName.Clear();
            txtHouseNo.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtEirCode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtMemID.Clear();


        }

        private void btnRetrieve_Click(object sender, System.EventArgs e)
        {
            string MemID = txtMemID.Text;
            int id = Int32.Parse(MemID);
            if (theMember.getMemberToF(id) == true)
            {
                int MembID = int.Parse(txtMemID.Text);
                theMember.getMember(MembID);
                txtForeName.Text = theMember.getForeName();
                lblForeName.Visible = true;
                txtSurName.Text = theMember.getSurName();
                lblSurName.Visible = true;
                txtHouseNo.Text = theMember.getHouseNo();
                lblHouseNo.Visible = true;
                txtStreet.Text = theMember.getStreet();
                lblStreet.Visible = true;
                txtTown.Text = theMember.getTown();
                lblTown.Visible = true;
                txtCounty.Text = theMember.getCounty();
                lblCounty.Visible = true;
                txtEirCode.Text = theMember.getEircode();
                lblEirCode.Visible = true;
                txtPhone.Text = theMember.getPhoneNo();
                lblPhone.Visible = true;
                txtEmail.Text = theMember.getEmail();
                lblEmail.Visible = true;
                txtForeName.Visible = true;
                txtSurName.Visible = true;
                txtHouseNo.Visible = true;
                txtStreet.Visible = true;
                txtTown.Visible = true;
                txtCounty.Visible = true;
                txtEirCode.Visible = true;
                txtPhone.Visible = true;
                txtEmail.Visible = true;
                btnUpdateMember.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a Valid Member ID\nMember IDs are comprised of digits only");
                txtMemID.Clear();
                txtMemID.Focus();
            }
        }
    }
}
