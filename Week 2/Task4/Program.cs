using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string fileName = "as.txt";
                string Path = @"C:\Users\A5LAN\Desktop\pp2\path";
                string Path1 = @"C:\Users\A5LAN\Desktop\pp2\path1";
                string sourceFile = System.IO.Path.Combine(Path, fileName);
                string destFile = System.IO.Path.Combine(Path1, fileName);
                if (!System.IO.Directory.Exists(Path1))
                {
                    System.IO.Directory.CreateDirectory(Path1);
                }
                System.IO.File.Copy(sourceFile, destFile, true);
                if (System.IO.Directory.Exists(Path))
                {
                    string[] files = System.IO.Directory.GetFiles(Path);


                    foreach (string s in files)
                    {

                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(Path1, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Исходный путь не существует!");
                }

                if (System.IO.File.Exists(@"C:\Users\A5LAN\Desktop\pp2\path\as.txt"))
                {

                    try
                    {
                        System.IO.File.Delete(@"C:\Users\A5LAN\Desktop\pp2\path\as.txt");
                    }
                    catch (System.IO.IOException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }




                Console.ReadKey();
            }
        }

    }
}
