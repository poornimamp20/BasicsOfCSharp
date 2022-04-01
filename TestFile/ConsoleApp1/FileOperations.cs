using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class FileOperations
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("C://Users//poornima_metri//EmployeeDetails.txt", content);

        }

        public void UpdateFile()
        {
            string employee = "\nPoornima, 1, Finance";
            File.AppendAllText("C://Users//poornima_metri//EmployeeDetails.txt", employee);

        }

        public void ReadFile()
        {
            string content = File.ReadAllText("C://Users//poornima_metri//EmployeeDetails.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//EmployeeDetails.txt");
            foreach(string str in contents)
            {
                Console.WriteLine(str);
            }
       
            
        }
        public void DeleteFile()
        {
            if (File.Exists("C://Users//poornima_metri//EmployeeDetails.txt"))
            {
                File.Delete("C://Users//poornima_metri//EmployeeDetails.txt");
            }

        }
    }
}
