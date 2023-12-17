using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_management
{
    public partial class AllProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsprojectmanagement objA = new clsprojectmanagement();
            DataTable dtA = new DataTable();
            dtA = objA.GetAllProject();
            grdAllProject.DataSource = dtA;
            grdAllProject.DataBind();
        }
    }
}