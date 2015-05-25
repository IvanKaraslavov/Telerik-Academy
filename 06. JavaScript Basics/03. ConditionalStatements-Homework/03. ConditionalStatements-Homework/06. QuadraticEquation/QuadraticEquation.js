//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
//(prints its real roots).
//Calculates and prints its real roots.

function quadraticEquation(a, b, c) {
    var d = b * b - 4 * a * c;
       if (a === 0) {
        jsConsole.writeLine('x = ' + (-c / b));
    } else {
        if (d < 0) {
            jsConsole.writeLine('no real roots');
        } else if (d === 0) {
            jsConsole.writeLine('x1 = x2 = ' + ((-b) / (2 * a)));
        } else {
            jsConsole.writeLine('x1 = ' + ((-b - Math.sqrt(d))) / (2 * a));
            jsConsole.writeLine('x2 = ' + ((-b + Math.sqrt(d))) / (2 * a));
        }
    }
}

quadraticEquation(0, 3, 6);
quadraticEquation(2, 2, 2);
quadraticEquation(10, 53, 21);
quadraticEquation(1, 4, 16);