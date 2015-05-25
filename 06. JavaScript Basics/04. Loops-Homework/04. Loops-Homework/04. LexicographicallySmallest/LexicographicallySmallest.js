//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function smallestAndLargestProperty(object) {
    var min = 0;
    var max = 0;
    jsConsole.writeLine(object + ": ");
    for (var property in object) {
        if (!min) {
            min = property;
        }
        if (!max) {
            max = property;
        }

        if (property < min) {
            min = property;
        }

        if (property > max) {
            max = property;
        }
    }

    jsConsole.writeLine("Min: " + min);
    jsConsole.writeLine("Max: " + max);
}
smallestAndLargestProperty(window);
smallestAndLargestProperty(navigator);
smallestAndLargestProperty(document);