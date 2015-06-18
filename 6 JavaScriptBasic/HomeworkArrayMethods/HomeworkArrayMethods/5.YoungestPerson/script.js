(function findYoungestPerson() {

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
    personArray.sort(function (a, b) {
        return a.age - b.age;
    }).find(function (item) {
        return item.gender == 'male';
    });

    console.log(youngestMale);
})();