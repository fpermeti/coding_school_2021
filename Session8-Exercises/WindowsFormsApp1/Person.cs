using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    public class Person {

        public Guid ID { get; }

        public virtual string Name { get; set; }

        public int Age { get; set; }

        public Person() {

            ID = Guid.NewGuid();
        }
    }
}
