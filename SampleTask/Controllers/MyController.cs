using SampleTask.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SampleTask.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Start(MyModel model)
        {
            using (var set= new New_DatabaseEntities3())
            {
                Employee_Detail db = new Employee_Detail();
                db.Employee_ID = model.EmployeeID;
                db.Employee_Name = model.EmployeeName;
                db.Role = model.Role;
                db.Experience = model.Experience;
                set.Employee_Detail.Add(db);
                set.SaveChanges();
            }
            return View();
        }
    }
}