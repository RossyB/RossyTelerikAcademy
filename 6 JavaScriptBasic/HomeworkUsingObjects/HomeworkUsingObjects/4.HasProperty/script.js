var pesho = {
    name: 'Pesho',
    age: 23
}

function checkProperty(obj, propName) {

    for (var prop in obj) {
        
        if (prop == propName) {
            return true;
        }
    }
    return false;
}

if (checkProperty(pesho, 'name') == true) {
    console.log('Property exists!');
}
else {
    console.log('Property does NOT exists!');
}