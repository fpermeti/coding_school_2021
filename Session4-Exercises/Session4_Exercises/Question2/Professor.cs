using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    public class Professor : Person {

        public string Rank { get; set; }

        public Course[] Courses { get; set; }

        public void Teach(Course course, DateTime dateTime) {

        }

        public void SetGrade(Guid studentId, Guid courseId, Grade grade) {

        }

        public override string GetName() {

            return string.Format("Dr. {0}", Name);
        }
    }
}
