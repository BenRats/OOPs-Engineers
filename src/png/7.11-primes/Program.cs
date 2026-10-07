// Ehhh idk what this is tbh
const int n = 1000000; // Max number to find primes in.

for (int i = 2; i <= n; i++) {
    var isPrime = true;
    for (int j = 2; j * j <= i; j++) {
        if (i % j == 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        Console.WriteLine($"{i} is prime.");
    }
}
