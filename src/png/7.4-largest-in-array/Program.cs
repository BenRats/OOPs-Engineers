int[] numbers = [42,543,34,6,8,70,675,453,603,684,432,543,34,2,5,7,8,756,4,787,654,3345,676,654,7,8,7654,8,754,78,76543];

int highestNum = 0;
foreach (int num in numbers) {
    if (num > highestNum) {
        highestNum = num;
    }
}

Console.WriteLine(highestNum);