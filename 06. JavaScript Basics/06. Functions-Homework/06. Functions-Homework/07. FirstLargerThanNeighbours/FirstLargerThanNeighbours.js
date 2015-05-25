//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, 
//if there’s no such element.
//Use the function from the previous exercise.

function largerThanNeighbours(arr) {
    var found;
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            jsConsole.writeLine("In the array [" + arr + "] The first found element is " + arr[i] + " with an index: " + i);
            found = true;
            break;
        }
    }
    if (!found) {
       jsConsole.writeLine("There is no such element.");
    }
}

largerThanNeighbours([1, 2, 8, 6, 89, 2, 5, 3, 1]);
largerThanNeighbours([1, 1, 1, 1, 1]);