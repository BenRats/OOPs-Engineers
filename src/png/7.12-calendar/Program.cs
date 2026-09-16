int[] daysInMonth = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] daysInLeapMonth = daysInMonth;
daysInLeapMonth[1] = 29;

for (int year = 2000; year <= 2020; year++) {
    int[] pointer = (year % 4 == 0 ? daysInLeapMonth : daysInMonth);

    Console.WriteLine("Year " + year + " has the following days per month: ");
    int month = -1;
    foreach (int days in pointer) {
        month++;
        // Cast from int to enum, then to string with ToString() method
        string monthName = ((Month) month).ToString();
        Console.WriteLine($"\t{monthName} (month {month + 1}) has {days} days.");
    }
}

enum Month {
    January, February, March, April, May, June, July, August, September, October, November, December
};