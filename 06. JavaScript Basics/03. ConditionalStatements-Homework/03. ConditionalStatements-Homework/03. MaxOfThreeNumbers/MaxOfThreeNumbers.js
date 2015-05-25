//Write a script that finds the biggest of three numbers.
//Use nested if statements.

function showMax(a, b, c) {
    var message = "The greatest number is: ";
    if (a > b) {
        if (a > c) {
            jsConsole.writeLine(message + a);
        } else {
            jsConsole.writeLine(message + c);
        }
    } else {
        if (b > c) {
            jsConsole.writeLine(message + b);
        } else {
            jsConsole.writeLine(message + c);
        }
    }
}

showMax(3, 6, 9);
showMax(2, 4, 3);
showMax(100, 3, 86);