using Code_a_thon21.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Code_a_thon21.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCalendarData()
        {
            // Initialization.  
            JsonResult result = new JsonResult();

            try
            {
                // Loading.  
                List<AssignmentDateViewModel> data = this.LoadData();

                // Processing.  
                result = this.Json(data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                // Info  
                Console.Write(ex);
            }

            // Return info.  
            return result;
        }

        private List<AssignmentDateViewModel> LoadData()
        {
            // Initialization.  
            List<AssignmentDateViewModel> lst = new List<AssignmentDateViewModel>();

            try
            {
                // Initialization.  
                var Db = new ClassroomDataBase.ClassroomDB();
                var StudentGrades = Db.StudentGrades.Where(x => x.StudentId == 3).ToList();
                var ClassId = Db.Students.Where(x => x.Id == 3).Select(x => x.ClassID).FirstOrDefault();
                var Assignments = Db.Assignments.Where(x => x.ClassId == ClassId).ToList();

                foreach (var Assignment in Assignments)
                {
                    var Temp = new AssignmentDateViewModel();
                    Temp.AssignmentName = Assignment.AssignmentName;
                    Temp.AssignmentDate = Assignment.DueDate;
                    Temp.IsSubmitted = StudentGrades.Where(x => x.AssignmentId == Assignment.Id).Any();
                    lst.Add(Temp);
                }

            }

            catch (Exception ex)
            {
                // info.  
                Console.Write(ex);
            }

            // info.  
            return lst;
        }
    }
}