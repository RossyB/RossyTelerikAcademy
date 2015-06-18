(function checkAge() {

    var personArray = [{
        fname: 'Yani',
        lname: 'Georgiev',
        age: 19
    }, {
        fname: 'Petar',
        lname: 'Ivanov',
        age: 25
    }, {
        fname: 'Georgi',
        lname: 'Todorov',
        age: 19
    }, {
        fname: 'Atanas',
        lname: 'Petkov',
        age: 36
    }, {
        fname: 'Angel',
        lname: 'Mihov',
        age: 39
    }, {
        fname: 'Petia',
        lname: 'Atanasova',
        age: 20
    }, {
        fname: 'Vania',
        lname: 'Yaneva',
        age: 24
    }, {
        fname: 'Maria',
        lname: 'Angelova',
        age: 36
    }, {
        fname: 'Yana',
        lname: 'Petrova',
        age: 21
    }, {
        fname: 'Ani',
        lname: 'Dimitrova',
        age: 18
    }];

    var isGreater = personArray.every(function (person) {
        return person.age >= 18;
    })

    if (isGreater) {
        console.log('Array of person contains only people with age 18 or greater');
    }
    else {
        console.log('Array of person NOT contains only people with age 18 or greater');
    }
})();