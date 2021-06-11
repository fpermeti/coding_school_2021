using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Grade : Entity {

        public Guid StudentID { get; set; }

        public Guid CourseID { get; set; }

        public int Value { get; set; }

        public Grade() : base() {

        }
    }
}
