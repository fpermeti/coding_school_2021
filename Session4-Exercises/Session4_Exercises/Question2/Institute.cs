using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    public class Institute {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int YearsInService { get; set; }

        public string GetName() {

            return Name;
        }

        public void SetName(string name) {

            Name = name;
        }
    }
}
