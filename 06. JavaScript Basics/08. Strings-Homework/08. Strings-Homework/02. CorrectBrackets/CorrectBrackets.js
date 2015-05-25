//Write a JavaScript function to check if in a given expression the brackets are put correctly.

function isCorrectExpression(expression) {
    var brackets = 0;

    for (var i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            brackets++;
        }
        else if (expression[i] === ')') {
            brackets--;
        }
    }
    jsConsole.writeLine(!brackets);
}

isCorrectExpression('(3+4) + (3-4)');
isCorrectExpression(')3+4) + (3-4)');