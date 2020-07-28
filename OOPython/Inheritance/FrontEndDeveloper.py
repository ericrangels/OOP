#Import abstract class
from Inheritance.TechProfessional import TechProfessional

#Example of a Class that inherits from abstract class
class FrontEndDeveloper (TechProfessional):
    
    def Position(self, devLanguage):
        print("Hi my name is {0}. I am a FrontEnd Developer and I like to use {1} to build things!".format(self.FullName(), devLanguage))

       