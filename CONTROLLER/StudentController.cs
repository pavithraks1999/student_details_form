using Microsoft.AspNetCore.Mvc;
using WebApplication13.Data;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        // GET: Student/Details - Display the form
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        // POST: Student/Details - Handle form submission
        [HttpPost]
        public IActionResult Details(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                ViewBag.Message = "Student details saved successfully!";
            }
            return View(student);
        }

        // GET: Student/List - Display all students
        public IActionResult List()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}

