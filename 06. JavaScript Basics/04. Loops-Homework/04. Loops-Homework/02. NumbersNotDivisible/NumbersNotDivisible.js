//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

function numbers(a) {
    if (!a) {
        return "Enter the value";
    }
    for (var i = 1; i <= a; i++) {
        if (i % 21 !== 0) { 
            if (i == a) {
                jsConsole.write(i);
            }
            else {
                jsConsole.write(i + ", ");
            }
           
        }
    }
    jsConsole.writeLine("--END--");

}

numbers(14);
numbers(27);
numbers(45);