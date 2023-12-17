using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class Payment : System.Web.UI.Page
    {
        string emailid;
        string status;
        int Projectid;
        int TLId;
        protected void Page_Load(object sender, EventArgs e)
        {
             emailid = Request.QueryString["email"];

            clsprojectmanagement objlogin = new clsprojectmanagement(emailid);
            SqlDataReader dr;
            dr = objlogin.TeamLeader();
            while (dr.Read())
            {
                TLId = Convert.ToInt32(dr["TLId"].ToString());
                Projectid = Convert.ToInt32(dr["ProjectId"].ToString());
                status = dr["Status"].ToString();
            }
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            string amount = "500000";
            DateTime date = DateTime.Now;
            clsprojectmanagement objsave = new clsprojectmanagement(TLId,Projectid, amount,status, date);
            objsave.completepayment();
            Response.Write("<script LANGUAGE='JavaScript' >alert('Complete Payment')</script>");
        }
    }
}