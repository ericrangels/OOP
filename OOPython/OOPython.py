
from Inheritance.FrontEndDeveloper import FrontEndDeveloper
from Inheritance.BackEndDeveloper import BackEndDeveloper

from Polymorphism.AppDeveloper import AppDeveloper
from Polymorphism.WebDeveloper import WebDeveloper


#INHERITANCE
frontEndDeveloper = FrontEndDeveloper("Michael", "Jordan");
frontEndDeveloper.Position("React.js");
frontEndDeveloper.Experience();

backEndDeveloper = BackEndDeveloper("Elon", "Musk");
backEndDeveloper.Position();
backEndDeveloper.Experience(7);


#POLYMORPHISM
dev_app = AppDeveloper("xCode")
dev_web = WebDeveloper(".NET Core MVC")

for developer in (dev_app, dev_web):
    developer.Code()