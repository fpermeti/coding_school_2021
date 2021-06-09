using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args) {

            Question1();

            Question2();

            Question3();

            Question4();

            Question5();

            Question6();

            Question7();

            Question8();

            Question9();

            Question10();

            Console.ReadLine();
        }

        static void Question1() {

            Console.WriteLine("Question 1:");

            Console.WriteLine("Hello Frantsesko");
        }

        static void Question2() {

            Console.WriteLine("\nQuestion 2:");

            decimal number1 = 7.5m, number2 = 8.5m;

            decimal sum = number1 + number2;

            Console.WriteLine("Addition: " + number1 + " + " + number2 + " = " + sum);

            decimal division = (decimal)number1 / number2;

            Console.WriteLine("Division: " + number1 + " / " + number2 + " = " + division);

        }


        static void Question3() {

            Console.WriteLine("\nQuestion 3:");

            decimal currentOperation = -1 + 5 * 6;

            Console.WriteLine("Operation 1:  -1 + 5 * 6 = " + currentOperation);

            currentOperation = 38 + 5 % 7;

            Console.WriteLine("Operation 2:  38 + 5 % 7 = " + currentOperation);

            currentOperation = (14 + (decimal)(-3 * 6) / 7);

            Console.WriteLine("Operation 3:  14 + (-3 * 6) / 7 = " + currentOperation);

            currentOperation = 2 + ((decimal)13 / 6) * 6 + (decimal)Math.Sqrt(7);

            Console.WriteLine("Operation 4:  2 + (13 / 6) * 6 + sqrt(7) = " + currentOperation);

            currentOperation = ((decimal)Math.Pow(6, 4) + (decimal)Math.Pow(5, 7)) / (9 % 4);

            Console.WriteLine("Operation 5:  (6 ^ 4 + 5 ^ 7) / (9 % 4)  = " + currentOperation);

        }

        static void Question4() {

            Console.WriteLine("\nQuestion 4:");

            decimal[] numbers = new decimal[3];

            for (int i = 0; i < numbers.Length; i++) {

                Console.Write("Enter number " + (i + 1) + ": ");

                numbers[i] = decimal.Parse(Console.ReadLine());

            }

            decimal product = 1m;

            for (int i = 0; i < numbers.Length; i++) {

                product *= numbers[i];

            }

            Console.WriteLine("The final product is: " + product);

        }

        static void Question5() {

            Console.WriteLine("\nQuestion 5:");

            decimal[] numbers = new decimal[5];

            for (int i = 0; i < numbers.Length; i++) {

                Console.Write("Enter number " + (i + 1) + ": ");

                numbers[i] = decimal.Parse(Console.ReadLine());

            }

            decimal sum = 0;

            for (int i = 0; i < numbers.Length; i++) {

                sum += numbers[i];

            }

            decimal average = sum / numbers.Length;

            Console.WriteLine("The average is: " + average);

        }

        static void Question6() {

            Console.WriteLine("\nQuestion 6:");

            Console.Write("Enter your age: ");

            decimal age = decimal.Parse(Console.ReadLine());

            Console.Write("Enter your gender: ");

            string gender = Console.ReadLine();

            Console.WriteLine("You are " + gender + " and look younger than " + age);

        }

        static void Question7() {

            Console.WriteLine("\nQuestion 7:");

            Console.Write("Enter seconds: ");

            decimal seconds = decimal.Parse(Console.ReadLine());

            Console.WriteLine(seconds + " seconds is equal to: " + (seconds / 60) + " minutes");

            Console.WriteLine(seconds + " seconds is equal to: " + (seconds / 60 / 60) + " hours");

            Console.WriteLine(seconds + " seconds is equal to: " + (seconds / 60 / 60 / 24) + " days");

            Console.WriteLine(seconds + " seconds is equal to: " + (seconds / 60 / 60 / 24 / 365) + " years");

        }

        static void Question8() {

            Console.WriteLine("\nQuestion 8:");

            Console.Write("Enter seconds: ");

            decimal seconds = decimal.Parse(Console.ReadLine());

            TimeSpan TimeSpanObject = TimeSpan.FromSeconds((double)seconds);

            Console.WriteLine(seconds + " seconds is equal to: " + (TimeSpanObject.TotalMinutes) + " minutes");

            Console.WriteLine(seconds + " seconds is equal to: " + (TimeSpanObject.TotalHours) + " hours");

            Console.WriteLine(seconds + " seconds is equal to: " + (TimeSpanObject.TotalDays) + " days");

            Console.WriteLine(seconds + " seconds is equal to: " + (TimeSpanObject.TotalDays / 365) + " years");

        }

        static void Question9() {

            Console.WriteLine("\nQuestion 9:");

            Console.Write("Enter temperature in celsius degrees: ");

            decimal celsius = decimal.Parse(Console.ReadLine());

            Console.WriteLine(celsius + " degrees celsius is equal to " + ((celsius * 9 / 5) + 32) + " Fahrenheit");

            Console.WriteLine(celsius + " degrees celsius is equal to " + (celsius + (decimal)273.15) + " Kelvin");

        }

        static void Question10() {

            Console.WriteLine("\nQuestion 10:");

            Console.Write("Enter string: ");

            string string1 = Console.ReadLine();

            string[] string2 = string1.Split('a');

            Console.WriteLine("The string without any \'a\' characters is: " + String.Join("", string2));

        }

    }

}
