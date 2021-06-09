using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    class Question1 {

        public int DecimalToBinary(int number) {

            if (number == 0) {

                return 1;
            }

            Console.WriteLine(number % 2);

            return DecimalToBinary(number / 2);

        }

    }

}
