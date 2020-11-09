using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartialviewEx.Models;

namespace PartialviewEx.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        IList<EmployeeDetails> ObjEmp;
        public ActionResult  Empcontroller()
        {

            return View();
        }
        public ActionResult Empdetails()
        {
            using (EmployeeModelContainer db=new EmployeeModelContainer())
            {
                var obj = db.EmployeeDetails.OrderByDescending(a => a.Dept_id).ToList();
                return PartialView("_View", obj);
            }
            
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}