using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmViewLoan : Form
    {
        Loan theLoan = new Loan();
        LoanItem theItem = new LoanItem();  
        
        DataSet dsView = new DataSet(); 
        public frmViewLoan()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void returnToSearchCatalogueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmSearchCatalogue searchCatalogue = new frmSearchCatalogue();
            searchCatalogue.Show();
        }

        private void btnViewLoan_Click(object sender, System.EventArgs e)
        {
            if(txtConfirm.Text != string.Empty && txtConfirm.Text.Any(char.IsLetter) == false)
            {
                int memId = Int32.Parse(txtConfirm.Text);
                dsView = theItem.getAllLoanItems(memId);
                dgvLoanView.DataSource = dsView.Tables["Books"].DefaultView;
                dgvLoanView.Visible = true;
                
                
                
            }
        }

        private void frmViewLoan_Load(object sender, EventArgs e)
        {

        }
    }
}
