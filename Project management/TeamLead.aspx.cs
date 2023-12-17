using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class TeamLead1 : System.Web.UI.Page
    {
        string EmailId = null;
        int Projectid = 0;
        string status = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            EmailId = Session["emaliid"].ToString();

            clsprojectmanagement objlogin = new clsprojectmanagement(EmailId);
            SqlDataReader dr;
            dr = objlogin.TeamLeader();
            while (dr.Read())
            {
                lblPN.Text = dr["ProjectName"].ToString();
                lblPN1.Text = dr["ProjectName"].ToString();
                lblPN2.Text = dr["ProjectName"].ToString();
                lblPN3.Text = dr["ProjectName"].ToString();
                status = dr["Status"].ToString();
                Projectid = Convert.ToInt32(dr["ProjectId"].ToString());
                lblTL.Text = dr["EmployeeName"].ToString();
            }


            
            if (status == "Pending")
            {
                this.btnCompleted1.Enabled = true;
                this.btnCompleted2.Enabled = false;
                this.btnCompleted3.Enabled = false;
            }
            if (status == "Itration1")
            {
                this.btnCompleted1.Enabled = false;
                this.btnCompleted3.Enabled = false;
                this.btnCompleted2.Enabled = true;
            }
            if (status == "Itration2")
            {
                this.btnCompleted1.Enabled = false;
                this.btnCompleted2.Enabled = false;
                this.btnCompleted3.Enabled = true;
            }
            if (status == "Completed")
            {
                this.btnCompleted1.Enabled = false;
                this.btnCompleted2.Enabled = false;
                this.btnCompleted3.Enabled = false;
            }

        }
        protected void btnCompleted1_Click(object sender, EventArgs e)
        {
            string Status = "Itration1";
            DateTime date = DateTime.Now;

            if (status == "Itration1")
            {
                this.btnCompleted2.Enabled = true;
            }
            else
            {
                clsprojectmanagement objstatus = new clsprojectmanagement(Projectid, Status, date);
                objstatus.CompleteStatus();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Itration1 is Completed')</script>");
                this.btnCompleted2.Enabled = true;
                this.btnCompleted3.Enabled = false;
                this.btnCompleted1.Enabled = false;
            }
        }

        protected void btnCompleted2_Click(object sender, EventArgs e)
        {
            string Status = "Itration2";
            DateTime date = DateTime.Now;

            if (status == "Itration2")
            {
                this.btnCompleted3.Enabled = true;
            }
            else
            {
                clsprojectmanagement objstatus = new clsprojectmanagement(Projectid, Status, date);
                objstatus.CompleteStatus();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Itration2 is Completed')</script>");
                this.btnCompleted3.Enabled = true;
                this.btnCompleted2.Enabled = false;
            }
        }
        protected void btnCompleted3_Click(object sender, EventArgs e)
        {
            string Status = "Completed";
            DateTime date = DateTime.Now;

            if (status == "Completed")
            {
                this.btnCompleted1.Enabled = false;
            }
            else
            {
                clsprojectmanagement objstatus = new clsprojectmanagement(Projectid, Status, date);
                objstatus.CompleteStatus();
                Response.Write("<script LANGUAGE='JavaScript' >alert('Itration3 is Completed')</script>");
                this.btnCompleted3.Enabled = false;
                this.btnCompleted2.Enabled = false;
            }
        }
    }
}