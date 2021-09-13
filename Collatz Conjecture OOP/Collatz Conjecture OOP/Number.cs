using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_OOP
{
    class Number
    {

        // Constructor - To create an object, and to store the value entered into MyNumber.
        // This way allows us to adjust the variable MyNumber safely and doesn't expose it.
        public Number(int number)
        {
            MyNumber = number;
        }


        // to get and set the value that was passed through.
        public int MyNumber { get; set; }





        // The Method to run the calculation and display the results!
        public void DisplayResult()
        {
            while(MyNumber > 1)
            {
                if (MyNumber % 2 == 0)
                {
                    MyNumber = MyNumber / 2;
                    Console.WriteLine(MyNumber);
                } 
                else
                {
                    MyNumber = MyNumber * 3 + 1;
                    Console.WriteLine(MyNumber);
                }
            }
        }
    }
}
