using System;

int userMonth;

Console.Write("Type a month from 1 to 12: ");
Int32.TryParse(Console.ReadLine(), out userMonth);

// basic checks first
if (userMonth < 1 || userMonth > 12) {
    Console.WriteLine("Invalid month, must be from 1 to 12!");
    Environment.Exit(0);
}

switch (userMonth) {
    case 4:
        Console.WriteLine("Spring Holiday!");
        break;

    case 7:
        Console.WriteLine("Summer Holiday!");
        break;

    case 8:
        Console.WriteLine("Summer Holiday!");
        break;
        
    case 10:
        Console.WriteLine("Autumn Holiday!");
        break;

    default:
        Console.WriteLine("Hard work");
        break;
}