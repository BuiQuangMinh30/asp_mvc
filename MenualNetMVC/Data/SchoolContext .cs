using MenualNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MenualNetMVC.Data
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }
        public DbSet<Student> Students { get; set; }
    
    }
}