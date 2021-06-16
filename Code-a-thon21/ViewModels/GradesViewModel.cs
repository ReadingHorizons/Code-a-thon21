using ClassroomDataBase.DataTables;
using System.Collections.Generic;

namespace Code_a_thon21.ViewModels
{
    public class GradesViewModel
    {
        public Student Student { get; set; }
        public List<StudentGrade> Grades { get; set; }
        public List<Assignment> Assignments { get; set; }
        public Dictionary<string, List<StudentGrade>> SubjectGrades {get; set;}
        public List<SubjectWeights> SubjectWeight { get; set; }
    }
}

