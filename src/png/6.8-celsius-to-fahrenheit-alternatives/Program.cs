// I've already used for-loops in my solution to exercise 6.6
// So I am going to be using while-loops for this one.

double c = -5.0;
while (c <= 40.0) {
    double f = 32 + (9.0/5.0) * c;
    Console.WriteLine(c + " celsius to fahrenheit is: " + f);
    c += 0.5;
}
