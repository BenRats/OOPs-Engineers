using System;

for (int i = 1; i <= 5; i += 2) {
    double area = 3.14159 * (i * i); // (i * i) is my way of doing r^2
    Console.WriteLine("Area of circle with radius " + i + " is " + area);
}
