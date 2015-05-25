//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups

function Person(firstname, lastname, age) {

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
}

Person.prototype.toString = function () {
    return '(' + this.firstname + ' ' + this.lastname + ',' + this.age + ')';
};

var people = [
    new Person('Gosho', 'Petrov', 32),
   new Person('Ivan', 'Ivanov', 18),
   new Person('Petur', 'Petrov', 67),
   new Person('Pesho', 'Peshov', 44),
   new Person('Telerik', 'Ninja', 15)
];

function group(arr, prop) {
    var group = [];

    for (var ind in arr) {
        var currProp = arr[ind][prop];
        group[currProp] = group[currProp] || [];
        group[currProp].push(arr[ind]);
    }

    return group;
}

function printGroups(prop, arr) {
    jsConsole.writeLine(prop);
    for (var key in arr) {
        jsConsole.writeLine(arr[key].join('; '));
    }
}

var props = ['firstname', 'lastname', 'age'];

for (var ind in props) {
    var groups = group(people, props[ind]);
    printGroups(props[ind], groups);
}