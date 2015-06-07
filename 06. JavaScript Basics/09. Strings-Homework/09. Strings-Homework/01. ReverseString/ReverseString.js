//Write a JavaScript function that reverses a string and returns it.

function reverse(text)
{
    var result = text.split('').reverse().join('');
    jsConsole.writeLine(result);
}

reverse('sample');