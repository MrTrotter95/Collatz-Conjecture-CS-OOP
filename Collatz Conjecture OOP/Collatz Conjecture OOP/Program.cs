using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The Collatz Conjecture in OOP.
            The Collatz Connjecture is a simple math problem that still hasn't been solved.
            The conjecture is that if you pick any number, and follow the two simple rules 
            you will always reach a 4,2,1 loop.
            So, if you're up for trying to see if this conjecture is false,
             you'll have to start at 300 Quintillion. */


            // the rules are simple. pick any number. If that number is even then / 2. If that number is Odd then * 3 + 1.
            // to run the calculation, simply create a new object of type Number. and enter in any number you like.
            Number first = new Number(100);

            // to see the calculation happen. call the DisplayResult Method.
            first.DisplayResult();
            Console.Read();
        }
    }
}
