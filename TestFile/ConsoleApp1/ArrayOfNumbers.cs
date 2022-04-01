using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class ArrayOfNumbers
    {
        //array is collection of same data type
        int[] array = { 20, 56, 90, 32, 43, 89, 112 };

        public void Do()
        {
            //can't traverse in reverse order
            //foreach(datatype item in array){}
            foreach (int num in array)
            {
                Console.Write(num);
                Console.Write(" ");

            }


        }
        
    }
}
