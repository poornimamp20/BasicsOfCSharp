using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    //Instance method- InstanceOfClass.Methodname();=>new DataType().Do();
    class DataType
    {
        public void Do()
        {
            //
            int num1 = 100;
            Console.WriteLine(num1);
            
            //8byte
            long num2 = 67943875;
            Console.WriteLine(num2);
           
            //precision based values- 4 byte
            float num3 = 100.01F;
            Console.WriteLine(num3);
            
            //8 byte

            double num4 = 3465537829.23 ;
            Console.WriteLine(num4);

            //16 byte
            decimal num5 = 32678945888.34M;
            Console.WriteLine(num5);

            //Alphanumeric

            // char
            char ch = 'P';
            Console.WriteLine(ch);

            //string is a class/referance and string is immutable
            string str = "My name is";
            Console.WriteLine(str);

            // Boolean(true, false)
            bool isTrue = true;
            Console.WriteLine(isTrue);





        }
    }
}
