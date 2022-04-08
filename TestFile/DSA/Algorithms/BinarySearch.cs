using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    //T(n) => 0(logn)
    static class BinarySearch
    {
        static int[] array = { 4, 17, 29, 30, 43, 89, 231, 645, 982 };

        public static void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 645);
            Console.WriteLine("Element at index" + result);
            result = binarySearch(array, 0, array.Length - 1, 648);
            Console.WriteLine("Element at index" + result);

        }

        public static int binarySearch(int[] array, int left, int right, int num)
        {
            if (right >= left)
            {
                //Step1: Find mid element
                int mid = (right + left) / 2;

                //Step 2: Check if num is less than mid
                if (array[mid] == num)
                {
                    return mid;
                }
                // Step 3: Check if num is less than mid
                if (num < array[mid])
                {
                    return binarySearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarySearch(array, mid + 1, right, num);
                }
            }
            return -1;
        }
        
        }
        }


       
