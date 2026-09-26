int[] accounts = {903, 716, 67};

int GetAccountNumber () {
    Console.WriteLine("Enter an account number: ");
    return Convert.ToInt32(Console.ReadLine());
}

void PrintAccountState (int accountId) {
    // I modify the code here to add a try-catch block
    // this is to catch array boundary errors (IndexOutOfRangeException)
    try {    
        Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
    } catch (Exception e) {
        Console.WriteLine("Caught exception: Account with user's specified ID doesn't exist!");
    }
}

while (true) {
    // I add a try-catch block here to catch any invalid input
    // 
    // Adding it in GetAccountNumber(); doesn't make any sense,
    // since we're calling this function and we wanna catch any errors it throws.
    // So it makes no sense to add a try-catch to catch the exception by Convert.ToInt32()
    // because we'd have to throw it *again*, we can just catch it here instead.
    try {
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    } catch (Exception e) {
        Console.WriteLine("Caught exception: User wrote invalid account ID!");
    }
}