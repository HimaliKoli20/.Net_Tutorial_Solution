using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        Workspace2Entities1 dbObj = new Workspace2Entities1();
        // GET: Employee
        public ActionResult Employee(Employee tblObj)
        {
            if(tblObj !=null)
                return View(tblObj);
            else
                return View();
        }

       
        public ActionResult Add(Employee employee)
        {
           if(ModelState.IsValid)
           {
                Employee emp = new Employee();

                emp.EmpID = employee.EmpID;
                emp.FullName = employee.FullName;
                emp.EmailID = employee.EmailID;
                emp.OfficeLocation = employee.OfficeLocation;
                emp.Department = employee.Department;

                if(employee.EmpID == 0)
                {
                    dbObj.Employees.Add(emp);
                    dbObj.SaveChanges();
                }
                    
               
                                   
                    dbObj.Entry(emp).State = EntityState.Modified;
                    dbObj.SaveChanges();
                

            }

            ModelState.Clear();
            return View("Employee");
        }

        public ActionResult EmployeeList()
        {
            var list = dbObj.Employees.ToList();
            return View(list);
        }

        
        public ActionResult Delete(int id)
        {
            var del = dbObj.Employees.Where(x => x.EmpID.Equals(id)).FirstOrDefault();
            if(del != null)
            {
                dbObj.Employees.Remove(del);
               
            }
            dbObj.SaveChanges();

            var newlist = dbObj.Employees.ToList();
            return View("EmployeeList", newlist);
        }
    }
}