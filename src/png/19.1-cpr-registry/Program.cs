/*
public interface IPerson {
    // Hardy-ha. The Danish CPR leak of 2026 is wonderful.
    void LeakAllInfo();
}*/

public class Person {
    private string name;
    private int age;
    private string cpr; // Lol, lmao even.

    public string GetName() => name;
    public int GetAge() => age;
    public string GetCpr() => cpr;

    public Person(string name, int age, string cpr) {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }

    public override string ToString() {
        return $"Person(name: \"{name}\", age: {age.ToString()}, cpr: \"{cpr}\")";
    }
}

public class Program {
    public static void Main(string[] args) {
        const string specialCpr = "010101-0101";
        
        List<Person> persons = [
            new Person("John", 20, "123132-1232"),
            new Person("Kate", 21, "213231-2131"),
            new Person("Jane", 19, "321312-3212"),
            new Person("Mike", 23, "132123-1323"),
            new Person("Miku", 39, specialCpr) // Statistical outlier
        ];

        var personMap = new Dictionary<string, Person>();
        
        foreach (var person in persons) {
            // miitsuketaa!!!
            if (person.GetCpr() == specialCpr) {
                Console.WriteLine($"Found you! {person.ToString()}");
            }

            // Add people to hashmap while we're here tho :P
            personMap.Add(person.GetCpr(), person);
        }

        // This is way easier with a dictionary, huzzah!
        Console.WriteLine($"Found you! {personMap[specialCpr].ToString()}");
    }
}