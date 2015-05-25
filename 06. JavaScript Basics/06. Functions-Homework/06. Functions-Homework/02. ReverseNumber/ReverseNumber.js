//Write a function that reverses the digits of given decimal number.

function reverse(a)
{
    jsConsole.write("The reversed digit of the number " + a + " are: ");
    var result = 0;
    while(a){
        result = result * 10 + a % 10;
        a = Math.floor(a / 10);
    }
    jsConsole.writeLine(result);
}
reverse(256);