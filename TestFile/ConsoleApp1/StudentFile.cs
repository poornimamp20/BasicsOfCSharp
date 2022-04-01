using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class StudentFile
    {
        public void WriteFile()
        {
            string content = "StudentID, StudentName, Dept";
            File.WriteAllText("C://Users//poornima_metri//StudentDetails.txt", content);

        }

        public void UpdateFile()
        {
            string employee = "\n123, Poornima, Science\n124, Priya, Zology";
            File.AppendAllText("C://Users//poornima_metri//StudentDetails.txt", employee);

        }

        public void UpdateFile(String input)
        {
           String[] inputArr= input.Split(",");
            String id = inputArr[0];
            String name = inputArr[1];
            String dept = inputArr[2];
                        
            String updateRecord = GetRecord(id);
            String[] recArray = updateRecord.Split(",");
            recArray[1] = name;
            recArray[2] = dept;
           String updatedString = String.Join(", ", recArray);
            

            string[] contents = File.ReadAllLines("C://Users//poornima_metri//StudentDetails.txt");

            for(int i = 0; i < contents.Length; i++) {
                if (contents[i].Contains(id))
                {
                    contents[i] = updatedString;
                    Console.WriteLine(contents[i]);
                }
          
            }

            
            File.WriteAllLines("C://Users//poornima_metri//StudentDetails.txt", contents);

        }

        public void ReadFile()
        {
           /* string content = File.ReadAllText("C://Users//poornima_metri//StudentDetails.txt");
            Console.WriteLine(content);*/
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//StudentDetails.txt");
            foreach (string str in contents)
            {
                Console.WriteLine(str);
            }
        }

        public String GetRecord(String Id)
        {
            /* string content = File.ReadAllText("C://Users//poornima_metri//StudentDetails.txt");
             Console.WriteLine(content);*/
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//StudentDetails.txt");
            foreach (string str in contents)
            {
                if (str.Split(",")[0].Equals(Id))
                {

                    return str;
                }
                
            }
            return "";
        }
        public void DeleteFile()
            {
                if (File.Exists("C://Users//poornima_metri//StudentDetails.txt"))
                {
                    File.Delete("C://Users//poornima_metri//StudentDetails.txt");
                }

            }
        public void Deleterecord(string id)
        {
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//StudentDetails.txt");

            for (int i = 1; i < contents.Length; i++)
            {
                if (contents[i].Split(",")[0].Equals(id))
                {
                    contents = contents.Skip(i).ToArray();
                    
                }

            }
            File.WriteAllLines("C://Users//poornima_metri//StudentDetails.txt", contents);

        }
        public void DisplayInputs()
        {
            string s1 = "1. Add Data 2.Update data 3.Delete 4.Display 5.Exit\n";
            Console.WriteLine(s1);
            bool keeprunning = true;
            
            while (keeprunning)
            {
               
                String input = Console.ReadLine();
                if (input.Equals("1"))
                {
                    WriteFile();
                    UpdateFile();
                }
                if (input.Equals("2"))
                {
                    Console.WriteLine("Enter record id, name, dept to be updated");
                    String recInput = Console.ReadLine();

                    UpdateFile(recInput);
                }
                if (input.Equals("3"))
                {
                    Console.WriteLine("Enter record id to be deleted");
                    String recInput = Console.ReadLine();
                    Deleterecord(recInput);
                }

                if (input.Equals("4"))
                {
                    ReadFile();
                }
                else if (input.Equals("5"))
                {
                    Console.WriteLine("exiting, Thank you");
                    keeprunning = false;
                    break;
                }

            }
            

           

        }


        
    }
}
