using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {

    public class Professor : Person {

        public override string Name { get => string.Format("Dr. {0}", base.Name); set => base.Name = value; }

        public ProfessorRank Rank { get; set; }

        public List<Course> Courses { get; set; }

        public Professor() : base(){

            Courses = new List<Course>();

        }
    }
}
