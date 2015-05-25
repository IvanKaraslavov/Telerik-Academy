//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

function appearance(arr, number) {
    var times = 0;
    for (var i = 0; i < arr.length; i++) {
        if (number === arr[i]) {
            times++;
        }
    }
    jsConsole.writeLine("Тhe number " + number + " appears " + times + " times in the array [" + arr + "]");
    
}

appearance([3, 4, 5, 6, 8, 2, 6, 8], 8);