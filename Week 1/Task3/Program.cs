using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static int[] doubleArray(int size, int[] mArr) // Create a method that outputs array with doubled size 
        {
            int[] dArr = new int[size * 2 + 1];
            for (int i = 0; i < size; i++)
            {
                dArr[2 * i + 1] = mArr[i]; // all elements of doubled array with odd index is equal to values of initial array
            }
            for (int i = 1; i <= size; i++)
            {
                dArr[2 * i] = dArr[2 * i - 1]; // all elements of doubled array with even index is equal to elements of doubled array with odd index
            }
            return dArr;
        }

        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int size = int.Parse(x);
            int[] array = new int[size];
            string word = Console.ReadLine();
            array = word.Split(' ').Select(int.Parse).ToArray();

            int[] doubled = doubleArray(size, array);
            for (int i = 1; i <= size * 2; i++)
            {
                Console.Write(doubled[i] + " "); // output doubled array in console
            }
        }
    }
}
