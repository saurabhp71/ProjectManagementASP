using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class Project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                calstartdate.Visible = false;
            }
            if (!IsPostBack)
            {
                calenddate.Visible = false;
            }
        }

        protected void caldate_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        protected void calenddate_SelectionChanged(object sender, EventArgs e)
        {
            txtenddate.Text = calenddate.SelectedDate.ToString("dd/MM/yyyy");
            calenddate.Visible = false;
        }

        protected void calstartdate_SelectionChanged(object sender, EventArgs e)
        {
            txtstartdate.Text = calstartdate.SelectedDate.ToString("dd/MM/yyyy");
            calstartdate.Visible = false;
        }

        protected void btnstartdate_Click1(object sender, ImageClickEventArgs e)
        {
            if (calstartdate.Visible)
            {
                calstartdate.Visible = false;
            }
            else
            {
                calstartdate.Visible = true;
            }
            calstartdate.Attributes.Add("style", "position:absolute");
        }

        protected void btnenddate_Click1(object sender, ImageClickEventArgs e)
        {
            if (calenddate.Visible)
            {
                calenddate.Visible = false;
            }
            else
            {
                calenddate.Visible = true;
            }
            calenddate.Attributes.Add("style", "position:absolute");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string projecttype = drpprojecttype.Text;
            string projectname = txtprojectname.Text;
            DateTime startdate = Convert.ToDateTime(txtstartdate.Text.ToString());
            DateTime enddate = Convert.ToDateTime(txtenddate.Text.ToString());

            clsprojectmanagement obj = new clsprojectmanagement(projecttype, projectname, startdate, enddate);
            obj.saveProject();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successfully')</script>");
           
        }
    }
}