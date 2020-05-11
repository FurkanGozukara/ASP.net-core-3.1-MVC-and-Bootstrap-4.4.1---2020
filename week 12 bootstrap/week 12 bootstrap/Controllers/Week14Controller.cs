using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using week_12_bootstrap.Models;

namespace week_12_bootstrap.Controllers
{
    public class Week14Controller : Controller
    {
        private StudentContext context;

        public Week14Controller(IHost host)
        {
            var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            context = services.GetRequiredService<StudentContext>();
        }

        public IActionResult Index()
        {
            return View("Week14");
        }

        [HttpPost]
        public IActionResult async_createStudent([FromBody] Student asyncStudent)
        {
            System.Threading.Thread.Sleep(5000);
            context.Students.Add(asyncStudent);
            int irAffectedRows = context.SaveChanges();
            string message = $"{irAffectedRows} rows affected";
            return Json(message);
        }


        [HttpPost]
        public IActionResult createStudentRegularForm(string StudentName, string StudentAddress)
        {
            Student astudent = new Student();
            astudent.studentAddress = StudentAddress;
            astudent.studentName = StudentName;
            context.Students.Add(astudent);
            int irAffectedRows = context.SaveChanges();
            string message = $"{irAffectedRows} rows affected";
            return Json(message);
        }

        [HttpPost]
        public IActionResult displayStudents()
        {
            modelWeek14 myModel = new modelWeek14();
            List<Student> students = new List<Student>();
            myModel.lstStudents = context.Students.ToList();
            return View("Week14", myModel);
        }

        public JsonResult async_getStudent()
        {
            List<Student> students = new List<Student>();
            students = context.Students.ToList();
            return Json(students);
        }
    }
}