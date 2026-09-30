using System.Numerics;
using System;

double discriminant(double a, double b, double c) {
    // See: https://en.wikipedia.org/wiki/Discriminant
    return (b * b) - 4.0 * a * c;
}

double[] roots_complex(double a, double b, double c) {
    Double[] result = new double[2];

    // See: https://en.wikipedia.org/wiki/Quadratic_function#Roots_of_the_univariate_function

    // Using Math.Sqrt() doesn't work for negative discriminants.
    // It returns NaN, so we have to use the Complex number structure.
    Complex disc = new Complex(discriminant(a, b, c), 0);
    disc = Complex.Sqrt(disc);

    Complex negativeB = new Complex(b * -1, 0);
    Complex twoA = new Complex(2 * a, 0);
    
    Complex rootOne = (negativeB - disc) / twoA;
    Complex rootTwo = (negativeB + disc) / twoA;

    result[0] = rootOne.Real;
    result[1] = rootTwo.Real;

    return result;
}

double[] roots_real(double a, double b, double c) {
    double[] result = new double[2];
    result[0] = ((b * ((double) -1.0)) - Math.Sqrt(discriminant(a, b, c))) / ((double) 2) * a;
    result[1] = ((b * ((double) -1.0)) + Math.Sqrt(discriminant(a, b, c))) / ((double) 2) * a;
    return result;
}

double[] roots(double a, double b, double c) {
    // Use roots_complex(a, b, c) if Math.Sqrt(discriminant(a, b, c)) is NaN
    // Use roots_real(a, b, c) otherwise
    return Double.IsNaN(Math.Sqrt(discriminant(a, b, c))) ? roots_complex(a, b, c) : roots_real(a, b, c);
}

// 5x^2 + 3x + 10
double a = (double) 5.0;
double b = (double) 3.0;
double c = (double) 10.0;

Console.WriteLine($"Chosen polynomial: {a}x^2 + {b}x + {c}");

double polyDiscriminant = discriminant(a, b, c);
double[] polyRoots = roots(a, b, c);

Console.WriteLine($"Discriminant: {polyDiscriminant}");
Console.WriteLine("Roots:");
Console.WriteLine($"\t1: {polyRoots[0]}");
Console.WriteLine($"\t2: {polyRoots[1]}");