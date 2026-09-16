Person mette_frederiksen = new Person {
    name = "Mette Frederiksen",
    nationality = "Danish",
    age = 48,
    profession = Profession.Politician,
    employed = true,
    paying_taxes = false // lol
};

Console.WriteLine("Person (");
Console.WriteLine($"\t Name: {mette_frederiksen.name}");
Console.WriteLine($"\t Nationality: {mette_frederiksen.nationality}");
Console.WriteLine($"\t Age: {mette_frederiksen.age}");
Console.WriteLine($"\t Profession: {mette_frederiksen.profession.ToString()}");
Console.WriteLine($"\t Employed?: {mette_frederiksen.employed}");
Console.WriteLine($"\t Paying taxes?: {mette_frederiksen.paying_taxes}");
Console.WriteLine(");");

class Person {
    public required string name;
    public required string nationality;
    public byte age; // `byte` is more than enough unless we achieve immortality, or count certain tree species as people.
    public Profession profession;
    public bool employed;
    public bool paying_taxes; // If baby or billionaire, then this is false
}

enum Profession {
    SoftwareEngineer, Firefighter, Doctor, PoliceOfficer, Politician, Farmer, Businessman, Entrepeneur, Author, Artist, Musician, Poet, Singer, Vocalist, Mascot, Model, Actor
}