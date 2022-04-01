using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Stack
    {
        int[] array;
        int topPointer = -1;
        int maxSize;
        public void Do()
        {
            Stack stack = new Stack();
            stack.maxSize = 5;
            stack.array = new int[5];
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Print();
            stack.Pop();
            stack.Pop();
            stack.Print();
            stack.Push(7);
            stack.Push(8);
            stack.Print();



        }
        void Push(int num)
        {
            //check if stack is full
            if(topPointer == maxSize - 1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {//increment topPointer and store all value
                topPointer = topPointer + 1;
                array[topPointer] = num;            }

        }
        int Pop()
        {
            // check if stack is empty
            if(topPointer == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int element = array[topPointer];
                topPointer--;
                return element;
            }

        }

        void Print()
        {
            for(int i = topPointer; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

    }
   
}
