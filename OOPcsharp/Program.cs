using OOPcsharp.Encapsulation;
using OOPcsharp.Inheritance;
using OOPcsharp.Polymorphism;
using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            SoftwareEngineer softwareEngineer = new SoftwareEngineer("Jeff", "Bezos",33,"Amazon","C#");
            softwareEngineer.BuildProject();

            CarEngineer carEngineer = new CarEngineer("Ayrton", "Senna", 60, "McLaren");
            carEngineer.BuildProject();
            #endregion

            #region Inheritance
            FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper("Michael", "Jordan", "React.js");
            frontEndDeveloper.Position();
            frontEndDeveloper.Experience();

            BackEndDeveloper backEndDeveloper = new BackEndDeveloper("Elon", "Musk", 7, "San Francisco", "US");
            backEndDeveloper.Position();
            backEndDeveloper.Experience();
            backEndDeveloper.Team();
            #endregion

            #region Polymorphism
            WebDeveloper webDeveloper = new WebDeveloper("C#");
            webDeveloper.Code();
            webDeveloper.Code("JavaScrit");

            List<Developer> developers = new List<Developer>() { new WebDeveloper("JavaScript"), new AppDeveloper("React.js") };
            foreach (var item in developers)
            {
                item.Code();
            }
            #endregion

        }
    }
}
