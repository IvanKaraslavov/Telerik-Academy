//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

function getDigitName(digit) {
    var message = "The digit is: "
    switch (digit) {
        case 1:
            jsConsole.writeLine(message + 'one');
            break;
        case 2:
            jsConsole.writeLine(message + 'two');
            break;
        case 3:
            jsConsole.writeLine(message + 'three');
            break;
        case 4:
            jsConsole.writeLine(message + 'four');
            break;
        case 5:
            jsConsole.writeLine(message + 'five');
            break;
        case 6:
            jsConsole.writeLine(message + 'six');
            break;
        case 7:
            jsConsole.writeLine(message + 'seven');
            break;
        case 8:
            jsConsole.writeLine(message + 'eight');
            break;
        case 9:
            jsConsole.writeLine(message + 'nine');
            break;
        default:
            jsConsole.writeLine(message + 'zero');
            break;
    }
}

getDigitName(5);
getDigitName(7);
getDigitName(1);
getDigitName(9);