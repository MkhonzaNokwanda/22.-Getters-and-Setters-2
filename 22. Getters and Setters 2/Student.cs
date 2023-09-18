using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Getters_and_Setters_2
{
    internal class Student
    {
        public string name;
        public int age;
        public string gender;

        public static int studentCount=0;

        //Constructors
        public Student(string aName, int aAge,string aGender)
        {
            name = aName;
            age = aAge;
            gender = aGender;
            studentCount++;
        }
        public string Gender
        { 
            get
            { return gender; } 
            set 
            {
                    if (value == "Female" || value == "Male")
                    { gender = value; }
                    else
                    { gender = "Non-binary"; }
            }
        }
    }
}
