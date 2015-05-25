//Write a function that returns the last digit of given integer as an English word.

function findLastDigit(a) {
    jsConsole.write("The last digit as word from the number " + a + " is: "  );
    var digit = a % 10;
    switch (digit) {
        case 1:
            jsConsole.writeLine("one");
            break;
        case 2:
            jsConsole.writeLine("two");
            break;
        case 3:
            jsConsole.writeLine("three");
            break;
        case 4:
            jsConsole.writeLine("four");
            break;
        case 5:
            jsConsole.writeLine("five");
            break;
        case 6:
            jsConsole.writeLine("six");
            break;
        case 7:
            jsConsole.writeLine("seven");
            break;
        case 8:
            jsConsole.writeLine("eight");
            break;
        case 9:
            jsConsole.writeLine("nine");
            break;
        default:
            jsConsole.writeLine("zero")
    }
}
findLastDigit(512);
findLastDigit(1024);
findLastDigit(12309);