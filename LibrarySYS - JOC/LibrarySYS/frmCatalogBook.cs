using System;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmCatalogBook : Form
    {
        public frmCatalogBook()
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
            Boolean isTrue = false;

            if(txtTitle.Text == "")
            {
                MessageBox.Show("Please enter a Title");
                isTrue = true;
                txtTitle.Focus();
                return;
            }
            if (txtAuthor.Text == "")
            {
                MessageBox.Show("Please enter an Author");
                isTrue = true;
                txtAuthor.Focus();
                return;
            }
            if (txtGenre.Text == "")
            {
                MessageBox.Show("Please enter a Genre");
                isTrue = true;
                txtGenre.Focus();
                return;
            }
            if (txtRelDate.Text == "" || txtRelDate.Text == "YYYY-MMM-DD")
            {
                MessageBox.Show("Please enter a Release Date");
                isTrue = true;
                txtRelDate.Focus();
                return;
            }
            

            if(isTrue == false)
            {
                btnContinue.Visible = true;
                txtPopUp.Visible = true;
                txtTitleCon.Visible = true;
                txtAuthorCon.Visible = true;
                txtGenreCon.Visible = true;
                txtBookID.Text = "Book ID =" + Book.getNextBookID();
                txtBookID.Visible = true;
                txtReleaseDateCon.Visible = true;
                DateTime newDT = DateTime.Parse(txtRelDate.Text);
                Book newBook = new Book(Book.getNextBookID(), txtTitle.Text, txtAuthor.Text, newDT.ToString("yyyy-MMM-dd"), txtGenre.Text);
                newBook.addBook();
                txtTitleCon.Text = "Title: " + txtTitle.Text;
                txtAuthorCon.Text = "Author: " + txtAuthor.Text;
                txtReleaseDateCon.Text = "Release Date: " + txtRelDate.Text;
                txtGenreCon.Text = "Genre: " + txtGenre.Text;
            }

            
            
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can now return to the main menu\n or add another book");
            
            txtAuthorCon.Visible=false;
            txtReleaseDateCon.Visible=false;
            txtGenreCon.Visible=false;
            txtPopUp.Visible=false;
            btnContinue.Visible=false;
            txtBookID.Visible=false;
            txtTitleCon.Clear();
            txtAuthorCon.Clear();
            txtReleaseDateCon.Clear();
            txtGenreCon.Clear();
            txtRelDate.Text = "YYYY-MMM-DD";
            
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtTitle.Focus();
            

        }
    }
}
