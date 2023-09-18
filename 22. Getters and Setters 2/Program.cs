using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Getters_and_Setters_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Nono",18,"Female");
            Student stu2 = new Student("Penguin",17,"Male");
            Student stu3 = new Student("Mimi",39,"hggf");

            Console.WriteLine(Student.studentCount);

            //freeze console
            Console.ReadLine();
        }
    }
}
