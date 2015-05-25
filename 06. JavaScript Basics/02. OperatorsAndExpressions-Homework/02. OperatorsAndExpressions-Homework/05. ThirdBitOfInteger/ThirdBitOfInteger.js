//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

function thirdBit(number) {
    if ((number >> 3) & 1) {
        jsConsole.writeLine("The bit is: " + 1)
    } else {
        jsConsole.writeLine("The bit is: " + 0)
    }
}

thirdBit(31);
thirdBit(50);
thirdBit(1);
thirdBit(15);
thirdBit(16);