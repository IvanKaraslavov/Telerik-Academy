//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

function pointLocation(x, y) {
    if (!x || !y) {
        return "Enter x and y";
    }
    if (isInTheCircle(x, y) && isOutsideTheRectangle(x, y)) {
        return "The point is in the circle and outside the rectangle.";
    } else {
        return "The point is NOT in the circle and outside the rectangle.";
    }
    
    
}

function isInTheCircle(x, y) {
    if ((x - 1) * (x - 1) + (y - 1) * (y - 1) < 3 * 3) {
        return true;
    } else {
        return false;
    }
}

function isOutsideTheRectangle(x, y) {
    if (x >= -1 && x <= 5 && y >= -1 && y <= 1) {
        return false;
    } else {
        return true;
    }
}

jsConsole.writeLine(pointLocation(2, 2));
jsConsole.writeLine(pointLocation(1, 1));