(function groupPeople() {

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

    var result = personArray.reduce(function (obj, item) {
        if (obj[item.fname[0]]) {
            obj[item.fname[0]].push(item);
        } else {
            obj[item.fname[0]] = [item];
        }
        return obj;
    }, {});

    console.log(result);
})();