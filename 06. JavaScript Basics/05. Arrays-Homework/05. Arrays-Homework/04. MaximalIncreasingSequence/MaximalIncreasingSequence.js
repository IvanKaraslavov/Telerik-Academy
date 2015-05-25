//Write a script that finds the maximal increasing sequence in an array.

function increase(arr) {
    var localCounter = 1;
    var globalCounter = 1;
    var number = 0;
    for (var i = 0; i < arr.length - 1; i++) {
        if (arr[i] === arr[i + 1] - 1) {
            localCounter++;
            if ( i === arr.length - 2) {
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
    jsConsole.writeLine("The maximal increasing sequence is: [" + result + "]");


}

increase([3, 2, 3, 4, 2, 2, 4]);
increase([1, 2, 3, 4, 5, 6, 7]);