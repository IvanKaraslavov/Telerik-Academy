//Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

function pointInsideACircle(x, y) {
    if ((x * x) + (y * y) < 5 * 5) {
        return "The point is inside the circle.";
    } else {
        return "The point is outside the circle";
    }
}

jsConsole.writeLine(pointInsideACircle(0, 0));
jsConsole.writeLine(pointInsideACircle(5.1, 5.1));
jsConsole.writeLine(pointInsideACircle(2, 2));
jsConsole.writeLine(pointInsideACircle(100, 100));