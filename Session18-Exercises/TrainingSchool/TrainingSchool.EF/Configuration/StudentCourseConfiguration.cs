using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSchool.Model;

namespace TrainingSchool.EF.Configuration {
  public  class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse> {
        public void Configure(EntityTypeBuilder<StudentCourse> builder) {

            builder.ToTable("StudentCourse", "University");


            builder.HasKey(studentCourse => new { studentCourse.StudentId, studentCourse.CourseId });

            builder.HasOne(studentCourse => studentCourse.Student).WithMany(student => student.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.StudentId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(studentCourse => studentCourse.Course).WithMany(course => course.StudentCourses)
                .HasForeignKey(studentCourse => studentCourse.CourseId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
