using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    public partial class frmSearchCatalogue : Form
    {
        public frmSearchCatalogue()
        {
            InitializeComponent();
        }

        Book theBook = new Book();
        Member theMember = new Member();
        string searchType = "";
        DataSet dsCart = new DataSet();
        DataSet dsSearch = new DataSet();

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            lblSearchFor.Visible = true;
            txtSearch.Visible = true;
            txtSearch.Text = "";
            
            if (comboBox1.SelectedIndex == 0)
            {
                searchType = "Title";
                lblSearchFor.Text = "Title: ";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                searchType = "Author";
                lblSearchFor.Text = "Author: ";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                searchType = "GenreCode";
                lblSearchFor.Text = "Genre: ";
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            if (txtSearch.Text != string.Empty)
            {
                string searchFor = txtSearch.Text;
                dgvBookView.Visible = true;
                dsSearch = theBook.getSearchResults(searchType, searchFor);
                dgvBookView.DataSource = dsSearch.Tables["Books"].DefaultView;
                lblAddCart.Visible = true;
            }
            else
                MessageBox.Show("Please enter text into the searchbar");
        }

        private void btnCart_Click(object sender, System.EventArgs e)
        {
            //displays an input box on checkout click, asks for a valid member id before creating a loan
            string memID = Interaction.InputBox("Enter Member id to checkout books", "Checkout");
            if (memID != "")
            {
                Boolean istrue = theMember.getMemberToF(Int32.Parse(memID));

                if (istrue)
                {
                    theMember.getMember(Int32.Parse(memID));
                    if (theMember.getStrikeCount() < 3)
                    { 


                        DateTime Date = DateTime.Now;
                        DateTime reDate = Date.AddDays(14);
                        string dueDate = reDate.ToString("MM-dd-yy");

                        Loan newLoan = new Loan(Loan.getNextLoanID(), Int32.Parse(memID), dueDate);
                        newLoan.createLoan();

                        int count = dgvCart.Rows.Count;

                        for (int i = 0; i < count - 1; i++)
                        {
                            //for each item, creates a loan item that records the loan id and book id
                            int loanid = newLoan.getLoanID();
                            string id = dgvBookView.Rows[i].Cells[0].Value.ToString();
                            theBook.getBook(id);
                            string genre = theBook.getGenre();
                            LoanItem newItem = new LoanItem(loanid, Int32.Parse(id), genre);
                            newItem.createLoanItem();
                        }

                        dsCart.Clear();
                        btnCart.Visible = false;
                        MessageBox.Show("Successfully Checked books to Member " + memID);
                    }
                    else
                    {
                        MessageBox.Show("Member has too many strikes to checkout books, please see librarian");
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("No matching member id, please try again");
                    return;
                }
            }
            else
            {
                return;
            }
        }
        private void dgvBookView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCart.Rows.Count == 0)
            {
                //add the book to cart and update its status, then removes the book from the grid to prevent multiple bookings, makes the cart button visible
                btnCart.Visible = true;
                string id = dgvBookView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (id != "")
                {
                    lblRemCart.Visible = true;
                    theBook.getBook(id);
                    theBook.updateStatusBook("Available");
                    dgvCart.Visible = true;
                    dsCart = theBook.getBookdgv(id);
                    dgvCart.DataSource = dsCart.Tables["Books"].DefaultView;
                }
                else
                {
                    MessageBox.Show("Please Click on a Book");
                    return;
                }
            }

            else if (dgvCart.Rows.Count > 0)
            {
                //add the book to cart and update its status, then removes the book from the grid to prevent multiple bookings
                string id = dgvBookView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (id != "")
                {

                    theBook.getBook(id);
                    theBook.updateStatusBook("Available");
                    btnCart.Visible = true;
                    dsCart.Tables["Books"].Rows.Add(dgvBookView.Rows[e.RowIndex].Cells[0].Value, dgvBookView.Rows[e.RowIndex].Cells[1].Value,
                        dgvBookView.Rows[e.RowIndex].Cells[2].Value, dgvBookView.Rows[e.RowIndex].Cells[3].Value,
                        dgvBookView.Rows[e.RowIndex].Cells[4].Value, dgvBookView.Rows[e.RowIndex].Cells[5].Value);
                }
                else
                {
                    MessageBox.Show("Please Click on a Book");
                    return;
                }
            }
            

        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //removes the book from the cart, updates its status and adds it back to the grid
            string id = dgvBookView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (id != "")
            {
                theBook.getBook(id);
                theBook.updateStatusBook("Unavailable");

                dgvCart.Rows.RemoveAt(dgvCart.SelectedCells[0].RowIndex);
                if (dgvCart.Rows.Count == 1)
                {
                    //if there is nothing in the cart removes the checkout button
                    btnCart.Visible = false;
                    lblRemCart.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Please Click on a Book");
                return;
            }
        }

        
    }
}
