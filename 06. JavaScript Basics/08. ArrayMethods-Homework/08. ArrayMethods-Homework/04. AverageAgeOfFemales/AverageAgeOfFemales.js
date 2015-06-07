//Write a function that calculates the average age of all females, extracted from an array of persons
//Use Array#filter
//Use only array methods and no regular loops (for, while)

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

var femaleSum =
    people.filter(function (item) {
        return item.gender;
    }).reduce(function (sum, item, i, arr) {
        var count = arr.length;
        return (sum + item.age / count);
    }, 0);

console.log(femaleSum);