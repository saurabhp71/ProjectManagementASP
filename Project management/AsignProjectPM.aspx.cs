using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class AsignProjectPM : System.Web.UI.Page
    {
        string emailid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                caldate.Visible = false;
            }
            if (!IsPostBack)
            {
                emailid = Session["emaliid"].ToString();
                clsprojectmanagement obj = new clsprojectmanagement(emailid);
                DataTable dt = new DataTable();
                dt = obj.projectnamePM();
                drpProjectname.DataSource = dt;
                drpProjectname.DataTextField = "ProjectName";
                drpProjectname.DataValueField = "ProjectId";
                drpProjectname.DataBind();
                drpProjectname.Items.Insert(0, new ListItem("--Select Project--", "0"));
            }
            TeamLead();
        }
        public void TeamLead()
        {
            if (!IsPostBack)
            {
                string employeettype = "Team Lead";
                clsprojectmanagement objs = new clsprojectmanagement(employeettype);
                DataTable dts = new DataTable();
                dts = objs.TeamLead();
                drpTeamLead.DataSource = dts;
                drpTeamLead.DataTextField = "EmployeeName";
                drpTeamLead.DataValueField = "EmployeeId";
                drpTeamLead.DataBind();
                drpTeamLead.Items.Insert(0, new ListItem("--Select TeamLead--", "0"));
            }
        }
        protected void caldate_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = caldate.SelectedDate.ToString("dd/MM/yyyy");
            caldate.Visible = false;
        }

        protected void btnstartdate_Click1(object sender, ImageClickEventArgs e)
        {
            if (caldate.Visible)
            {
                caldate.Visible = false;
            }
            else
            {
                caldate.Visible = true;
            }
            caldate.Attributes.Add("style", "position:absolute");
        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnAsign_Click(object sender, EventArgs e)
        {
            int projectid = Convert.ToInt32(drpProjectname.SelectedValue);
            int Tmid = Convert.ToInt32(drpTeamLead.SelectedValue);
            string status = drpStatus.SelectedItem.Text;
            DateTime date = Convert.ToDateTime(txtDate.Text.ToString());

            clsprojectmanagement obj = new clsprojectmanagement(projectid, Tmid, status, date);
            obj.AsignProjectTL();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successfully')</script>");
            TeamLead();
        }
    }
}