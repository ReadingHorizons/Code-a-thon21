using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomDataBase.DataTables
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int TeacherId { get; set; }
        public int GradeLevel { get; set; }
        public int RoomNumber { get; set; }
        public bool IsLunchA { get; set; }
    }
}
