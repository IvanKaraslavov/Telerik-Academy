//Write a script that compares two char arrays lexicographically (letter by letter).

function numbers(arr1, arr2) {
    if (arr1.length !== arr2.length) {
        jsConsole.writeLine("The two arrays have different length");
        jsConsole.writeLine("--END--");

    }
    else {

        for (var i = 0; i < arr1.length; i++) {
            if (arr1[i] < arr2[i]) {
                jsConsole.writeLine("The letter " + arr1[i] + " is lexicographically smaller than " + arr2[i] );
            }
            else if (arr1[i] > arr2[i]) {
                jsConsole.writeLine("The letter " + arr1[i] + " is lexicographically bigger than " + arr2[i]);
            }
            else {
                jsConsole.writeLine("The letter " + arr1[i] + " is lexicographically equal to " + arr2[i]);
            }
        }
        jsConsole.writeLine("--END--");
    }
    
}

numbers("Georgi", "Nikolay");
numbers("Hello", "Again");
numbers("Mima", "Gina");