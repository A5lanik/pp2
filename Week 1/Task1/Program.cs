using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public static bool IsPrime(int a) // Create a method that output is this number prime or not
        {
            if (a <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) // if number divides to i this number is not prime
                {
                    return false;
                }

            }
            return true;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            string s = Console.ReadLine();
            array = s.Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]) == true)
                {
                    sum++;  // calcutating how much prime number in here
                }

            }
            Console.WriteLine(sum);
            for (int i = 0; i < array.Length; i++)
            {
                if (IsPrime(array[i]) == true)
                {
                    Console.Write(array[i] + " "); // output array of prime numbers
                }
            }
        }
    }
}
