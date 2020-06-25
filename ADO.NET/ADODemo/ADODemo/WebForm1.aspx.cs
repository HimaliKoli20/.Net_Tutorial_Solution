using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ADODemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "Select * from tblPerson";
            string con = @"data source = DELL-PC\SQLSERVER ; database = Practice ; integrated security = SSPI";
            SqlConnection sqlcon = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            sqlcon.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            sqlcon.Close();
        }
    }
}