Weekday nextWeekday(Weekday previous) {
    // Converts previous weekday into the next weekday,
    // rolls over to monday.
    if ((int) previous == 6) {
        return Weekday.Monday;
    } else {
        return (Weekday) ((int) previous + 1);
    }
}

int daysInMonth(MonthName month) {
    switch (month) {
        case MonthName.January:
            return 31;
        case MonthName.February:
            return 28;
        case MonthName.March:
            return 31;
        case MonthName.April:
            return 30;
        case MonthName.May:
            return 31;
        case MonthName.June:
            return 30;
        case MonthName.July:
            return 31;
        case MonthName.August:
            return 31;
        case MonthName.September:
            return 30;
        case MonthName.October:
            return 31;
        case MonthName.November:
            return 30;
        case MonthName.December:
            return 31;
        default:
            return 0;
    }
}

Calendar makeCalendar(int year) {
    Calendar result = new Calendar{ year = year, months = new Month[12]};
    var prevWeekday = Weekday.Sunday;

    // Make months first
    for (int i = 0; i < 12; i++) {
        // get month name
        MonthName currentMonth = (MonthName) i;
        int daysToMake = daysInMonth(currentMonth);
        result.months[i] = new Month{name = currentMonth, days = new Weekday[daysToMake]};
        for (int day = 0; day < daysToMake; day++) {
            prevWeekday = nextWeekday(prevWeekday);
            result.months[i].days[day] = prevWeekday;
        }
    }

    return result;
}

void prettyPrintCalendar(Calendar cal) {
    Console.WriteLine(cal.year);
    foreach (Month month in cal.months) {
        Console.WriteLine($"\t{month.name.ToString()}");
        for (int i = 0; i < month.days.Length; i++) {
            Console.WriteLine($"\t\tDay {i} is {month.days[i].ToString()}");
        }
    }
}

Calendar cal2026 = makeCalendar(2026);
prettyPrintCalendar(cal2026);

enum Weekday {
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

enum MonthName {
    January, February, March, April, May, June, July, August, September, October, November, December
}

class Month {
    public MonthName name;
    public Weekday[]? days;
}

class Calendar {
    public int year;
    public Month[]? months;
}