(function checkUnderaged() {

    var personArray = [{
        fname: 'Yani',
        lname: 'Georgiev',
        age: 19,
        gender: 'male'
    }, {
        fname: 'Petar',
        lname: 'Ivanov',
        age: 25,
        gender: 'male'
    }, {
        fname: 'Georgi',
        lname: 'Todorov',
        age: 17,
        gender: 'male'
    }, {
        fname: 'Atanas',
        lname: 'Petkov',
        age: 36,
        gender: 'male'
    }, {
        fname: 'Angel',
        lname: 'Mihov',
        age: 39,
        gender: 'male'
    }, {
        fname: 'Petia',
        lname: 'Atanasova',
        age: 20,
        gender: 'female'
    }, {
        fname: 'Vania',
        lname: 'Yaneva',
        age: 12,
        gender: 'female'
    }, {
        fname: 'Maria',
        lname: 'Angelova',
        age: 36,
        gender: 'female'
    }, {
        fname: 'Yana',
        lname: 'Petrova',
        age: 16,
        gender: 'female'
    }, {
        fname: 'Ani',
        lname: 'Dimitrova',
        age: 18,
        gender: 'female'
    }];

    var underaged = personArray.filter(function (person) {
        return person.age < 18;
    })

    underaged.forEach(function (item) {
        console.log(item.fname + ' ' + item.lname + ', age: ' + item.age + ' ' + item.gender);
    })
})();