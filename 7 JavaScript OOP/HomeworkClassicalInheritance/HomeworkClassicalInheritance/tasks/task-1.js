/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAMEAGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/ 
function solve() {
	var Person = (function () {
	    function Person(firstname, lastname, age) {
	        this.firstname = firstname;
	        this.lastname = lastname;
	        this.age = age;
	    }

	    function checkString(string) {
	        if (!string) {
                throw new Error('Name cannot be empty string!')
	        }
	        else if (!(/^[a-zA-Z-]+$/.test(string))) {
	            throw new Error('Name must containing only Latin letters!')
	        }
	        else if (string.length < 3 || string.length > 20) {
	            throw new Error('Name must always be between 3 and 20 characters!')
	        }
	    }

	    function checkNumber(number) {
	        if (!number) {
	            throw new Error('Age cannot be null or empty!');
	        }
	        else if (!(/^\d*$/.test(number))) {
	            throw new Error('Age must be a number');
	        }
	        else if (number <= 0 || number >= 150) {
	            throw new Error('Age must be in the range 0 150');
	        }
	    }

	    Object.defineProperty(Person.prototype, 'firstname', {
	        get: function () {
	            return this._firstname;
	        },
	        set: function (value) {
	            checkString(value);
	            this._firstname = value;
	        }
	    });

	    Object.defineProperty(Person.prototype, 'lastname', {
	        get: function () {
	            return this._lastname;
	        },
	        set: function (value) {
	            checkString(value);
	            this._lastname = value;
	        }
	    });

	    Object.defineProperty(Person.prototype, 'age', {
	        get: function () {
	            return this._age;
	        },
	        set: function (value) {
	            checkNumber(value);
	            this._age = value;
	        }
	    });

	    Object.defineProperty(Person.prototype, 'fullname', {
	        get: function () {
	            return this._firstname + ' ' + this._lastname;
	        },
	        set: function (value) {
	            var names = value.split(' ');
	            this._firstname = names[0];
	            this._lastname = names[1];
	        }
	    });

	    Person.prototype.introduce = function () {
	        return 'Hello! My name is ' + this._firstname + ' ' + this._lastname + ' and I am ' + this._age + '-years-old';
	    }

		return Person;
	} ());

	return Person;
}
module.exports = solve;