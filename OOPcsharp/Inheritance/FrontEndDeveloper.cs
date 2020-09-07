using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Inheritance
{
    /*
     * Example of a Class that inherits from abstract class
     * 
     * */

    public class FrontEndDeveloper : TechProfessional
    {
        private string _devLanguage;
        public FrontEndDeveloper(string firstName, string lastName, string devLanguage) : base(firstName, lastName)
        {
            this._devLanguage = devLanguage;
        }

        public override void Position()
        {
            Console.WriteLine(string.Format("Hi my name is {0}. I am a FrontEnd Developer and I like to use {1} to build things!", this.FullName, this._devLanguage));
        }
    }
}
