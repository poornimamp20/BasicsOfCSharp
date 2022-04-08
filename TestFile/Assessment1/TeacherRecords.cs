using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    class TeacherRecords
    {
        public void WriteFile()
        {
            string content = "ID, TeacherName, Class, Section";
            File.WriteAllText("C://Users//poornima_metri//TeacherRecords.txt", content);

        }

        public void UpdateFile()
        {
            string teacher = "\n123, Poornima, 1, A\n124, Priya, 2, C";
            File.AppendAllText("C://Users//poornima_metri//TeacherRecords.txt", teacher);

        }

        public void UpdateFile(String input)
        {
            String[] inputArr = input.Split(",");
            String id = inputArr[0];
            String name = inputArr[1];
            String cls = inputArr[2];
            String section = inputArr[3]; 

            String updateRecord = GetRecord(id);
            String[] recArray = updateRecord.Split(",");
            recArray[1] = name;
            recArray[2] = cls;
            recArray[3] = section;

            String updatedString = String.Join(", ", recArray);


            string[] contents = File.ReadAllLines("C://Users//poornima_metri//TeacherRecords.txt");

            for (int i = 0; i < contents.Length; i++)
            {
                if (contents[i].Contains(id))
                {
                    contents[i] = updatedString;
                    Console.WriteLine(contents[i]);
                }

            }


            File.WriteAllLines("C://Users//poornima_metri//TeacherRecords.txt", contents);

        }

        public void ReadFile()
        {
            /* string content = File.ReadAllText("C://Users//poornima_metri//TeacherRecords.txt");
             Console.WriteLine(content);*/
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//TeacherRecords.txt");
            foreach (string str in contents)
            {
                Console.WriteLine(str);
            }
        }

        public String GetRecord(String Id)
        {
            /* string content = File.ReadAllText("C://Users//poornima_metri//TeacherRecords.txt");
             Console.WriteLine(content);*/
            string[] contents = File.ReadAllLines("C://Users//poornima_metri//TeacherRecords.txt");
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
            if (File.Exists("C://Users//poornima_metri//TeacherRecords.txt"))
            {
                File.Delete("C://Users//poornima_metri//TeacherRecords.txt");
            }

        }
        
        public void DisplayInputs()
        {
            string s1 = "1. Add Data 2.Update data 3.Display 4.Exit\n";
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
                    Console.WriteLine("Enter record ID, Name, Class, Section to be updated");
                    String recInput = Console.ReadLine();

                    UpdateFile(recInput);
                }
                

                if (input.Equals("3"))
                {
                    ReadFile();
                }
                else if (input.Equals("4"))
                {
                    Console.WriteLine("exiting, Thank you");
                    keeprunning = false;
                    break;
                }

            }




        }



    
}
}
