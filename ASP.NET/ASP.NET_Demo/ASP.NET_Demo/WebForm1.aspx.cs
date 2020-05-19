using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string companyname = Request["CompanyName"];
                string contactname = Request["ContactName"];
                Response.Write("You entered: <br/>");
                Response.Write("Company Name: " + @companyname + "<br/>");
                Response.Write("Contact Name: " + @contactname);

            }

        }
  
    }
}
