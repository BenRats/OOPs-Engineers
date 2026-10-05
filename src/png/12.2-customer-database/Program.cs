// I think this is what the exercise means by "Main" method???
public class Customer {
    public int id;
    public string name;
    public double balance; // Probably good to set this to "private"

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

public class CustomerDatabase {
    private Customer[] customers;

    public CustomerDatabase() {
        customers = new Customer[10];
    }

    public void Insert(Customer customer) {
        var flag = true;
        
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] == null) {
                customers[i] = customer;
                flag = false;
                break;
            }
        }

        if (flag) {
            throw new Exception("No size left for new customers in customer database.");
        }
    }

    public void RemoveCustomerWithId(int id) {
        for (int i = 0; i < customers.Length; i++) {
            // Skip if null customer.
            if (customers[i] == null) {
                continue;
            }
            
            if (customers[i].id == id) {
                customers[i] = null; // Just set to null.
            }
        }
    }

    public Customer[] GetCustomers() {
        return customers;
    }

    public void PrintCustomers() {
        for (int i = 0; i < customers.Length; i++) {
            if (customers[i] == null) {
                Console.WriteLine("Customer: null");
            } else {
                Console.WriteLine("Customer:");
                Console.WriteLine($"\tID: {customers[i].id}");
                Console.WriteLine($"\tName: {customers[i].name}");
                Console.WriteLine($"\tBalance: {customers[i].balance}");
            }
            Console.WriteLine("");
        }
    }
}

class Program {
    public static void Main(string[] args) {
        CustomerDatabase db = new CustomerDatabase();

        db.Insert(new Customer("John",    0,  100.0));
        db.Insert(new Customer("Jane",    1,  1000.0));
        db.Insert(new Customer("Kate",    2,  65535.0));
        db.Insert(new Customer("Mark",    3,  409.0));
        db.Insert(new Customer("Luke",    4,  256.0));
        db.Insert(new Customer("Caryl",   5,  101.25));
        db.Insert(new Customer("Glenda",  6,  675.0));
        db.Insert(new Customer("Miku",    7,  245.0));
        db.Insert(new Customer("Rachell", 8,  305.5));

        // Remove three customers.
        db.RemoveCustomerWithId(4);
        db.RemoveCustomerWithId(6);
        db.RemoveCustomerWithId(7);

        db.PrintCustomers();
    }
}