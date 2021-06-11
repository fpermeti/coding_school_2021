﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Base;

namespace WindowsFormsApp1.Impl {

    public class Course : Entity {

        public string Subject { get; set; }

        public string Code { get; set; }

        public int Hours { get; set; }

        public CourseCategory Category { get; set; }

        public Course()
            : base() {

        }
    }
}
