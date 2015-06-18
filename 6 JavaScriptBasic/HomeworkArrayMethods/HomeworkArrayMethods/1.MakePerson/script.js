(function createPerson() {

    personsArray = [],
        firstNames = ['Yani', 'Petar', 'Georgi', 'Atanas', 'Angel', 'Petia', 'Vania', 'Maria', 'Yana', 'Ani'],
        lastNames = ['Georgiev', 'Ivanov', 'Todorov', 'Petkov', 'Mihov', 'Atanasova', 'Yaneva', 'Angelova', 'Petrova', 'Dimitrova'];

    for (var i = 0; i < firstNames.length; i++) {
        personsArray.push(makePerson(firstNames[i], lastNames[i], Math.floor((Math.random() * 100) + 1), (i > 4) ? true : false));
    }

    personsArray.forEach(function (person) {
        person.printAll();
    })

})();

function makePerson(fName, lName, age, gender) {
    return {
        firstName: fName,
        lastName: lName,
        age: age,
        gender: gender,
        printAll: function () {
            console.log(this.firstName + ' ' + this.lastName + ', ' + this.age + ' years old, female: ' + this.gender)
        }
    };
}