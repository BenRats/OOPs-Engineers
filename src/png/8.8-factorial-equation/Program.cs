
int factorial(int num) {
    if (num == 1) {
        return num;
    }
    return num * factorial(num - 1);
}

Console.WriteLine($"Factorial of 4 is: {factorial(4)}");

if (factorial(4) == 24) {
    Console.WriteLine("Test passed! Factorial function is valid!");
}