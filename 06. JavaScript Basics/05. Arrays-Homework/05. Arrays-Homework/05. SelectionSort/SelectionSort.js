//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

function selectionSort(arr) {
    var i, j, tmp, tmp2;
    for (i = 0; i < arr.length - 1; i++) {
        tmp = i;
        for (j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[tmp]) {
                tmp = j;
            }
        }
        if (tmp != i) {
            tmp2 = arr[tmp];
            arr[tmp] = arr[i];
            arr[i] = tmp2;
        }
    }
    arr = arr.join(", ")
    jsConsole.writeLine("Sorted array: " + arr);
}
selectionSort([4, 3, 6, 8, 9, 2, 11, 0, -4, -2, 18]);