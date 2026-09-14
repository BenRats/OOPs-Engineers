//int date = 21816000;
double entryPrice = 599.95;
double rebate = 0.3;

bool isChristmas = false; // honor-based system :)

double price = entryPrice;
if (isChristmas) {
    Console.WriteLine("Applying Christmas rebate, Merry Christmas!");
    price = price * (1.0 - rebate);
}
Console.WriteLine("Price: " + price);

