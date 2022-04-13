using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    class MergeSort
    {
        public void Do()
        {
            int[] array = { 92, 23, 41, 7, 32, 61, 12, 3 };
            Divide(array, 0, array.Length - 1);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }
        void Divide(int[] array, int left, int right)
        {
            if (left < right)
            {
                //1.find Mid
                int mid = (left + right) / 2;

                //2.divide left array(create pointers for right array)
                Divide(array, left, mid);

                //3.Divide right array(Create pointer for left array)
                Divide(array, mid + 1, right);

                //4. Merge and sort
                MergeAndSort(array, left, right, mid);
            }

        }


        void MergeAndSort(int[] array, int left, int right, int mid)
        {
            //1. create left and right array base on pointers
            //1.1 Length of arrays
            int leftArrayLength = mid - left + 1;
            int rightArrayLength = right - mid;

            //1.2 create arrays left and right
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            int i, j;
            for (i = 0; i < leftArrayLength; i++)
            {
                leftArray[i] = array[left + i];

            }
            for (j = 0; j < rightArrayLength; j++)
            {
                rightArray[j] = array[mid + 1 + j];
            }
            //2. Merge and sort
            i = 0; j = 0;
            int k = left;
            while (i < leftArrayLength && j < leftArrayLength)
            {
                if (leftArray[i] < rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;

                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < leftArrayLength)
            {
                array[k] = leftArray[i];
                i++;
                k++;

            }
            while (j < rightArrayLength)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }


        }
    }
}
