using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using CRUD_Operation.Models;

namespace CRUD_Operation.Controllers
{
    public class StudentController : Controller
    {
        string cs = @"data source=DELL-PC\SQLSERVER; database=Workspace2; integrated security=SSPI";
        // GET: Student
        public ActionResult Index()
        {
            DataTable student = new DataTable();
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Student", con);
                sqlData.Fill(student);
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View(new StudentModel());
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentModel studentModel)
        {
            try
            {
                // TODO: Add insert logic here
                using(SqlConnection sqlcon = new SqlConnection(cs))
                {
                    sqlcon.Open();
                    string createquery = "Insert into Student Values(@SName,@MobNo,@Marks)";
                    SqlCommand cmd = new SqlCommand(createquery,sqlcon);
                    cmd.Parameters.AddWithValue("@SName", studentModel.SName);
                    cmd.Parameters.AddWithValue("@MobNo", studentModel.MobNo);
                    cmd.Parameters.AddWithValue("@Marks", studentModel.Marks);
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            StudentModel studentModel = new StudentModel();
            DataTable dataTable = new DataTable();
            using(SqlConnection sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();
                string editquery = "Select * from Student where ID = @ID";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(editquery, sqlcon);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ID", id);
                sqlDataAdapter.Fill(dataTable);
            }
            if(dataTable.Rows.Count == 1)
            {
                studentModel.ID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                studentModel.SName = dataTable.Rows[0][1].ToString();
                studentModel.MobNo = Convert.ToInt64(dataTable.Rows[0][2].ToString());
                studentModel.Marks = Convert.ToInt32(dataTable.Rows[0][3].ToString());
                return View(studentModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
           
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentModel studentModel)
        {
            try
            {
                // TODO: Add update logic here
                using (SqlConnection sqlcon = new SqlConnection(cs))
                {
                    sqlcon.Open();
                    string editquery = "Update Student SET SName = @SName , MobNo =@MobNo , Marks = @Marks where ID = @ID";
                    SqlCommand cmd = new SqlCommand(editquery, sqlcon);
                    cmd.Parameters.AddWithValue("@ID", studentModel.ID);
                    cmd.Parameters.AddWithValue("@SName", studentModel.SName);
                    cmd.Parameters.AddWithValue("@MobNo", studentModel.MobNo);
                    cmd.Parameters.AddWithValue("@Marks", studentModel.Marks);
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(); 
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            using (SqlConnection sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();
                string deletequery = "Delete from Student where ID = @ID";
                SqlCommand cmd = new SqlCommand(deletequery, sqlcon);
                cmd.Parameters.AddWithValue("@ID",id);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

       
       
    }
}
