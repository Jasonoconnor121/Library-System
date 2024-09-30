using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    internal class LoanItem
    {
        private int LoanID;
        private int BookID;
        private string ReturnDate;
        private string GenreCode;
        private string Status;


        public int getLoanID()
        {
            return this.LoanID;
        }

        public int getBookID()
        {
            return this.BookID;
        }

        public string getReturnDate()
        {
            return this.ReturnDate;
        }
        public string getGenreCode()
        {
            return this.GenreCode;
        }
        public string getStatus()
        {
            return this.Status;
        }

        public int setLoanID(int LoanID)
        {
            return this.LoanID = LoanID;
        }

        public int setBookID(int BookID)
        {
            return this.BookID = BookID;
        }

        public string setReturnDate(string ReturnDate)
        {
            return this.ReturnDate = ReturnDate;
        }
        public string setGenreCode(string ReturnDate)
        {
            return this.ReturnDate = ReturnDate;
        }
        public string setStatus(string Status)
        {
            return this.Status = Status;
        }

        public LoanItem()
        {
            this.LoanID = 10001;
            this.BookID = 10001;
            this.GenreCode = "OBV";
            this.ReturnDate= "00-00-0000";
            this.Status = "L";
        }

        public LoanItem(int LoanID, int BookID, string GenreCode)
        {
            this.LoanID = LoanID;
            this.BookID = BookID;
            this.GenreCode = GenreCode;
            this.Status = "L";
        }

        public void createLoanItem()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO LoanItems (LoanID, BookID, GenreCode) Values (" +
                this.LoanID + "," +
                this.BookID + ",'"+
                this.GenreCode + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public DataSet getAllLoanItems(int value1)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed

            String sqlQuery = "select Loans.loanid, books.bookid, books.title, books.author, loans.duedate " +
                "from books " +
                "inner join Loanitems " +
                "on books.bookid = Loanitems.bookid" +
                " inner join loans" +
                " on loanitems.loanid = loans.loanid" +
                " where loans.memberid = " + value1 + " AND loans.Status = 'O' AND loanItems.Status = 'L'";

            OracleDataAdapter da = new OracleDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            return ds;


        }
        public void getLoanItem(int Id, int Id2)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM LoanItems WHERE loanid = " + Id + "AND bookid = " + Id2;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //set the instance variables with values from data reader
                setLoanID(dr.GetInt32(0));
                setBookID(dr.GetInt32(1));
                setGenreCode(dr.GetString(2));
                setStatus(dr.GetString(4));
            }
            //close DB
            conn.Close();
        }

        public void updateStatusLoanItem(string value1)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            
                String sqlQuery = "UPDATE LoanItems SET " +
                    "Status = 'R' WHERE BookID = " + this.BookID;


                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
        }
        public void updateDate()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed

            String sqlQuery = "UPDATE LoanItems SET " +
                "returndate = '" + this.ReturnDate +
                "' WHERE bookid = " + this.BookID;


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();

        }
        public int getCountGenres(string Genre)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed

            String sqlQuery = "SELECT COUNT(*) FROM LoanItems WHERE GenreCode = '" + Genre + "'"; 


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int result = dr.GetInt32(0);

            //Close db connection
            conn.Close();

            return result;
        }
    }
}
