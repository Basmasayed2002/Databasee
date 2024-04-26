using System;

public class Person {
    public string naam { get; set; }
    private int leeftijd { get; set; }
    private char geslacht { get; set; }
    public bool isStudent { get; set; }
    public double gemiddeldCijfer { get; set; }

    public Person(string naam, int leeftijd, char geslacht, bool isStudent, double gemiddeldCijfer) {
        this.naam = naam;
        this.leeftijd = leeftijd;
        this.geslacht = geslacht;
        this.isStudent = isStudent;
        this.gemiddeldCijfer = gemiddeldCijfer;
    }
}