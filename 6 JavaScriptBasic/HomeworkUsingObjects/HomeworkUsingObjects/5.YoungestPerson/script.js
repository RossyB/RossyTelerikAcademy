var persons = [
                {
                    firstName: 'Pesho',
                    lastName: 'Petrov',
                    age: 32
                }, {
                    firstName: 'Bay',
                    lastName: 'Ivan',
                    age: 40
                }, {
                    firstName: 'Gosho',
                    lastName: 'Goshov',
                    age: 35
                }, {
                    firstName: 'Bay',
                    lastName: 'Miro',
                    age: 82
                }
];

function findYoungest(arr) {

    var minAge = Number.MAX_VALUE;
    var youngest = {};

    for (var i = 0; i < arr.length; i++) {

        for (var prop in arr[i]) {

            if (prop == 'age') {
                
                if (arr[i].age < minAge) {

                    minAge = arr[i].age;
                    youngest = arr[i];
                }
            }
        }
        
    }
    return youngest;
}

for (var i = 0; i < persons.length; i++) {
    var person = persons[i];
    console.log(person.firstName + ' ' + person.lastName + ' ' + person.age);
}

var youngest = findYoungest(persons);
console.log('Youngest person is: ' + youngest.firstName + '; Age:' + youngest.age);