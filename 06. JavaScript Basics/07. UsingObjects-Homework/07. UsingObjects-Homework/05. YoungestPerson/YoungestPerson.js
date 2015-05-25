//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

function Person(firstname, lastname, age) {

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
}

Person.prototype.toString = function () {
    return this.firstname + ' ' + this.lastname;
};

function youngestPerson(people) {
    var youngest = people[0];
    for (var i = 0; i < people.length; i++) {
        if (youngest.age > people[i].age) {
            youngest = people[i];
        }

    }
    jsConsole.writeLine(youngest.toString());
}

var people = [
  new Person('Gosho', 'Petrov', 32),
   new Person('Ivan', 'Ivanov', 18),
   new Person('Petur', 'Petrov', 67),
   new Person('Pesho', 'Peshov', 44),
   new Person('Telerik', 'Ninja', 15)
];

youngestPerson(people);