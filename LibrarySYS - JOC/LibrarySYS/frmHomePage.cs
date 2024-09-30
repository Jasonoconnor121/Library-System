using System;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void mnuRegMem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterMember registerMember = new frmRegisterMember();
            registerMember.Show();
        }
        private void viewMemberDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewMember viewMember = new frmViewMember();
            viewMember.Show();
        }
        private void mnuUpdMem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateMember updateMember = new frmUpdateMember();
            updateMember.Show();
        }

        private void mnuPayFee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPayFee payFee = new frmPayFee();
            payFee.Show();
        }

        private void mnuRemMem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveMember remMember = new frmRemoveMember();
            remMember.Show();
        }

        private void mnuCatBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCatalogBook catalogBook = new frmCatalogBook();
            catalogBook.Show();

        }

        private void mnuSearchCat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearchCatalogue searchCatalogue = new frmSearchCatalogue();
            searchCatalogue.Show();
        }

        private void mnuViewLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewLoan recLoan = new frmViewLoan();
            recLoan.Show();
        }
        private void mnuRetBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnBook returnBook = new frmReturnBook();
            returnBook.Show();
        }

        private void mnuRevBookLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReviewLoans reviewLoans = new frmReviewLoans();
            reviewLoans.Show();
        }

        
    }
}
