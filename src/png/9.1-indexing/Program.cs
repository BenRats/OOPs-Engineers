int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};

// increment
for (int i=0 ; i<iterationer ; i++) {
    // IndexOutOfRangeException is thrown here, due to the fact we access 5 (and higher)
    // which doesn't exist.
    // Or, well, it used to before I did the rest of the exercise added a try-catch block.
    try {
        array[i]++; 
    } catch (Exception e) {
        Console.WriteLine("Skipping over index error: " + e);
    }
    // Using a try-catch here isn't really good because we can easily
    // re-write the for loop to use array.Length thus preventing the index error here
    // at the root cause.
    // 
    // In a situation where we did not have this degree of control, then this *maybe* could've been
    // a decent solution.
}

// print
for (int i=0 ; i<array.Length ; i++) {
    Console.WriteLine(array[i]);
}