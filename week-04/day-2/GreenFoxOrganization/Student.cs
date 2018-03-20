using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrg) : base(name, age, gender)
        {
            
            previousOrganization = previousOrg;           
        }

        public Student() : base()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public override void GetGoal()   
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, Im " + name + " a " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " from the course already ");
        }

        public int Skipdays(int numberOfDays)
        {
             return skippedDays += numberOfDays++;
        } 
    }
}
