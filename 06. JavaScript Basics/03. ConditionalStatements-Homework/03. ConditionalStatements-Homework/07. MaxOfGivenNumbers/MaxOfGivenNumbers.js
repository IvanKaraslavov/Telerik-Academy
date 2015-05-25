//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

function findGreatest(a, b, c, d, e) {
    var array = [a, b, c, d, e],
        greatest = array[0];

    for (var i = 1; i < array.length; i++) {
        if (array[i] > greatest) {
            greatest = array[i];
        }
    }
    jsConsole.writeLine("The greatest number is: " + greatest);
}

findGreatest(1, 4, 7, 2, 9);
findGreatest(12, 45, 89, 75, 90);
findGreatest(124, 478, 358, 402, 161);