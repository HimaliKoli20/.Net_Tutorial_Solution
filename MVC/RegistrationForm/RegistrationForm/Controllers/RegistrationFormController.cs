using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
    public class RegistrationFormController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        // GET: RegistrationForm
        public ActionResult RegistrationForm()
        {
            return View();
        }
        public void connectionstring()
        {
            con.ConnectionString = @"data source=DELL-PC\SQLSERVER; database=RegistrationDetails; integrated security=SSPI";
        }

        [HttpPost]
        public ActionResult Verify(RegistrationFormDetails details)
        {
            connectionstring();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into tblCandidateDetails values ('"+details.FirstName+"','"+details.LastName+"','"+details.PhoneNumber+ "','"+details.Email+ "','"+details.DOB+"','"+details.Gender+ "','"+details.Qualification+ "','"+details.Branch+ "','"+details.YearOfPassing+ "','"+details.CurrentEmploymentStatus+ "','"+details.TotalWorkExperience+ "','"+details.InterestedJobProfiles+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            return View("Verify");
            
        }
    }
}