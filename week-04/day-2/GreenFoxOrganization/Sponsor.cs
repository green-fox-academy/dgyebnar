using System;
using System.Collections.Generic;
using System.Text;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
        }

        public Sponsor() : base()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, Im " + name + " a " + age + " year old " + gender + " who represent " + company + " and hired " + hiredStudents + " students so far ");
        }

        public int Hire()
        {
            return hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

    }
}
