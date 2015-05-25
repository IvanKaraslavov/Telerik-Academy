//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

function showSign(a, b, c) {
    var message = "The sign is: ";
    if (a > 0 && b > 0 && c > 0) {
        jsConsole.writeLine(message + '+');
    } else if (a < 0 && b < 0 && c < 0) {
        jsConsole.writeLine(message + '-');
    } else if (a > 0 && b > 0 && c < 0) {
        jsConsole.writeLine(message + '-');
    } else if (a > 0 && b < 0 && c < 0) {
        jsConsole.writeLine(message + '+');
    } else if (a > 0 && b < 0 && c > 0) {
        jsConsole.writeLine(message + '-');
    } else if (a < 0 && b > 0 && c > 0) {
        jsConsole.writeLine(message + '-');
    } else if (a < 0 && b > 0 && c < 0) {
        jsConsole.writeLine(message + '+');
    } else {
        jsConsole.writeLine(message + '+');
    }
}

showSign(2, 3, 4);
showSign(-1, 10, 3);
showSign(-1, -8, 9);