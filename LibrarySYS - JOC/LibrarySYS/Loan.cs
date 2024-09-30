using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    internal class Loan
    {
        private int LoanID;
        private int MemberID;
        private string DueDate;
        private string Status;


        public int getLoanID()
        {
            return this.LoanID;
        }

        public int getMemberID()
        {
            return this.MemberID;
        }

        public string getDueDate()
        {
            return this.DueDate;
        }
        public string getStatus()
        {
            return this.Status;
        }
        public int setLoanID(int LoanID)
        {
            return this.LoanID = LoanID;
        }

        public int setMemberID(int MemberID)
        {
            return this.MemberID = MemberID;
        }

        public string setDueDate(string DueDate)
        {
            return this.DueDate = DueDate;
        }
        public string setStatus(string Status)
        {
            return this.Status = Status;
        }

        public Loan()
        {
            this.LoanID = 11001;
            this.MemberID = 10001;
            this.DueDate = DateTime.Now.AddDays(14).ToString("dd-MMM-yy");
            this.Status = "O";
        }

        public Loan(int LoanID, int MemberID, string DueDate)
        {
            this.LoanID = LoanID;
            this.MemberID = MemberID;
            this.DueDate = DueDate;
            this.Status = "O";
        }

        public static int getNextLoanID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(LoanID) FROM Loans";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 10001;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public void createLoan()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Loans Values (" +
                this.LoanID + "," +
                this.MemberID + ",'" +
                this.DueDate + "','" +
                this.Status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getLoan(int LoanID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Loans WHERE LoanID = " + LoanID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setLoanID(dr.GetInt32(0));
            setMemberID(dr.GetInt32(1));
            setDueDate(dr.GetString(2));
            //close DB
            conn.Close();
        }
        public void getLoanByMem(int MemberID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT LoanID FROM Loans WHERE MemberID = " + MemberID + " AND Status = 'O'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                //set the instance variables with values from data reader
                setLoanID(dr.GetInt32(0));
                //close DB
                conn.Close();
            }
            else
            {
                MessageBox.Show("No loans found, Try again");
                return;
            }
        }

        public Boolean checkLoan(string id)
        {

            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT bookid FROM LoanItems WHERE Loanid = " + id + "AND Status = 'L'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                return false;
            }

            else { return true; }
        }
        public void updateStatusLoan(int value1)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed

            String sqlQuery = "UPDATE Loans SET " +
                "Status = 'C' WHERE Loanid = " + value1;


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();

        }
        public DateTime getDueDate(string LoanID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT duedate FROM Loans WHERE LoanID = " + LoanID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            string date = dr.GetString(0);
            DateTime dueDate = DateTime.ParseExact(date, "MM-dd-yy", null);
            //close DB
            conn.Close();
            return dueDate;
        }
    }
}
