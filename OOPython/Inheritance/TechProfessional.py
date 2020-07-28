
# Example of Abstract Class with abstract and virtual methods

class TechProfessional:
   
    def __init__(self,first_name,last_name):
        self.first_name = first_name
        self.last_name = last_name

    def FullName(self):
        return "{0} {1}".format(self.first_name,self.last_name)

    def Position():
        pass

    def Experience(self):
        print("My name is {0}. I am an IT General professional with over 10 years of experience!".format(self.FullName()))