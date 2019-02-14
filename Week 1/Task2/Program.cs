using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)  
        {
            Student Aslan = new Student("Aslan", "18BD110353");
            Aslan.year = 1;
            Aslan.Info();
        }
    }
    class Student // create class to insert student info
    {
        public string name;
        public string id;
        public int year;
        public Student(string n, string i) //create method with two parameters
        {
            name = n;
            id = i;
        }
        public void Info()
        {
            year++; // increment year of studying 
            Console.WriteLine($"{name} - {id} - {year}"); //Ouptup student info
        }

    }
}
