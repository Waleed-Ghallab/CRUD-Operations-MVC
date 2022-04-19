using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        IStudent moc;
        public StudentController(IStudent _moc)
        {
            this.moc = _moc;
        }
        public IActionResult work()
        {
            return Content(moc.GetHashCode().ToString());
        }
        
        public IActionResult Index()
        {
            List<Student> students = moc.getAllStudents();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            if (ModelState.IsValid) //server side validation 
            {
                moc.addStudent(std);
                return RedirectToAction("Index");
                // return Content("student created");
            }
            else
            {
                return View(std);
            }


        }
        public IActionResult details(int id)
        {
            Student obj=moc.findStudent(id);
            
            return View(obj);
        }
        public IActionResult Edit(int id)
        {
            Student obj = moc.findStudent(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return View(obj);
            }
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {
            moc.editStudent(std);
            return RedirectToAction("index");
        }
        public IActionResult delete(int id)
        {
            moc.deleteStudent(id);
            return RedirectToAction("Index");
        }
        public IActionResult chkUserName(string userName)
        {
            List<Student> students = moc.getAllStudents();
            Student std=students.FirstOrDefault(i=>i.userName==userName);
            if(std != null)
            {
                return Json("false");
            }
            else
            {
                return Json("true");
            }

        }
    }

}
