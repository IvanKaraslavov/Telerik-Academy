//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function divisionBy7And5(number)
{
    if (number % 5 === 0 && number % 7 === 0) { //number % 35 === 0
        return true;
    } else {
        return false;
    }
}

jsConsole.writeLine(divisionBy7And5(35));
jsConsole.writeLine(divisionBy7And5(7));
jsConsole.writeLine(divisionBy7And5(5));
jsConsole.writeLine(divisionBy7And5(21));
jsConsole.writeLine(divisionBy7And5(15));
jsConsole.writeLine(divisionBy7And5(350));
jsConsole.writeLine(divisionBy7And5(1));