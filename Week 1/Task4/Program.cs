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
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("[*]"); // output given string
                }
                Console.WriteLine(); // writed in order to  end line
            }
        }
    }
}
