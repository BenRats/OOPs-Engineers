// C# executes statement in the order they're put,
// it's a statement-by-statement language just like most other languages out there.
// So the first line defines a `double` variable named price with the value of 599.95
// the second line thereafter defines yet another `double` variable named budget with the value of 1000.0
// the third line defines a boolean variable named requiredReading, it is set to true.
// the fourth line defines a boolean variable named shouldBuy,
// the value of it is found by checking if price is less than budget and if requiredReading is true.
// This gets evaluated into true, since all the conditions pass, and so shouldBuy is set to true.
//
// We can infer that this bit of code represents an algorithm for how someone might purchase books,
// they check first if they can afford it (if price is less than budget), and then if
// it's a booked listed as "required reading"
// 
// If both of these conditions are true, then the person should buy the book.
double price = 599.95;
double budget = 1000.0;
bool requiredReading = true;
bool shouldBuy = price < budget && requiredReading