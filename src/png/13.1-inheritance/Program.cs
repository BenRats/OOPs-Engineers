// I'm gonna be fancy and use Interfaces, Abstract classes
// This is gonna be the most object oriented code you have ever seen.
using System;

public interface IItem {
    public string GetName();
    public double GetPrice();
}

public class Item : IItem {
    protected string name;
    protected double price;

    public virtual string GetName() {
        return name;
    }

    public virtual double GetPrice() {
        return price;
    }
    
    // Constructor
    public Item(string itemName, double itemPrice) {
        name = itemName;
        price = itemPrice;
    }

    public override string ToString() {
        return $"Food item named \"{name}\", priced at {price.ToString()}$";
    }
}

// Now for FoodItem, which inherits Item
public class FoodItem : Item, IItem {
    protected DateTime expiresAt;

    public virtual DateTime GetExpiresAt() {
        return expiresAt;
    }

    public override string ToString() {
        string result = base.ToString();
        return $"{result}\nThis is a food item expiring at {expiresAt.ToString()}";
    }

    // Constructor
    // Piggybacks off of Item constructor.
    public FoodItem (string name, double price, DateTime expiration) : base(name, price) {
        expiresAt = expiration;
    }
}

public class NonFoodItem : Item, IItem {
    protected string[] materials;

    public virtual string[] GetMaterials() {
        return materials;
    }

    

    public override string ToString() {
        string result = base.ToString();
        string materialsTmp = "[";
        foreach (string material in materials) {
            materialsTmp = $"{materialsTmp}{material}, ";
        }
        materialsTmp = $"{materialsTmp}]";
        
        return $"{result}\nThis is a non-food item with the following materials: {materialsTmp}";
    }
    
    // Constructor
    // Piggybacks off of Item constructor.
    public NonFoodItem (string name, double price, string[] itemMaterials) : base(name, price) {
        materials = itemMaterials;
    }
}

public class Program {
    public static void Main(string[] args) {
        var foods = new FoodItem[10];
        for (int i = 0; i < foods.Length; i++) {
            foods[i] = new FoodItem($"Food #{i}", i * 25, new DateTime((long) i * 250000));
        }

        foreach (FoodItem food in foods) {
            Console.WriteLine(food);
        }

        Console.WriteLine("");

        var items = new NonFoodItem[10];
        for (int i = 0; i < items.Length; i++) {
            items[i] = new NonFoodItem($"Regular Item #{i}", i * 75, new string[0]);
        }

        foreach (NonFoodItem item in items) {
            Console.WriteLine(item);
        }
    }
}