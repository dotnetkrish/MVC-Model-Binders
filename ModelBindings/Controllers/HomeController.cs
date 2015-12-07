using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindings.Models;

namespace ModelBindings.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var employee = new Employee();
            return View(employee);
        }
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomHome))] Employee employee)
        {
            return Content("Employee Name :"+employee.Name +"Employee Age :"+ employee.Age);
        }
	}
}