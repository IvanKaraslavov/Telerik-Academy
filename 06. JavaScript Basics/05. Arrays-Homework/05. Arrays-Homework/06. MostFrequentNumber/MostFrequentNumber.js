//Write a script that finds the most frequent number in an array.

function mostFrequent(arr) {
    var globalCounter = 0;
    var element = arr[0];
    for (var i = 0; i < arr.length; i++) {
        var localCounter = 0;
        for (var j = 0; j < arr.length; j++) {
            if (arr[i] === arr[j]) {
                localCounter++;
            }
        }

        if (localCounter > globalCounter) {
            globalCounter = localCounter;
            element = arr[i];
        }
    }

    jsConsole.writeLine("Most frequent number: " + element + " (" + globalCounter + " times)");
}

mostFrequent([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);