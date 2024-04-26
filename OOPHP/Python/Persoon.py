class Person:
    def __init__(self, naam, leeftijd, geslacht, is_student, gemiddeld_cijfer):
        self.naam = naam
        self.leeftijd = leeftijd
        self.geslacht = geslacht
        self.is_student = is_student
        self.gemiddeld_cijfer = gemiddeld_cijfer


person = Person('Basma Sayed', 21, 'F', True, 8.5)
print(person.naam) 
print(person.leeftijd) 
print(person.geslacht) 
print(person.is_student) 
print(person.gemiddeld_cijfer) 