using System;

var rnd = new Random();
int diceRoll = rnd.Next(1, 6);
bool biggerThan2 = (diceRoll >= 3 ? true : false);

Console.WriteLine("Dice roll: " + diceRoll);
Console.WriteLine("Bigger than 2? " + biggerThan2);