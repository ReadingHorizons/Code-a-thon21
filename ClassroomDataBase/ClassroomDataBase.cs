using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassroomDataBase
{
    public class ClassroomDataBase: DbContext
    {
        public virtual DbSet<Teacher> Teachers { get; set; } 
    }
}
