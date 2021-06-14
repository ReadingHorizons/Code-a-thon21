using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomDataBase.DataTables
{
    class Student
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int ClassID { get; set; }
        public int Gender { get; set; }
    }
}
