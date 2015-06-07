//Write a function that finds the youngest male person in a given array of people and prints his full name
//Use only array methods and no regular loops (for, while)
//Use Array#find

var people = createPeople();

function createPerson(fname, lname, age, gender) {
    return {
        firstname: fname,
        lastname: lname,
        age: age,
        gender: gender
    };
}

function createPeople() {
    var i,
        firstNames = ['Asen', 'Angel', 'Boris', 'Georgi', 'Marin', 'Ana', 'Eli', 'Elena', 'Gergana', 'Mariika'],
        lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Georgiev', 'Nikolov', 'Borisova', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
        arr = [];
    for (i = 0; i < 10; i += 1) {
        arr[i] = createPerson(firstNames[i], lastNames[i], (Math.random() * 80) | 0, (i > 4));
    }
    return arr;
}

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

var youngestMale =
    people.sort(function (a, b) {
        return a.age - b.age;
    }).find(function (item) {
        return !item.gender;
    });

console.log(youngestMale.firstname, youngestMale.lastname);