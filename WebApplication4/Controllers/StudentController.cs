using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;


namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>() {
                            new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                            new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                            new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                            new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                            new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                            new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                            new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
                        };
        //GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }

        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();

            return View(std); 
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            //Write code to update the Student 
            var name = s.StudentName;
            var age = s.Age;
            
            return RedirectToAction("Index"); 
        }

        public ActionResult Details(Student s)
        {
            return RedirectToAction("Index"); 
        }
        //[NonAction]
        //public string Index()
        //{
        //    return "Entering in the Student Controller Index Method"; 
        //}
    }
}