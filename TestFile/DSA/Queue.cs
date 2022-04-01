using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Queue
    {
        int[] array;
        int maxSize;
        int front, rear;

        public Queue()
        {
            this.maxSize = 5;
            this.array = new int[maxSize];
            this.front = this.rear = -1;
        }
        public void Do()
        {
            this.Insert(2);
            this.Insert(7);
            this.Insert(4);
            this.Print();
            this.Delete();
            this.Print();
            this.Insert(5);
            this.Insert(8);
            this.Print();
        }
        void Insert(int num)
        {
            //check if queue is full
            if (rear == maxSize - 1 && front == 0)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                //if front is -1, set to 0
                if (front == -1)
                {
                    front = 0;
                }
                //Increment rear and add value
                rear = rear + 1;
                array[rear] = num;

            }

        }

         int Delete()
        {
            //check if queue is empty
            if (front == -1 && rear == -1)
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }
            else
            {
                int num = array[front];
                if (front >= rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = front + 1;

                }
                return num;
            }

        }
        void Print()
        {
            for(int i = front; i<= rear; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

