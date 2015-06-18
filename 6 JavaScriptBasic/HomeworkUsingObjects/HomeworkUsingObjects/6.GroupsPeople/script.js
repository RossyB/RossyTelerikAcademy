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

function hasKey(obj, key) {

    for (var prop in obj) {
        
        if (prop == key) {
            return true;
        }
    }
    return false;
}

function groupBy(arr, prop) {
    var result = {};
    var key;

    result.print = function () {

        for (var obj in result) {
            
            if (obj == 'print') {
                continue;
            }
            console.log("Key: " + obj);
            console.log("Persons:");

            for (var person in result[obj]) {
                var currPerson = result[obj][person];
                console.log("FirstName: " + currPerson.firstName + "; LastName: " + currPerson.lastName + "; Age: " + currPerson.age);
            }
        }
    }

    switch (prop) {
        case "firstName":
        case "lastName":
        case "age":
            for (var person in persons) {

                key = arr[person][prop];


                if (hasKey(result, arr[person][prop])) {

                    // Push person into value
                    result[key].push(arr[person]);
                }
                else {

                    // Initialize key and push person
                    result[key] = [];
                    result[key].push(arr[person]);
                }
            }
            break;
        default:
            console.log("Error! You must not enter here!");
    }

    return result;
}

// Test Grouping
var people = groupBy(persons, "firstName");
console.log("Group by First Name:");
people.print();
console.log("");

people = groupBy(persons, "lastName");
console.log("Group by Last Name:");
people.print();
console.log("");

people = groupBy(persons, "age");
console.log("Group by Age:");
people.print();
var a = 3;