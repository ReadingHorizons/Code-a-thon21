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
    public class ClassroomDB: DbContext
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ClassroomDatabase"].ConnectionString;
        public ClassroomDB()
        {
            this.Database.Connection.ConnectionString = connectionString;
        }
        public virtual DbSet<Teacher> Teachers { get; set; } 
        public virtual DbSet<Student> Students { get; set; } 
        public virtual DbSet<Assignment> Assignments { get; set; } 
        public virtual DbSet<Class> Classes { get; set; } 
        public virtual DbSet<StudentGrade> StudentGrades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ClassroomDB>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
