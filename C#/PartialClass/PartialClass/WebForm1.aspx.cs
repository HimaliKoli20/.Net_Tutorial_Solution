using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PartialClass
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer C1 = new Customer();
            C1.Firstname = "Vihaan ";
            C1.Lastname = " Sharma";
            string FullName1 = C1.GetFullname();
            Response.Write(" FullName =  " + FullName1 + "<br>");


            PartialCustomer C2 = new PartialCustomer();
            C2.Firstname = "Richa ";           
            C2.Lastname = " Desai";
            string FullName2 = C2.GetFullname();
            Response.Write(" FullName =  " + FullName2);
            
        }
    }
}