using ClassroomDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_a_thon21.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            ClassroomDB db = new ClassroomDB();
            var gradeViewModel = new GradesViewModel();
            gradeViewModel.Student = db.Students.Where(x => x.Id == 2).FirstOrDefault();
            gradeViewModel.Grades = db.StudentGrades.Where(x => x.StudentId == gradeViewModel.Student.Id).ToList();
            return View(gradeViewModel);
        }
    }
}