using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class StringReverse
    {
        public void Do()
        {
            Console.WriteLine("Please enter the string");
            string input = Console.ReadLine();



            string result = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = result + input[i];//a, am, ami, amin, aminr, aminro, aminroo, aminroop
            }
            Console.WriteLine(result);
        }
    }
}
