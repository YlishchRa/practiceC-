using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelagateAndEvents._15._06._2023
{
    public class Folders
    {
        public static void Task1()
        {
            Console.WriteLine("Enter direction: ");
            string direction = Console.ReadLine();
            
            Console.WriteLine("Enter mask");
            string mask = Console.ReadLine();


            DirectoryInfo dir = new DirectoryInfo(direction);
            DirectoryInfo sub_dir = dir.CreateSubdirectory(direction + "subDir");

            //uncomment in order to create file in directory
            //  Change directory full name to create files in other directory
            //for (int i = 0; i < 5; i++)
            //{
            //    string type = ".txt";

            //    if (i % 2 == 0) type = ".bat";

            //    FileInfo file = new FileInfo(sub_dir.FullName + @$"/File{i}" + type);
            //    file.Create();

            //}



            foreach (FileInfo file in dir.GetFiles(mask))
            {
                Console.WriteLine($"File {file.Name} at {dir.FullName} directory");
                Console.WriteLine($"File {file.Name} was created at {file.CreationTime}");
            }

            foreach(FileInfo file in sub_dir.GetFiles(mask))
            {
                Console.WriteLine($"File {file.Name} at {sub_dir.FullName} directory");
                Console.WriteLine($"File {file.Name} was created at {sub_dir.CreationTime}");
            }





        }
      

        public static void Task6()
        {
            Console.WriteLine("Enter path to directory");
            string path = Console.ReadLine() + @"\";

            DirectoryInfo dir = new DirectoryInfo(path);


            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine($"File {file.Name} is located in {dir.FullName}");

            }

            Console.WriteLine();

            foreach(DirectoryInfo sub_dir in dir.GetDirectories())
            {
                Console.WriteLine($"Folder {sub_dir.Name} is located in {dir.FullName}");
            }

        }
    }
}
