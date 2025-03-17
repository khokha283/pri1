using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController1 : Controller
    {
        List<Student> students = new List<Student>()
        { new Student() { Id = 2, Name = "salem", Age = 22, Semester = "three" },
         new Student() { Id = 2, Name = "salem", Age = 22, Semester = "three" },
         new Student() { Id = 2, Name = "salem", Age = 22, Semester = "three" },
         new Student() { Id = 2, Name = "salem", Age = 22, Semester = "three" }};
        dept dep = new dept() { Id = 3, Name_dept = "IT" };

        public IActionResult Index()
        {
             Student d = new Student();
             d.Id = 1;
             d.Name = "salem";
             d.Age = 22;
             d.Semester = "three";
             ViewBag.dp = dep;
             ViewBag.st=d; ;  
             return View();
        }
        public IActionResult display()
        {
            
            return View(students);
        }
    }
}
