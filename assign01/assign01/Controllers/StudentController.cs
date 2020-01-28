using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using assign01.Models;


namespace assign01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult studentDetail()
        {
            Student student = new Student();
            student.name = Request.Form["name"];
            student.id = Request.Form["id"];
            student.age = Request.Form["age"];
            return View(student);
        }

    }
}