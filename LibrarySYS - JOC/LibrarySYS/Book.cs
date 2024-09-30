using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    class Book
    {
        private int BookID;
        private string Title;
        private string Author;
        private string ReleaseDate;
        private string Genre;
        private string Status;

        public int getBookID()
        {
            return this.BookID;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public string getAuthor()
        {
            return this.Author;
        }

        public string getReleaseDate()
        {
            return this.ReleaseDate;
        }

        public string getGenre()
        {
            return this.Genre;
        }

        public string getStatus()
        {
            return this.Status;
        }

        public int setBookID(int BookID)
        {
            return this.BookID = BookID;
        }

        public string setTitle(string Title)
        {
            return this.Title = Title;
        }

        public string setAuthor(string Author)
        {
            return this.Author = Author;
        }

        public string setReleaseDate(string ReleaseDate)
        {
            return this.ReleaseDate = ReleaseDate;
        }

        public string setGenre(string Genre)
        {
            return this.Genre = Genre;
        }

        public string setStatus(string Status)
        {
            return this.Status = Status;
        }

        public Book()
        {
            this.BookID = 50001;
            this.Title = "BookGen";
            this.Author = "Genesis";
            this.ReleaseDate = "01-JAN-01";
            this.Genre = "";
            this.Status = "A";
        }

        public Book(int bookID, string title, string author, string releaseDate, string genre)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
            this.ReleaseDate = releaseDate;
            this.Genre = genre;
            this.Status = "A";
        }

        public static int getNextBookID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(BookID) FROM Books";

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

        public void addBook()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Books Values (" +
                this.BookID + ",'" +
                this.Title + "','" +
                this.Author + "','" +
                this.ReleaseDate + "','" +
                this.Genre + "','" +
                this.Status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getBook(string value1)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Books WHERE BookID = '" + value1 + "'" ;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setBookID(dr.GetInt32(0));
            setTitle(dr.GetString(1));
            setAuthor(dr.GetString(2));
            setReleaseDate(dr.GetString(3));
            setGenre(dr.GetString(4));
            setStatus(dr.GetString(5));
            //close DB
            conn.Close();
        }

        public DataSet getBookdgv(string value1)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Books WHERE BookID = '" + value1 + "'";

            //Execute the SQL query (OracleCommand)
            OracleDataAdapter da = new OracleDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            return ds;
        }

        public void updateStatusBook(string value1)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            if (value1 == "Available")
            {
                String sqlQuery = "UPDATE Books SET " +
                    "Status = 'U' WHERE BookID = " + this.BookID;


                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }

            else if (value1 == "Unavailable")
            {
                String sqlQuery = "UPDATE Books SET " +
                    "Status = 'A' WHERE BookID = " + this.BookID;


                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }
        }

        public DataSet getSearchResults(string value1,string value2)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed

            if(value1 == "GenreCode")
            {
                value2 = value2.ToUpper();
            }
            
                String sqlQuery = "SELECT * FROM Books WHERE " + value1 + " LIKE '%" + value2 + "%' AND Status = 'A'";

            OracleDataAdapter da = new OracleDataAdapter(sqlQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Books");

            return ds;
            
        }

    }  
}
