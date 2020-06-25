using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using LoginPage.Models;
using System.Web.Security;

namespace LoginPage.Controllers
{

    public class C_LoginController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        // GET: C_Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Home()
        {
            return View();
        }

         public ActionResult Error()
        {
            return View();
        }
        public void connectionstring()
        {
            con.ConnectionString = @"data source=DELL-PC\SQLSERVER;database=Practice9;integrated security=SSPI";
        }
        
        [HttpPost]
        public ActionResult Verify(M_Login details)
        {
            connectionstring();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from tblUsers where UserName= '" + details.UserName + "' and Password= '" + details.Password + "'";
            SqlDataReader sqlData = cmd.ExecuteReader();
            if(sqlData.Read())
            {
                FormsAuthentication.SetAuthCookie(details.UserName,false);
                Session["user"] = details.UserName;
                Session["Pass"] = details.Password;
                con.Close();
                return View("Home");

            }
            else
            {
                con.Close();
                return View("Error");
            }
            
        }
    }
}