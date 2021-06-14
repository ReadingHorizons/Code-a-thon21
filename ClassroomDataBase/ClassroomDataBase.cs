using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Configuration;
using ClassroomDataBase.DataTables;

namespace ClassroomDataBase
{
    public class ClassroomDataBase: DbContext
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ClassroomDatabase"].ConnectionString;
        public ClassroomDataBase()
        {
            this.Database.Connection.ConnectionString = connectionString;
        }
        public virtual DbSet<Teacher> Teachers { get; set; } 
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<Assignment> Assignments { get; set; } 
        public virtual DbSet<Class> Classes { get; set; } 
        public virtual DbSet<StudentGrade> StudentGrades { get; set; } 
    }
}
