using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    class BubbleSort
    {
        static int[] array = {43, 78, 21, 9, 34, 2, 11 };
        

        public static void Do()

        {
            int counter = 0;
            int n = array.Length;
            //iteration loop
            for(int i= 0; i< n - 1; i++)
            {
                counter++;
                //swap loop
                for(int j = 0; j <n-1; j++)
                {
                    counter++;
                    if(array[j]> array[j+ 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            foreach(int num in array)
            {
                Console.WriteLine(num + " ");
            }
            Console.WriteLine("Iteration" + counter);
        }
    }
}
