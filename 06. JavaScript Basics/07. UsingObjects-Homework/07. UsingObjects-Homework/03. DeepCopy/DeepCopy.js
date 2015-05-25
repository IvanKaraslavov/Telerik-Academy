//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

function clone(obj) {
    if (typeof obj !== 'object') {
        return obj;
    }

    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }

    console.log(cloned);
}
clone(11);
clone("String");
var telerik = {
    firstName: "Telerik",
    lastName: "Ninja",
    age: 5
}
clone(telerik);