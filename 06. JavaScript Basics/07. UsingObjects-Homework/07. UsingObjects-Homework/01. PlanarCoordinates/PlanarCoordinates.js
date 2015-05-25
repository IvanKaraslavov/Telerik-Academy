//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function calculateDistance(x1, y1, x2, y2) {
    var result = Math.sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
    jsConsole.writeLine("The distance between the points [" + x1 + ", " + y1 + "] and [" + x2 + ", " + y2 + "] is " + result);
}

function formATriangle(x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6) {
    var line1 = calculateDistance(x1, y1, x2, y2);
    var line2 = calculateDistance(x3, y3, x4, y4);
    var line3 = calculateDistance(x5, y5, x6, y6);

    if ((line1 + line2 > line3 && line2 + line3 > line1 && line1 + line3 > line2)) {
        jsConsole.writeLine("The three lines CAN form a triangle.");
    }
    else {
        jsConsole.writeLine("The three lines CANNOT form a triangle.");
    }
}

formATriangle(3, 5, -1, 4, 2, 5, 8, 2, 9, 1, 0, 5);