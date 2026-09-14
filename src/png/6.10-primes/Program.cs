
for (int num = 0; num < 1000000; num++) {
    bool is_prime = true;

    // I couldn't grok the exercise itself,
    // so I decided to look online for any algorithms or ideas
    // Source: https://stackoverflow.com/a/15743249
    
    if (num == 1 || num == 2) {
        Console.WriteLine(num + " is prime!");
        continue;
    }

    var limit = Math.Ceiling(Math.Sqrt(num));
    for (int i = 2; i <= limit; i++) {
        if (num % i == 0) {
            is_prime = false;
        }
    }

    if (is_prime)
        Console.WriteLine(num + " is prime!");
    // just don't print non-prime numbers...
    // Best hack ever: Use ternary operators for strings.
    //Console.WriteLine(num + (is_prime ? " is prime!" : " is not prime!"));
}
