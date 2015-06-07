//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

var ofAgeOnly =
    people.every(function (item) {
        return item.age >= 18;
    });
console.log(ofAgeOnly);