//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function binaryIndexOf(arr, searchElement) {

    var min = 0, max = arr.length - 1, answer = -1;
    while (min <= max) {
        var mid = min + (max - min) / 2;
        mid = Math.floor(mid);
        if (arr[mid] > searchElement) {
            max = mid - 1;
        }
        else if (arr[mid] < searchElement) {
            min = mid + 1;
        }
        else {
            answer = mid;
            break;
        }
    }
    jsConsole.writeLine("From the array: " + arr);
    jsConsole.writeLine("Index of element [" + searchElement + "] is " + answer);
    
}
binaryIndexOf([1, 2, 3, 4, 5, 6, 7, 8, 9, 10], 7);