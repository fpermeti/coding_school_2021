﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingSchool.Model;

namespace TrainingSchool.EF.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.ToTable("Course", "University");

            builder.HasKey(course => course.Id);

            builder.Property(course => course.Id).ValueGeneratedOnAdd();

            builder.Property(course => course.Title).HasMaxLength(100).IsRequired(true);

            builder.Property(course => course.Category).HasMaxLength(100).IsRequired(true);

            builder.Property(course => course.Date).IsRequired(true);

            builder.Property(course => course.Duration).IsRequired(true);


        }
    }
}
