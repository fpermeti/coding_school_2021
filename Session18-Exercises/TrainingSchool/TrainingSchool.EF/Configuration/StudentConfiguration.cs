using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSchool.Model;

namespace TrainingSchool.EF.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            builder.ToTable("Student", "University");

            builder.HasKey(student =>  student.Id);

            builder.Property(student => student.Id).ValueGeneratedOnAdd();



            builder.Property(student => student.Name).HasMaxLength(50).IsRequired(true);

            builder.Property(student => student.Surname).HasMaxLength(100).IsRequired(true);

            builder.Property(student => student.BirthDate).IsRequired(true);

            builder.Property(student => student.Address).HasMaxLength(150).IsRequired(true);




        }
    }
}
