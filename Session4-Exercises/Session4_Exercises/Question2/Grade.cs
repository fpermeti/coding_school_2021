using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    public class Grade {

        public Guid Id { get; set; }

        public Guid StudentId { get; set; }

        public Guid CourseId { get; set; }

        //renamed Grade to Value
        public int Value { get; set; }

    }
}
