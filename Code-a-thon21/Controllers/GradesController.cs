using ClassroomDataBase;
using ClassroomDataBase.DataTables;
using Code_a_thon21.ViewModels;
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
            var assignmentIds = gradeViewModel.Grades.Select(x => x.AssignmentId).ToList();
            gradeViewModel.Assignments = db.Assignments.Where(x => assignmentIds.Contains(x.Id)).ToList();
            Dictionary<string, List<StudentGrade>> organizedSubjects = new Dictionary<string, List<StudentGrade>>();
            foreach(var asmr in assignmentIds)
            {
                var subjectName = gradeViewModel.Assignments.Where(x => x.Id == asmr).FirstOrDefault().Subject;
                var studentSubjectGrades = gradeViewModel.Grades.Where(x => x.AssignmentId == asmr).ToList();
                if (!organizedSubjects.ContainsKey(subjectName))
                {
                    organizedSubjects.Add(subjectName, studentSubjectGrades);
                }
            }
            gradeViewModel.SubjectWeight = db.SubjectWeights.ToList();
            gradeViewModel.SubjectGrades = organizedSubjects;
            return View(gradeViewModel);
        }
    }
}