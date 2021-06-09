using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4_Exercises {
    class Program {
        static void Main(string[] args) {

            Question1 question1 = new Question1();

            Console.Write("Enter integer: ");

            string userInput = Console.ReadLine();

            int i = 0;

            if (Int32.TryParse(userInput, out i)) {

                int givenInteger = Int32.Parse(userInput);

                Console.WriteLine("Binary value in reverse order:");

                question1.DecimalToBinary(givenInteger);

            }
            else {

                Console.WriteLine("You did not enter an integer number.");

            }

            Console.ReadLine();

        }
    }
}
