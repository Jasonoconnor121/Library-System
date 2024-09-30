using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmReviewLoans : Form
    {
        LoanItem theItem = new LoanItem();
        public frmReviewLoans()
        {
            InitializeComponent();
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
            frmHomePage homePage = new frmHomePage();
            homePage.Show();
        }

        private void btnRetrieveLoan_Click(object sender, System.EventArgs e)
        {
            chrtGenrePop.Visible = true;
            if(theItem.getCountGenres("FAN") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Horror", theItem.getCountGenres("HOR"));
            }
            if (theItem.getCountGenres("FAC") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Fact", theItem.getCountGenres("FAC"));
            }
            if (theItem.getCountGenres("THR") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Thriller", theItem.getCountGenres("THR")); 
            }
            if (theItem.getCountGenres("PSY") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Psychological", theItem.getCountGenres("PSY"));
            }
            if (theItem.getCountGenres("SCI") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Science Fiction", theItem.getCountGenres("SCI"));
            }
            if (theItem.getCountGenres("HIS") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Historical", theItem.getCountGenres("HIS"));
            }
            if (theItem.getCountGenres("MYS") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Mystery", theItem.getCountGenres("MYS"));
            }
            if (theItem.getCountGenres("ABI") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Auto-Biography", theItem.getCountGenres("ABI"));
            }
            if (theItem.getCountGenres("COO") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Cooking", theItem.getCountGenres("COO"));
            }
            if (theItem.getCountGenres("FIC") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Fiction", theItem.getCountGenres("FIC"));
            }
            if (theItem.getCountGenres("ROM") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Romance", theItem.getCountGenres("ROM"));
            }
            if (theItem.getCountGenres("DYS") != 0)
            {
                chrtGenrePop.Series["Genres"].Points.AddXY("Dystopian", theItem.getCountGenres("DYS"));
            }

        }

       
    }
}
