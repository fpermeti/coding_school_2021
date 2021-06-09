using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            Question1();

            Question2();

            Question3();

            Question4();

            Question5();

            Question6();

            Console.ReadLine();

        }

        static void Question1() {

            Console.WriteLine("\nQuestion1:");

            string sentence = "lorem ipsum dolor sit amet consectetur adipiscing elit";

            string longestWord = string.Empty;

            string[] words = sentence.Split(' ');

            longestWord = words[0];

            for (int i = 1; i < words.Length; i++) {

                if (words[i].Length > longestWord.Length) {

                    longestWord = words[i];

                }

            }

            Console.WriteLine("The longest word converted to uppercase in \"{0}\" is: {1}", sentence, longestWord.ToUpper());

        }

        static void Question2() {

            Console.WriteLine("\nQuestion2:");

            Console.Write("Enter a string: ");

            string givenString = Console.ReadLine();

            char[] charArray = givenString.ToCharArray();

            Array.Reverse(charArray);

            string reversedGivenString = new string(charArray);

            Console.WriteLine("If we reverse \"{0}\" we get: {1}", givenString, reversedGivenString);

        }

        static void Question3() {

            Console.WriteLine("\nQuestion3:");

            Console.Write("Enter an integer: ");

            int givenInteger = int.Parse(Console.ReadLine());

            Console.Write("Compute sum or product (type \"sum\" or \"product\") ?: ");

            string choice = Console.ReadLine();

            uint sum = 0;

            uint product = 1;

            if (choice == "sum") {

                for (int i = 1; i <= givenInteger; i++) {

                    sum += (uint)i;

                }

                Console.WriteLine("The sum is: {0}", sum);

            }
            else if (choice == "product") {

                for (int i = 1; i <= givenInteger; i++) {

                    product *= (uint)i;

                }

                Console.WriteLine("The product is: {0}", product);

            }
            else {

                Console.WriteLine("Wrong choice.");

            }

        }

        static void Question4() {

            Console.WriteLine("\nQuestion4:");

            Console.Write("Enter an integer: ");

            int givenInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Prime numbers: ");

            for (int i = 1; i <= givenInteger; i++) {

                if (givenInteger <= 0) {

                    Console.WriteLine("The integer must be a non zero positive number.");

                    break;

                }
                else {

                    if (i % 2 == 0 && i != 2) {

                        continue;

                    }
                    else if (i % 3 == 0 && i != 3) {

                        continue;

                    }
                    else if (i % 5 == 0 && i != 5) {

                        continue;

                    }
                    else if (i % 7 == 0 && i != 7) {

                        continue;

                    }
                    else {

                        Console.WriteLine(i);

                    }

                }

            }

        }

        static void Question5() {

            Console.WriteLine("\nQuestion5:");

            int[] array1 = { 2, 4, 9, 12 };

            int[] array2 = { 1, 3, 7, 10 };

            int product = 1;

            for (int i = 0; i < array1.Length; i++) {

                for (int j = 0; j < array2.Length; j++) {

                    product = array1[i] * array2[j];

                    Console.WriteLine("{0} * {1} = {2}", array1[i], array2[j], product);

                    product = 1;

                }

            }

        }

        static void Question6() {

            Console.WriteLine("\nQuestion6:");

            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Array.Sort(array);

            Console.WriteLine("Sorted array:");

            foreach (var item in array) {

                Console.WriteLine(item);

            }
        }
    }
}
