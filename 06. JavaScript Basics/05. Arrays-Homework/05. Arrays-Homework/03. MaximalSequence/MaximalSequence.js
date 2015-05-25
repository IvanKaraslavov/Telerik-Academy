//Write a script that finds the maximal sequence of equal elements in an array.

function sequence(arr) {
    var localCounter = 1;
    var globalCounter = 1;
    var number = 0;
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] === arr[i + 1]) {
            localCounter++;
            if (i === arr.length - 2) {
                globalCounter = localCounter;
                number = i - localCounter + 2;
            }
        }
        else {
            if (localCounter > globalCounter) {
                globalCounter = localCounter;
                number = i - localCounter + 1;
            }

            localCounter = 1;
        }
    }
    var result = arr.slice(number, number + globalCounter);
    jsConsole.writeLine("From the array: [" + arr + "]");
    jsConsole.writeLine("The maximal sequence is: [" + result + "]");
    

}

sequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]);
sequence([3, 3, 3, 23, 54, 54, 54, 54]);
sequence([15, 12, 32, 22, 22, 4, 4, 4]);