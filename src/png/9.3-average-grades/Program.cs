int[] grades = [4, 7, 2, 0, 10, 4, 12]; // 00 and 02 -> 0 and 2.

int GetGrade(int courseid) {
    int grade = grades[courseid];
    if (grade >= 2) {
        return grade;
    } else {
        throw new Exception($"Failed grade for course: {courseid}");
    }
}

int count = 0;
int sum = 0;
for (int courseid = 0; courseid < grades.Length; courseid++) {
    try {
        int grade = GetGrade(courseid);
        
        count += 1;
        sum += grade;
    } catch (Exception) {
        Console.WriteLine($"Skipping over course {courseid + 1} since it's a failed course.");
    }
}

Console.WriteLine($"Average grade: {sum/count}");