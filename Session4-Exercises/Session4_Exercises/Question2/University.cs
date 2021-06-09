using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    public class University : Institute {

        public Student[] Students { get; set; }

        public Course[] Courses { get; set; }

        public Grade[] Grades { get; set; }

        public Schedule[] ScheduledCourse { get; set; }

        public Student[] GetStudents() {

            return Students;
        }

        public Course[] GetCourses() {

            return Courses;
        }

        public Grade[] GetGrades() {

            return Grades;
        }

        public void SetSchedule(Guid courseId, Guid professorId, DateTime dateTime) {

        }
    }
}
