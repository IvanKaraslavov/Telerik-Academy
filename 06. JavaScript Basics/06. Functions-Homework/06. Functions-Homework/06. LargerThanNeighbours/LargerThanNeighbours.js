//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours 
//(when such exist).

function largerThanNeighbours(arr, position) {
    for (var i = 0; i < arr.length; i++) {
        if (position <= 0 || position >= arr.length - 1) {
            jsConsole.writeLine("Please take another element's position.");
            break;
        }
        else {
            if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1]) {
                jsConsole.writeLine("True");
                break;
            }
            else {
                jsConsole.writeLine("False");
                break;
            }
        }
    }
}

largerThanNeighbours([1, 2, 8, 6, 89, 2, 5, 3, 1], 6);