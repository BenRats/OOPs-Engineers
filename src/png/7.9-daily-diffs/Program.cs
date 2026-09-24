double[] temps = [
    21.5,
    23.7,
    19.6,
    22.5,
    25.3,
    21.7,
    18.9
];

string getDayName(int i) {
    string result = "";
    switch (i) {
        case 0:
			result = "Monday";
            break;
        
		case 1:
			result = "Tuesday";
            break;
			
        case 2:
			result = "Wednesday";
            break;
			
        case 3:
			result = "Thursday";
            break;
			
        case 4:
			result = "Friday";
            break;
			
        case 5:
			result = "Saturday";
            break;
			
        case 6:
			result = "Sunday";
            break;
			
		default:
			result = "Unknown";
			break;
    }

    return result;
}

for (int i = 0; i < temps.Length; i++) {
    var prevIndex = i - 1;
    if (i == 0) {
        prevIndex = temps.Length - 1; // 6
    }

    Console.WriteLine($"{getDayName(prevIndex)}-{getDayName(i)}: {temps[prevIndex] - temps[i]}");
}