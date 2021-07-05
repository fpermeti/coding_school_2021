using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary {
   public class FibonacciCalculator : IFibonacciCalculator {
         public long FibonacciSeries(long n) {

            if (n<0) {
                throw new ArgumentException("Invalid input", nameof(n));
            }

           else if (n==0) {
                return 0;
            }
            else if (n==1) {
                return 1;
            }
            else if (90 > n && n > 1) {
                return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
            }
            else {                  //if (n >= 90) 
                throw new ArgumentException("Fibonacci result number too big", nameof(n));
            }








        }
    }
}
