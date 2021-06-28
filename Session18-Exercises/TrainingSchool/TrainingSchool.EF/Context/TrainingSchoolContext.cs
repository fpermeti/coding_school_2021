using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSchool.EF.Configuration;
using TrainingSchool.Model;

namespace TrainingSchool.EF.Context
{
    class TrainingSchoolContext : DbContext
    {


       
            protected TrainingSchoolContext() : base()
            {
            }

            public TrainingSchoolContext(DbContextOptions options) : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBTrainingSchool;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                base.OnConfiguring(optionsBuilder);
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new StudentConfiguration());
                modelBuilder.ApplyConfiguration(new CourseConfiguration());
                base.OnModelCreating(modelBuilder);
            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }
        }





    
}
