using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class EvenOdd
    {
        public void Do()
        {
            Console.WriteLine("Please enter a number to find even or odd and enter 0 to exit");
            bool keepRunning = true;
            //while loop
            while (keepRunning) { 

            //how to read from console
            string input = Console.ReadLine();

            //How to convert from one datatype to another dt
            int value = Convert.ToInt32(input);
                if (value == 0)
                {
                    keepRunning = false;
                    break;
                }

                //Check odd or even
            if (value % 2 == 0)
            {
                Console.WriteLine("This is Even");

            }
            else {
                Console.WriteLine("This is odd");

            }
            }
        }
    }
}
