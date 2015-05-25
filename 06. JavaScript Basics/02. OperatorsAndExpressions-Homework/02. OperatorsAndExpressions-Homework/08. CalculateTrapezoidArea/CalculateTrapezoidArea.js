//Write an expression that calculates trapezoid's area by given sides a and b and height h.

function calculateArea(a, b, h) {
    var message = "The area of the trapezoid is ";
    if (!a || !b || !h) {
        return "Please enter the two sides and the height.";
    }
    var area = ((a + b) / 2) * h;
    return message + area;
}

jsConsole.writeLine(calculateArea(2, 3, 4));
jsConsole.writeLine(calculateArea(5, 8, 13));
jsConsole.writeLine(calculateArea(10, 10, 10));
jsConsole.writeLine(calculateArea(5.2, 3.3, 4.8));