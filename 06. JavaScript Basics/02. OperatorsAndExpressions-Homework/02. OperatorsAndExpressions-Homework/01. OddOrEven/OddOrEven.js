//Write an expression that checks if given integer is odd or even.

function oddOrEven(number) {
    if (number % 2 === 0) {
        jsConsole.writeLine("The number is even.");
    } else {
        jsConsole.writeLine("The number is odd.");
    }
}

oddOrEven(2);
oddOrEven(255);
oddOrEven(312);
oddOrEven(567);
oddOrEven(123456);
oddOrEven(11111);
oddOrEven(12);
oddOrEven(90);
oddOrEven(77);
oddOrEven(11);
