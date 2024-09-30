using Oracle.ManagedDataAccess.Client;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmRegisterMember : Form
    {
        public frmRegisterMember()
        {
            InitializeComponent();
        }
        private void btnRegMem_Click(object sender, System.EventArgs e)
        {
            string final = "This Member has been sucessfully registered: ";
            if (txtForeName.Text != string.Empty && txtForeName.Text.Any(char.IsDigit) == false)
            {
                string name = txtForeName.Text;
                final += "\nForename: " + name;
            }
            else
            {
                MessageBox.Show("Please try again");
                txtForeName.Clear();
                txtForeName.Focus();
            }

            if (txtSurName.Text != string.Empty && txtSurName.Text.Any(char.IsDigit) == false)
            {
                string surname = txtSurName.Text;
                final += "\nSurname: " + surname;
            }
            else
            {
                MessageBox.Show("Please try again");
                txtSurName.Clear();
                txtSurName.Focus();
            }
            string phoneNum = txtPhone.Text;
            if (txtPhone.Text != string.Empty && phoneNum.Any(char.IsLetter) == false && phoneNum.Length == 10)
            {
                final += "\nPhone: " + phoneNum;
            }
            else
            {
                MessageBox.Show("Please try again");
                txtPhone.Clear();
                txtPhone.Focus();
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
            Boolean valid = true;
            if (txtEirCode.Text == string.Empty || txtCounty.Text == string.Empty || txtStreet.Text == string.Empty ||
                txtHouseNo.Text == string.Empty || txtPhone.Text == string.Empty || txtSurName.Text == string.Empty || txtForeName.Text == string.Empty)
            {
                final = "All fields marked with a '*' must be filled";
                valid = false;
            }

            if (valid == true)
            {

                //final += "\nMemberId assigned: " + Member.getNextMemberID();

                //create instance of member
                Member newMember = new Member(Member.getNextMemberID(), txtForeName.Text, txtSurName.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text,
                txtCounty.Text, txtEirCode.Text, txtPhone.Text, txtEmail.Text);

                MessageBox.Show(final + "\nPlease take note of your member id: " + Member.getNextMemberID());

                //add member
                newMember.addMember();

                //clear text fields
                txtForeName.Clear();
                txtSurName.Clear();
                txtHouseNo.Clear();
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEirCode.Clear();
                txtPhone.Clear();
                txtEmail.Clear();           
            }


            //MessageBox.Show(final);
            //txtForeName.Clear();
            //txtSurName.Clear();
            //txtHouseNo.Clear();
            //txtStreet.Clear();
            //txtTown.Clear();
            //txtCounty.Clear();
            //txtEirCode.Clear();
            //txtPhone.Clear();
            //txtEmail.Clear();
            

            //Member newMember = new Member(Member.getNextMemberID(), txtForeName.Text, txtSurName.Text, txtHouseNo.Text, txtStreet.Text, txtTown.Text,
            //    txtCounty.Text, txtEirCode.Text, txtPhone.Text, txtEmail.Text, 'A', 0, 0);
            //newMember.addMember();
          
            

        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        
    }
}
