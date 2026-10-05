// I think this is what the exercise means by "Main" method???
public class Customer {
    int id;
    string name;
    private double balance; // Probably good to set this to "private"

    public Customer(string Name, int Id, double Balance) {
        id = Id;
        name = Name;
        balance = Balance;
    }

    // We just piggyback off of the existing constructor.
    public Customer(string name, int id) : this(name, id, 0) {}

    public void Deposit(double amount) {
        balance += amount;
    }

    public void Withdraw(double amount) {
        if (amount > balance) {
            // here we throw an exception when the amount exceeds the balance.
            // the exercise text didn't specify it, but I wanted to add this.
            throw new Exception("Amount to withdraw exceeds balance!");
        }
        balance -= amount;
    }

    public double GetBalance() {
        return balance;
    }
}

class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Hello World!");
        Customer aCustomer = new Customer("John", 0);
        Console.WriteLine($"John has {aCustomer.GetBalance()}$");

        aCustomer.Deposit(1000.0);
        Console.WriteLine($"John has {aCustomer.GetBalance()}$");

        aCustomer.Withdraw(500.0);
        Console.WriteLine($"John has {aCustomer.GetBalance()}$");
    }
}