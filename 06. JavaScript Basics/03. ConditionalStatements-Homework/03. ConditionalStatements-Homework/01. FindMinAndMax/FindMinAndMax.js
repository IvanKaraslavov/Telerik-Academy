//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

function reverse(a, b) {
    if (!a || !b) {
        return "Enter the two values";
    }
    jsConsole.writeLine("Initial values: a = " + a + ", b = " + b);
    var greater = a > b;
    jsConsole.writeLine("Is a greater than b -> " + greater);
    if (a < b) {
        var c = a;
        a = b;
        b = c;
        jsConsole.writeLine("Reversed: a = " + a + ", b = " + b);
        jsConsole.writeLine("----------");
    }
}

reverse(3,5);
reverse(1, 50);
reverse(27, 9);