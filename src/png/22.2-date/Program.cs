using System;

// This exercise was so poorly written, I'm sorry but it is!
// Are we meant to interpret 10^3 (and other timestamps) as milliseconds???
// or does he want us to interpret it as seconds and thus multiply it with 1000 first?
// I don't get it :(

class Program {
    public static void PrintTimeFromUnix(long a, long b) {
        var ts = (long) Math.Pow(a, b);
        var offset = System.DateTimeOffset.FromUnixTimeMilliseconds(ts);
        Console.WriteLine($"{a}^{b} ({ts}) in UNIX Epoch: {offset.DateTime.ToString()}");
    }
    
    public static void Main(string[] args) {
        Program.PrintTimeFromUnix(10, 3);
        Program.PrintTimeFromUnix(10, 4);
        Program.PrintTimeFromUnix(10, 5);
        Program.PrintTimeFromUnix(10, 6);
    }
}