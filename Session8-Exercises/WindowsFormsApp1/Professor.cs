using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Professor : Person {

        public string Rank { get; set; }

        //public List<Course> Courses { get; set; }

        public override string Name { get => string.Format("Dr. {0}", base.Name); set => base.Name = value; }


        public Professor() : base() {

        }

        public void Teach(Course course, DateTime dateTime) {

        }

        public void SetGrade(Guid studentId, Guid courseId, Grade grade) {

        }
    }
}
