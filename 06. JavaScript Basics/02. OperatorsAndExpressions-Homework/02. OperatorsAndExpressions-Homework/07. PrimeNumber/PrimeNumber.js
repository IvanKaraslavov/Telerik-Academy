//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

function isPrime(number) {
    if (number % 1 || number < 2) {
        return false;
    } else if (number % 2 == 0) {
        return (number == 2);
    }
    var m = Math.sqrt(number);
    for (var i = 3; i <= m; i += 2) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}

jsConsole.writeLine(isPrime(37));
jsConsole.writeLine(isPrime(1));
jsConsole.writeLine(isPrime(3));
jsConsole.writeLine(isPrime(5));
jsConsole.writeLine(isPrime(15));