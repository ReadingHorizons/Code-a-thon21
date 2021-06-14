using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomDataBase.DataTables
{
    public class Assignment
    {
        public int Id { get; set; }
        public string AssignmentName { get; set; }
        public int ClassId { get; set; }
        public DateTime DueDate { get; set; }
        public int Score { get; set; }
        public float AssignmentWeight { get; set; }
    }
}
