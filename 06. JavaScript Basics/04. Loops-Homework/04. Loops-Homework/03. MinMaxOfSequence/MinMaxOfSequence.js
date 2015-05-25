//Write a script that finds the max and min number from a sequence of numbers.

function minAndMax(numbers) {

    var minIndex = 0;
    var maxIndex = 0;

    for (var index = 0; index < numbers.length; index++) {
        if (numbers[maxIndex] < numbers[index]) maxIndex = index;
        if (numbers[index] < numbers[minIndex]) minIndex = index;
    }
    jsConsole.writeLine("Max: " + numbers[maxIndex]);
    jsConsole.writeLine("Min: " + numbers[minIndex]);
}

minAndMax([33, 56, 98, 0, 4, -1, 76, 87]);