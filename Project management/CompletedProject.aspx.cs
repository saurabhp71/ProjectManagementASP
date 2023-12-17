using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class CompletedProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                clsprojectmanagement objA = new clsprojectmanagement();
                DataTable dtA = new DataTable();
                dtA = objA.CompleteAllProject();
                grdCompleteProject.DataSource = dtA;
                grdCompleteProject.DataBind();
            }
        }
        protected void grdCompleteProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ProjectName = grdCompleteProject.SelectedRow.Cells[0].Text;
            string TeamLead = grdCompleteProject.SelectedRow.Cells[1].Text;
            string ProjectManager = grdCompleteProject.SelectedRow.Cells[2].Text;
            string Email = grdCompleteProject.SelectedRow.Cells[3].Text;
            string Phone =  grdCompleteProject.SelectedRow.Cells[4].Text;
            string Date = grdCompleteProject.SelectedRow.Cells[5].Text;
            string Amount = "500000";

            Response.Redirect("Payment.aspx?Pname=" + ProjectName + "&TLname=" + TeamLead + "&PMname=" + ProjectManager + "&email=" + Email + "&phone=" + Phone + "&date=" + Date + "&Amount=" + Amount+"");
        }
    }
}