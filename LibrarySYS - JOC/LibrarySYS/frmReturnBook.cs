using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LibrarySYS
{
    public partial class frmReturnBook : Form
    {
        Member theMember = new Member();
        DataSet dsViewLoan = new DataSet();
        LoanItem theItem = new LoanItem();
        Loan theLoan = new Loan();
        Book theBook = new Book();
        string memid;
        public frmReturnBook()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        

        private void btnPayFee_Click(object sender, EventArgs e)
        {
            DialogResult yesNo = MessageBox.Show("Do you want to Pay Fees now?", "Pay Fee Now", MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {
                this.Close();
                frmPayFee payFee = new frmPayFee();
                payFee.Show();
            }
        }

        private void btnViewLoan_Click(object sender, EventArgs e)
        {
            memid = txtMemid.Text;
            Boolean isTrue = theMember.getMemberToF(Int32.Parse(memid));

            if(isTrue )
            {
                dsViewLoan = theItem.getAllLoanItems(Int32.Parse(memid));
                dgvLoanView.DataSource = dsViewLoan.Tables["Books"].DefaultView;
                dgvLoanView.Visible = true;
            }
            

        }

        private void dgvLoanView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve loan id, book id and title from the cell clicked on, for use in the following code
            string loanid = dgvLoanView.Rows[e.RowIndex].Cells[0].Value.ToString();
            string bid = dgvLoanView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string title = dgvLoanView.Rows[e.RowIndex].Cells[2].Value.ToString();
            //set dates for fee checks
            DateTime curDate = DateTime.Now;
            string returnDate = curDate.ToString("MM-dd-yy");
            DateTime dueDate = theLoan.getDueDate(loanid);
            //check if cell clicked on is empty or not
            if (bid != "")
            {
                DialogResult dialog = MessageBox.Show("Return " + title + "?", "Return", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    


                    //get loan item 
                    theItem.getLoanItem(Int32.Parse(loanid), Int32.Parse(bid));

                    //update the status to reflect its been returned
                    theItem.updateStatusLoanItem(bid);

                    //update date for an item
                    theItem.setReturnDate(returnDate);
                    theItem.updateDate();
                    theBook.getBook(bid);
                    theBook.updateStatusBook("Unavailable");

                    //remove the row selected
                    dgvLoanView.Rows.RemoveAt(dgvLoanView.SelectedCells[0].RowIndex);

                    //returns loan id
                    theLoan.getLoanByMem(Int32.Parse(memid));

                    //assign loan id to variable
                    int lid = theLoan.getLoanID();

                    //check if return is late
                    int value = DateTime.Compare(curDate, dueDate);
                    if (value > 0)
                    {
                        MessageBox.Show("Late Return , Fee has been added to member account");
                        theMember.getMember(Int32.Parse(memid));
                        //update fee and strike count
                        theMember.updateFee("Add");
                        btnPayFee.Visible = true;
                    }

                    if (theLoan.checkLoan(lid.ToString()) == false)
                    {
                        //updates loan status to Closed
                        theLoan.getLoan(lid);
                        theLoan.updateStatusLoan(lid);

                        //check strike count
                        int check = theMember.getStrikeCount();

                        if (check >= 3) 
                        {
                            MessageBox.Show("Member has had too many late returns, Please go to Remove Member");
                        }
                    }
                    MessageBox.Show("Book Returned");
                }
                else
                {
                    MessageBox.Show("Please Click on a Book");
                    return;
                }
            }
        }
    }
}
