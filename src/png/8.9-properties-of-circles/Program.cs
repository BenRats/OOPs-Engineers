int[] circles = [1, 3, 5];

double area(int r) {
    // pi * r^2
    return ((double) 3.14159) * ((double) r) * ((double) r);
}

double circumference(int r) {
    // 2 * pi * r
    return ((double) 2) * ((double) 3.14159) * ((double) r);
}

for (int i = 0; i < circles.Length; i++) {
    Console.WriteLine($"Circle {i + 1}:");
    Console.WriteLine($"\tArea: {area(circles[i])}");
    Console.WriteLine($"\tCircumference:{circumference(circles[i])}");
}