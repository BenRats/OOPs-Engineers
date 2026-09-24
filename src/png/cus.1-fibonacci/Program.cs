using System.Numerics;

BigInteger fib (int n) {
    if (n == 0) { return new BigInteger(0); }
    if (n == 1) { return new BigInteger(1); }

    var prev = new BigInteger(1);
    var prevprev = new BigInteger(0);
    for (var i = new BigInteger(2); i <= n; i++) {
        var temp = prev;
        prev = prev + prevprev;
        prevprev = temp;
    }

    return prev;
}

for (int n = 0; n < 10000 ; n++) {
    Console.WriteLine($"fib({n}) = {fib(n)}");
}