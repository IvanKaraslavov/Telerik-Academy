//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function checkDigit(number) {
    if (Math.floor(number / 100) % 10 === 7) {
        return true;
    } else {
        return false;
    }
}

jsConsole.writeLine(checkDigit(1776));
jsConsole.writeLine(checkDigit(30000000));
jsConsole.writeLine(checkDigit(4567890765));
jsConsole.writeLine(checkDigit(3456789977));
jsConsole.writeLine(checkDigit(127));
jsConsole.writeLine(checkDigit(7777));