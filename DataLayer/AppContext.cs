using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SubjectModel> SubjectModel { get; set; }
        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<ClassModel> ClassModel { get; set; }
    }
}
