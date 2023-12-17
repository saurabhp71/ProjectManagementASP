using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           string Position = null;         
            string EmployeeName = null;          

            string EmailID = txtusername.Text;
            string password = txtpassword.Text;
            clsprojectmanagement objlogin = new clsprojectmanagement(EmailID, password);
            SqlDataReader dr;
            dr = objlogin.EmployeeLogin();
            while (dr.Read())
            {             
                Position = dr["EmployeeType"].ToString();          
                EmployeeName = dr["EmployeeName"].ToString();
            }
            if (dr.HasRows && Position == "Admin")
            {
                Response.Redirect("Admin.aspx");
            }
            else if (dr.HasRows && Position == "Project Manager")
            {
                Session["emaliid"] = EmailID;
                Response.Redirect("ProjectManager.aspx");
            }
            else if (dr.HasRows && Position == "Team Lead")
            {
                Session["emaliid"] = EmailID;
                Response.Redirect("TeamLead.aspx");
            }
        }
    }
}