// For the sudoku checker, we can use a multidimensional array
// We only need to hold a filled out one.
int[,] puzzle = {
    {6, 2, 3, 8, 5, 4, 7, 1, 9},
    {8, 9, 7, 2, 3, 1, 4, 5, 6},
    {1, 5, 4, 6, 9, 7, 2, 8, 3},
    {5, 1, 6, 4, 2, 3, 9, 7, 8},
    {7, 4, 2, 9, 1, 8, 6, 3, 5},
    {9, 3, 8, 5, 7, 6, 1, 2, 4},
    {3, 7, 9, 1, 4, 5, 8, 6, 2},
    {2, 6, 1, 3, 8, 9, 5, 4, 7},
    {4, 8, 5, 7, 6, 2, 3, 9, 1}
};

// A sudoku puzzle is valid if:
//   rows don't contain duplicate numbers and contain all numbers from 1 to 9.
//   columns don't contain duplicate numbers and contain all numbers from 1 to 9.
//   all 3 by 3 groups don't contain duplicate numbers and contain all numbers from 1 to 9.

// The first two are easy enough to implement, the third one might be more difficult.

