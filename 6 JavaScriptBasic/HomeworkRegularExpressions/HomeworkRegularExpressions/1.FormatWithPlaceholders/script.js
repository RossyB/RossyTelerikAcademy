String.prototype.format = function (options) {
    var prop,
        result = this;
    for (prop in options) {
        result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
    }
    return result;
};

console.log('Hello, there! Are you #{name}?'.format({ name: 'John' }));
console.log('My name is #{name} and I am #{age}-years-old'.format({ name: 'John', age: 13 }));