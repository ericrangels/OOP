using System;
using System.Collections.Generic;
using System.Text;

namespace OOPcsharp.Inheritance
{
    /*
     * Example of a Class that inherits from abstract class and interface
     * 
     * */

    public class BackEndDeveloper : TechProfessional, ITeamMember
    {
        private int _yearsExperience;

        private string _local;
        private string _area;
        public string TeamName
        {
            get
            {
                return string.Format("{0} {1}", this._local, this._area);
            }
        }

        public BackEndDeveloper(string firstName, string lastName, int yearsExperience, string local, string area) : base(firstName, lastName)
        {
            this._yearsExperience = yearsExperience;
            this._local = local;
            this._area = area;
        }

        public override void Position()
        {
            Console.WriteLine(string.Format("Hey my name is {0}. I am a BackEnd Developer!", this.FullName));
        }

        public override void Experience()
        {
            Console.WriteLine(string.Format("Hey my name is {0}. I am a BackEnd Developer with {1} year(s) of experience!", this.FullName, this._yearsExperience));
        }

        public void Team()
        {
            Console.WriteLine(string.Format("Hey my name is {0}. I am a BackEnd Developer from {1} team.", this.FullName, this.TeamName));
        }
    }
}
