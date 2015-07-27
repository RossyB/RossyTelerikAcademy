function Person(name, age) {
    this.name = name;
    this.age = age;
}

Object.defineProperty(Person.prototype, name, {
    get: function () {
        return this._name;
    },
    set: function (value) {
        this._name = value;
        return this;
    }
});

var p = new Person('John Doe', 13);
console.log(p.name);
console.log(p.age);