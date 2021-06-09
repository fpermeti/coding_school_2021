using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    public class Student : Person {

        public int RegistrationNumber { get; set; }

        public Course[] Courses { get; set; }

        public void Attend(Course course, DateTime dateTime) {

        }

        public void WriteExam(Course course, DateTime dateTime) {

        }
    }
}
