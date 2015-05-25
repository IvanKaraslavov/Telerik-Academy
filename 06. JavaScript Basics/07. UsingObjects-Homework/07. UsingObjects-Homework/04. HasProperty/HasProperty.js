//Write a function that checks if a given object contains a given property.

function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}

var telerik = {
    firstName: "Telerik",
    lastName: "Ninja",
    age: 5
}

jsConsole.writeLine(hasProperty(telerik, "firstName"));
jsConsole.writeLine(hasProperty(telerik, "gender"));