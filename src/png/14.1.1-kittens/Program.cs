
class Kitten {
    double cuteness;
    public static int count = 0;
    
    public Kitten(double newCuteness) {
        cuteness = newCuteness;
        count++;
    }

    public string Pet() {
        if (cuteness < 5) {
            return "*hiss*"; // Angry cat sound, leave it alone.
        }

        if (cuteness < 10) {
            return "Mrem"; // Surprised cat sound, be gentle.
        }

        if (cuteness < 15) {
            return "Meow"; // Normal cat meow, continue.
        }

        return "Meow!"; // Awww-dorable!
    }
}

class Program {
    static int expectedKittenCount = 20;
    
    public static void Main(string[] args) {
        for (int i = 0; i < expectedKittenCount; i++) {
            Console.WriteLine(new Kitten(1.25 * i).Pet());
        }

        if (expectedKittenCount != Kitten.count) {
            Console.WriteLine($"{expectedKittenCount} != {Kitten.count}!!!");
        }
    }
}