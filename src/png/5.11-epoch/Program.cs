
long unixTime = 1788956795; // Arbitrary unix epoch timestamp.

// I hate this exercise :(

long year = 1970 + (unixTime / 60 / 60 / 24 / 365); // Current year
long day = unixTime / 60 / 60 / 24 - ((year - 1970) * 365); // Current day, close enough.
long month = day / 30; // Current month

Console.WriteLine("Unix timestamp: {0}", unixTime);
Console.WriteLine("---");
Console.WriteLine("Current year: {0}", year);
Console.WriteLine("Current month: {0}", month);
Console.WriteLine("Current day: {0}", day);
