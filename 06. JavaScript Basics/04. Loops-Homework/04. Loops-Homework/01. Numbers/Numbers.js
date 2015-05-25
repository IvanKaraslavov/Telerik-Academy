//Write a script that prints all the numbers from 1 to N.

function numbers(a) {
    if (!a) {
        return "Enter the value";
    }
    for (var i = 1; i <= a; i++) {
        jsConsole.writeLine(i);
    }
    jsConsole.writeLine("--END--");
    
}

numbers(5);
numbers(3);
numbers(7);