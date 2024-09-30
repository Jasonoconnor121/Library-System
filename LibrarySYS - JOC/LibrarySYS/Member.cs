using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    class Member
    {
        private int MemberID;
        private string ForeName;
        private string SurName;
        private string HouseNo;
        private string Street;
        private string Town;
        private string County;
        private string Eircode;
        private string PhoneNo;
        private string Email;
        private string Status;
        private int FeeAmount;
        private int StrikeCount;


        public int getMemberID() {
            return this.MemberID; 
        }
        public string getForeName() {
            return this.ForeName; 
        }
        public string getSurName() {
            return this.SurName; 
        }
        public string getHouseNo()
        {
            return this.HouseNo;
        }
        public string getStreet() {
            return this.Street; 
        }
        public string getTown() {
            return this.Town; 
        }
        public string getCounty() {
            return this.County; 
        }
        public string getEircode() {
            return this.Eircode; 
        }
        public string getPhoneNo() {
            return this.PhoneNo; 
        }
        public string getEmail() {
            return this.Email; 
        }
        public string getStatus() {
            return this.Status; 
        }
        public int getFeeAmount() {
            return this.FeeAmount; 
        }
        public int getStrikeCount() {
            return this.StrikeCount; 
        }


        public int setMemberID(int MemberID) {
            return this.MemberID = MemberID; 
        }
        public void setForeName(string ForeName) {
            this.ForeName = ForeName;
        }
        public void setSurName(string SurName) {
            this.SurName = SurName;
        }
        public void setHouseNo(string HouseNo)
        {
            this.HouseNo = HouseNo; 
        }
        public void setStreet(string Street) {
            this.Street = Street;
        }
        public void setTown(string Town) { 
            this.Town = Town;
        }
        public void setCounty(string County) {
            this.County = County;
        }
        public void setEircode(string Eircode) {
            this.Eircode = Eircode;
        }
        public void setPhoneNo(string PhoneNo) {
            this.PhoneNo = PhoneNo;
        }
        public void setEmail(string Email) {
            this.Email = Email;
        }
        public void setStatus(string Status) {
            this.Status = Status;
        }
        public void setFeeAmount(int FeeAmount) {
            this.FeeAmount = FeeAmount;
        }
        public void setStrikeCount(int StrikeCount) {
            this.StrikeCount = StrikeCount;
        }


        public Member()
        {
            this.MemberID = 10000;
            this.ForeName = "";
            this.SurName = "";
            this.HouseNo = "0";
            this.Street = "";
            this.Town = "";
            this.County = "";
            this.Eircode = "";
            this.PhoneNo = "000000000";
            this.Email = "";
            this.Status = "A";
            this.FeeAmount = 0;
            this.StrikeCount = 0;

        }

        public Member(int memberID, string foreName, string surName, string houseNo, string street, string town, string county, 
            string eircode, string phoneNo, string email)
        {
            this.MemberID = memberID;
            this.ForeName = foreName;
            this.SurName = surName;
            this.HouseNo = houseNo;
            this.Street = street;
            this.Town = town;
            this.County = county;
            this.Eircode = eircode;
            this.PhoneNo = phoneNo;
            this.Email = email;
            this.Status = "A";
            this.FeeAmount = 0;
            this.StrikeCount = 0;
        }

        public static int getNextMemberID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(MemberID) FROM Members";

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

        public void addMember()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Members Values (" +
                this.MemberID + ",'" +
                this.ForeName + "','" + 
                this.SurName + "','" + 
                this.HouseNo + "','" +
                this.Street + "','" + 
                this.Town + "','" + 
                this.County + "','" + 
                this.Eircode + "','" + 
                this.PhoneNo + "','" + 
                this.Email + "','" + 
                this.Status + "'," + 
                this.FeeAmount + "," + 
                this.StrikeCount + ")";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateMember()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "ForeName = '" + this.ForeName + "'," +
                "SurName = '" + this.SurName + "'," +
                "HouseNo = " + this.HouseNo + "," +
                "Street = '" + this.Street + "'," +
                "Town = '" + this.Town + "'," +
                "County = '" + this.County + "', " +
                "Eircode = '" + this.Eircode + "', " +
                "PhoneNo = '" + this.PhoneNo + "', " +
                "Email = '" + this.Email + "' " +
                "WHERE MemberID = " + this.MemberID;


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getMember(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Members WHERE MemberID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                //set the instance variables with values from data reader
                setMemberID(dr.GetInt32(0));
                setForeName(dr.GetString(1));
                setSurName(dr.GetString(2));
                setHouseNo(dr.GetString(3));
                setStreet(dr.GetString(4));
                setTown(dr.GetString(5));
                setCounty(dr.GetString(6));
                setEircode(dr.GetString(7));
                setPhoneNo(dr.GetString(8));
                setEmail(dr.GetString(9));
                setStatus(dr.GetString(10));
                setFeeAmount(dr.GetInt32(11));
                setStrikeCount(dr.GetInt32(12));

            }
            else
            {

            }


            //close DB
            conn.Close();
        }

        public void deactivateMember()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Members SET " +
                "Status = 'D' WHERE MemberID = " + this.MemberID;


            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public Boolean getMemberToF(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Members WHERE MemberID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void updateFee(string param)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            if (param == "Add")
            {
                //Define the SQL query to be executed
                String sqlQuery = "UPDATE Members SET " +
                    "FeeAmount = FeeAmount + 5.00" +
                    ", StrikeCount = StrikeCount + 1" +
                    "WHERE MemberID = " + this.MemberID;


                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }
            else if (param == "Sub")
            {
                //Define the SQL query to be executed
                String sqlQuery = "UPDATE Members SET " +
                    "FeeAmount = 0" +
                    "WHERE MemberID = " + this.MemberID;


                //Execute the SQL query (OracleCommand)
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                //Close db connection
                conn.Close();
            }

        }
        
    }
}








