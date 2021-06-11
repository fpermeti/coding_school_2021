using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.Impl {


    public class University : Institute {

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Course> Courses { get; set; }


        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }


        public University() : base() {

            ScheduledCourses = new List<Schedule>();
            Grades = new List<Grade>();
        }


        public void SetScheduledCourses(Guid courseID, Guid professorID, DateTime dateTime) {


        }
    }
}

