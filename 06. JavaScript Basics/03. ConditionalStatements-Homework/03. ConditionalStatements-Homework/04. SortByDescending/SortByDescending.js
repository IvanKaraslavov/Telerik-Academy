//Sort 3 real values in descending order.
//Use nested if statements.

function showOrdered(a, b, c) {
    var message = "Sort by descending: ";
    if (a > b) {
        if (a > c) {
            if (b > c) {
                jsConsole.writeLine(message + a + ', ' + b + ', ' + c);
            } else {
                jsConsole.writeLine(message + a + ', ' + c + ', ' + b);
            }
        } else {
            jsConsole.writeLine(message + c + ', ' + a + ', ' + b);
        }
    } else {
        if (b > c) {
            if (a > c) {
                jsConsole.writeLine(message + b + ', ' + a + ', ' + c);
            } else {
                jsConsole.writeLine(message + b + ', ' + c + ', ' + a);
            }
        } else {
            jsConsole.writeLine(message + c + ', ' + b + ', ' + a);
        }
    }
}

showOrdered(1, 2, 3);
showOrdered(100, 50, 200);
showOrdered(90, 10000, 3);