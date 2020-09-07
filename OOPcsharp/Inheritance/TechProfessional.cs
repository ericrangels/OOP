using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Inheritance
{
    /*
     * Example of Abstract Class with abstract and virtual methods
     * 
     * */

    public abstract class TechProfessional
    {
        private string _firstName;

        private string _lastName;

        public TechProfessional(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", this._firstName, this._lastName); }
        }

        public abstract void Position();

        public virtual void Experience()
         {
             Console.WriteLine(string.Format("My name is {0}. I am an IT General professional with over 10 years of experience!", this.FullName));
         }

    }
}
