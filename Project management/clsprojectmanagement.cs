using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project_management
{
    public class clsprojectmanagement
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RU5490M;Initial Catalog=ProjectManagement;Integrated Security=True");

        public int EmployeeID { get; set; }
        public int PMID { get; set; }
        public int TLID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeType { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public Int64 PhoneNo { get; set; }
        public string Gender { get; set; }
        public int CityId { get; set; }
        public int CountryID { get; set; }
        public int StateID { get; set; }
        public string CountryName { get; set; }       
        public string CityName { get; set; }
        public string StateName { get; set; }
        public int ProjectID { get; set; }
        public string ProjectType { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string Amount { get; set; }
        public DateTime Date { get; set; }


        public clsprojectmanagement()
        {

        }

        public DataTable Country()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Country");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(int countryid)
        {
            CountryID = countryid;
        }
        public DataTable State()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "State");
            cmd.Parameters.AddWithValue("@countryid", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable City()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "City");
            cmd.Parameters.AddWithValue("@stateid", CountryID);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(string employeeType,string employeeName,  string emailID,Int64 phoneNo,string gender,int cityId, string password)
        {
            EmployeeName = employeeName;
            EmployeeType = employeeType;
            EmailID = emailID;
            Password = password;
            PhoneNo = phoneNo;
            Gender = gender;
            CityId = cityId;
        }
        public void saveEmployee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "RegisterEmployee");
            cmd.Parameters.AddWithValue("@employeetype", EmployeeType);
            cmd.Parameters.AddWithValue("@employeename", EmployeeName);
            cmd.Parameters.AddWithValue("@emailid", EmailID);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@phone", PhoneNo);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@cityid", CityId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsprojectmanagement(string projecttype, string projectName, DateTime startDate, DateTime endDate)
        {
            ProjectType = projecttype;
            ProjectName = projectName;
            StartDate = startDate;
            EndDate = endDate;
        }
        public void saveProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "RegisterProjrct");
            cmd.Parameters.AddWithValue("@projecttype", ProjectType);
            cmd.Parameters.AddWithValue("@projectname", ProjectName);
            cmd.Parameters.AddWithValue("@startdate", StartDate);
            cmd.Parameters.AddWithValue("@enddate", EndDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsprojectmanagement(string emailID, string password)
        {
            EmailID = emailID;
            Password = password;
        }
        public SqlDataReader EmployeeLogin()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "Login");
            cmd.Parameters.AddWithValue("@emailid", EmailID);
            cmd.Parameters.AddWithValue("@password", Password);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public DataTable projectname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ProjectNameA");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(string employeeType)
        {
            EmployeeType = employeeType;
        }
        public DataTable projectmanager()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ProjectManager");
            cmd.Parameters.AddWithValue("@employeetype", EmployeeType);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(int projectid,int pmid, string status/*, DateTime date*/)
        {
            ProjectID = projectid;
            PMID = pmid;
            Status = status;
            //Date = date;
        }
        public void AsignProjectPM()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AsignProjectPM");
            cmd.Parameters.AddWithValue("@projectid", ProjectID);
            cmd.Parameters.AddWithValue("@PMid", PMID);
            cmd.Parameters.AddWithValue("@status", Status);
           // cmd.Parameters.AddWithValue("@date", Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable GetAllProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "GetAllProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable projectnamePM()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "ProjectNamePM");
            cmd.Parameters.AddWithValue("@emailid", EmployeeType);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public DataTable TeamLead()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TeamLead");
            cmd.Parameters.AddWithValue("@employeetype", EmployeeType);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(int projectid, int tmid, string status, DateTime date)
        {
            ProjectID = projectid;
            TLID = tmid;
            Status = status;
            Date = date;
        }
        public void AsignProjectTL()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "AsignProjectTL");
            cmd.Parameters.AddWithValue("@projectid", ProjectID);
            cmd.Parameters.AddWithValue("@TLid", TLID);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsprojectmanagement(int projectid, string status, DateTime date)
        {
            ProjectID = projectid;
            Status = status;
            Date = date;
        }
        public void CompleteStatus()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "CompleteStatus");
            cmd.Parameters.AddWithValue("@projectid", ProjectID);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public SqlDataReader TeamLeader()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "TeamLeader");
            cmd.Parameters.AddWithValue("@emailid", EmployeeType);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
            con.Close();
        }
        public DataTable CompleteAllProject()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "grdCompleteProject");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
            con.Close();
        }
        public clsprojectmanagement(int tlid,int projectid,string amount,string status,DateTime date)
        {
            TLID = tlid;
            ProjectID = projectid;
            Amount = amount;
            Status = status;
            Date = date;
        }
        public void completepayment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SPPM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@flag", "CompletePayment");
            cmd.Parameters.AddWithValue("@TLid", TLID);
            cmd.Parameters.AddWithValue("@projectid", ProjectID);
            cmd.Parameters.AddWithValue("@amount", Amount);
            cmd.Parameters.AddWithValue("@amountstatus", Status);
            cmd.Parameters.AddWithValue("@amountdate", Date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}