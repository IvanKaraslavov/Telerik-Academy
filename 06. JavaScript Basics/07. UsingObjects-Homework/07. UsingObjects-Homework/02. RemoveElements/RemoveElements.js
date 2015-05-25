//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.

Array.prototype.remove = function (element) {
    for (var ind = 0; ind < this.length; ind++) {
        if (this[ind] === element) {
            this.splice(ind, 1);
            --ind;
        }
    }
    return this;
}

var arr = [1, 2, 3, 4, 1, 2, 3, 1, 5, 1, 2,];

jsConsole.writeLine(arr.join(', '));
arr.remove(1);
jsConsole.writeLine(arr.join(', '));