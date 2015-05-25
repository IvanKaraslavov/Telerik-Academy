//Write an expression that calculates rectangle’s area by given width and height.

function calculateArea(width, height) {
    if (!width || !height) {
        throw "enter a number";
    }
    var area = width * height;
    return "The area of the rectangle is: " + area;
}

jsConsole.writeLine(calculateArea(3, 5));
jsConsole.writeLine(calculateArea(5, 5));
jsConsole.writeLine(calculateArea(10, 5));
jsConsole.writeLine(calculateArea(8, 2));
jsConsole.writeLine(calculateArea(50, 3));
jsConsole.writeLine(calculateArea(20.3, 9));
jsConsole.writeLine(calculateArea(6, 7));
jsConsole.writeLine(calculateArea(11111, 22222));