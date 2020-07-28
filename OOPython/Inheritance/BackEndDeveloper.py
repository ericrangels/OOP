#Import abstract class
from Inheritance.TechProfessional import TechProfessional

#Example of a Class that inherits from abstract class
class BackEndDeveloper (TechProfessional):
    
    def Position(self):
        print("Hey my name is {0}. I am a BackEnd Developer!".format(self.FullName()))

    def Experience(self,yearsExperience):
        print("Hey my name is {0}. I am a BackEnd Developer with {1} year(s) of experience!".format(self.FullName(),yearsExperience))