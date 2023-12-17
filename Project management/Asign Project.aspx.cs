using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class Asign_Project1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

            if (!IsPostBack)
            {
                clsprojectmanagement obj = new clsprojectmanagement();
                DataTable dt = new DataTable();
                dt = obj.projectname();
                drpProjectname.DataSource = dt;
                drpProjectname.DataTextField = "ProjectName";
                drpProjectname.DataValueField = "ProjectId";
                drpProjectname.DataBind();
                drpProjectname.Items.Insert(0, new ListItem("--Select Project--", "0"));
            }
            if (!IsPostBack)
            {
                string employeettype = "Project Manager";
                clsprojectmanagement objs = new clsprojectmanagement(employeettype);
                DataTable dts = new DataTable();
                dts = objs.projectmanager();
                drpprojectmanager.DataSource = dts;
                drpprojectmanager.DataTextField = "EmployeeName";
                drpprojectmanager.DataValueField = "EmployeeId";
                drpprojectmanager.DataBind();
                drpprojectmanager.Items.Insert(0, new ListItem("--Select ProjectManager--", "0"));
            }
            
        }

        protected void btnstartdate_Click1(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void caldate_SelectionChanged(object sender, EventArgs e)
        {
      
        }

        protected void btnAsign_Click(object sender, EventArgs e)
        {
            int projectid = Convert.ToInt32(drpProjectname.SelectedValue);
            int Pmid = Convert.ToInt32(drpprojectmanager.SelectedValue);
            string status = "Null";
            clsprojectmanagement obj = new clsprojectmanagement(projectid, Pmid, status);
            obj.AsignProjectPM();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successfully')</script>");
        }
    }
}