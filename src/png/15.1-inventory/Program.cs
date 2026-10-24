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

// Inventory
public class Inventory {
    private List<Item> items = [];

    public void AddItem(Item item) {
        items.Add(item);
    }

    public void RemoveItem(Item item) {
        items.Remove(item);
    }

    public double GetInventoryValue() {
        double result = 0.0;
        foreach (var item in items) {
            result += item.GetPrice();
        }
        return result;
    }

    public void PrintInventory() {
        foreach (var item in items) {
            Console.WriteLine(item.ToString());
        }
    }
}

public class Test {
    public static void Main(string[] args) {
        var inventory = new Inventory{};


        string[] foodsNames = ["Sushi", "Burrito", "Rice", "Sandwich"];
        for (int i = 0; i < foodsNames.Length; i++) {
            inventory.AddItem(new FoodItem(foodsNames[i], i * 25, new DateTime((long) i * 250000)));
        }

        string[] nonFoodNames = ["Pencil", "Table", "Chair", "Cutting board"];
        for (int i = 0; i < nonFoodNames.Length; i++) {
            inventory.AddItem(new NonFoodItem(nonFoodNames[i], i * 50, ["wood"]));
        }

        inventory.PrintInventory();

        double value = inventory.GetInventoryValue();
        double expectedValue = ((double) ((25 * 4) + (4 * 50)));
        if (value == expectedValue) {
            Console.WriteLine($"GetInventoryValue() returned {value}, expected {expectedValue}");
        }
    }
}
