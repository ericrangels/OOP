using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Encapsulation
{
    public class CarEngineer : Engineer
    {
        public CarEngineer(string firstName, string lastName, int yearsExperience, string currentCompany) : base(firstName, lastName, yearsExperience, currentCompany)
        {

        }


        protected override void FunctionalAnalysis()
        {
            Console.WriteLine("The car features were analyzed with success.");
        }

        protected override void RequirementsGathering()
        {
            Console.WriteLine("The car details were verified with success.");
        }

        protected override void Development()
        {
            Console.WriteLine("The car manufacturing was finished with success.");
        }

        protected override void Testing()
        {
            Console.WriteLine("The car test was executed with success.");
        }
    }
}
