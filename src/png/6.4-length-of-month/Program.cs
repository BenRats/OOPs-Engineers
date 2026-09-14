int month = 1; // set your month here

int days = 0;
string name = "";
switch (month) {
    case 1:
        days = 31;
        name = "January";
        break;
    case 2:
        days = 28;
        name = "February";
        break;
    case 3:
        days = 31;
        name = "March";
        break;
    case 4:
        days = 30;
        name = "April";
        break;
    case 5:
        days = 31;
        name = "May";
        break;
    case 6:
        days = 30;
        name = "June";
        break;
    case 7:
        days = 31;
        name = "July";
        break;
    case 8:
        days = 31;
        name = "August";
        break;
    case 9:
        days = 30;
        name = "September";
        break;
    case 10:
        days = 31;
        name = "October";
        break;
    case 11:
        days = 30;
        name = "November";
        break;
    case 12:
        days = 31;
        name = "December";
        break;
    default:
        Console.WriteLine("Not a month: " + month);
        Environment.Exit(1);
        break;
}

Console.WriteLine("Number of days in " + name + " is " + days);