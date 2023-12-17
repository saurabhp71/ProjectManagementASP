using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                cascadindropdown();
            }
        }
        protected void cascadindropdown()
        {
            clsprojectmanagement obj = new clsprojectmanagement();
            DataTable dt = new DataTable();
            dt = obj.Country();
            drpCountry.DataSource = dt;
            drpCountry.DataTextField = "CountryName";
            drpCountry.DataValueField = "CountryId";
            drpCountry.DataBind();
            drpCountry.Items.Insert(0, new ListItem("--Select Country--", "0"));
        }

        protected void drpCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            int countryId = Convert.ToInt32(drpCountry.SelectedValue);
            clsprojectmanagement obj = new clsprojectmanagement(countryId);
            DataTable dt = new DataTable();
            dt = obj.State();
            drpState.DataSource = dt;
            drpState.DataBind();
            drpState.DataTextField = "StateName";
            drpState.DataValueField = "StateId";
            drpState.DataBind();
            drpState.Items.Insert(0, new ListItem("--Select State--", "0"));
        }

        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateId = Convert.ToInt32(drpState.SelectedValue);
            clsprojectmanagement obj = new clsprojectmanagement(StateId);
            DataTable dt = new DataTable();
            dt = obj.City();
            drpCity.DataSource = dt;
            drpCity.DataBind();
            drpCity.DataTextField = "CityName";
            drpCity.DataValueField = "CityId";
            drpCity.DataBind();
            drpCity.Items.Insert(0, new ListItem("--Select City--", "0"));
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string employeetype = drpType.SelectedItem.Text;
            string name = txtName.Text;
            string emailid = txtEmail.Text;
            Int64 phone = Convert.ToInt64(txtPhone.Text);
            int cityid = Convert.ToInt32(drpCity.SelectedValue);
            string Gender = "";
            string password = txtPassword.Text;
            if (rdbtnMale.Checked)
            {
                Gender = rdbtnMale.Text;
            }
            if (rdbtnFemale.Checked)
            {
                Gender = rdbtnFemale.Text;
            }

            clsprojectmanagement obj = new clsprojectmanagement(employeetype, name, emailid, phone, Gender, @cityid, password);
            obj.saveEmployee();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Save Successfully')</script>");
        }

        protected void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        protected void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
 
        }
    }
}