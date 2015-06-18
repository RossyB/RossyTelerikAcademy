function clone(obj) {
    //initialize new object
    var result;

    if (obj instanceof Array) {
        result = [];
    }
    else {
        result = {};
    }

    for (var i in obj) {

        // If is object Clone again
        if (obj[i] && typeof obj[i] == 'object') {
            result[i] = clone(obj[i]);
        }
        else {
            result[i] = obj[i];
        }
    }
    return result;
}

var student = {
    firstName: 'Ivan',
    lastName: 'Ivanov',
    marks: [6, 5, 3],
    hair: { color: 'blond', type: 'curly' }
}

var student1 = clone(student);

// Edit some data
student1.marks = [5, 6, 4];
student1.hair = { color: 'dark', type: 'straight' };

// Check student`s data
console.log(student.marks.join(', '));
console.log(student.hair.type);