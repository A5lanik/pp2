using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main()
        {
            // Get list of files in the specific directory.
            // ... Please change the first argument.
            string[] files = Directory.GetFiles("C:\\Users\\A5LAN\\Desktop\\pp2",
                "*.*",
                SearchOption.AllDirectories);

            // Display all the files.
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
