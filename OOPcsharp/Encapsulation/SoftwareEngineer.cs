using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Encapsulation
{
    public class SoftwareEngineer : Engineer
    {

        private string _language;
        public SoftwareEngineer(string firstName, string lastName, int yearsExperience, string currentCompany, string language) : base(firstName, lastName, yearsExperience, currentCompany)
        {
            _language = language;
        }


        protected override void FunctionalAnalysis()
        {
            Console.WriteLine("The software analysis was completed with success.");
        }

        protected override void RequirementsGathering()
        {
            Console.WriteLine("The software requirements were verified with success.");
        }

        protected override void Development()
        {
            Console.WriteLine(string.Format("The software development was finished using {0}.",this._language));
        }

        protected override void Testing()
        {
            Console.WriteLine("The software test was executed with success.");
        }

    }
}
