using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Encapsulation
{
    /*
     * Example of abstract Class with abstract Encapsulated methods
     * 
     * */

    public abstract class Engineer
    {
        private string _firstName;

        private string _lastName;

        private int _yearsExperience;

        private string _currentCompany;

        public Engineer(string firstName, string lastName, int yearsExperience, string currentCompany)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearsExperience = yearsExperience;
            _currentCompany = currentCompany;
        }

        public string Profile
        {
            get
            {
                return string.Format("{0} {1}, {2} year(s) of experience, current working at {3}.", this._firstName, this._lastName, this._yearsExperience, this._currentCompany);
            }
        }

        public void BuildProject()
        {
            this.Release(this.Profile);
            this.FunctionalAnalysis();
            this.RequirementsGathering();
            this.Development();
            this.Testing();
        }

        protected abstract void FunctionalAnalysis();

        protected abstract void RequirementsGathering();

        protected abstract void Development();

        protected abstract void Testing();

        protected virtual void Release(string profile)
        {
            Console.WriteLine("This project has been released by: " + profile);
        }

    }
}
