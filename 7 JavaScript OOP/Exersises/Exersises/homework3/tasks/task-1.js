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
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {

    function validateName(name) {
        var regex = /^[a-zA-Z]*$/;
        
        if (! name || name.length < 3 || name.length > 20) {
            throw new Error ('Invalid name!')
        }

        if (!regex.test(name)) {
            throw new Error ('Invalid name!')
        }
    }

    function validateAge(age) {
        var age = +age;
        if(age <0 || age > 100){
            throw new Error('Invalid age!')
        }
    }

	var Person = (function () {
	    function Person(firstname, lastname, age) {
	        this.firstname = firstname;
	        this.lastname = lastname;
	        this.age = age;
	    }

	    Object.defineProperty(Person.prototype, 'firstname' ,{
	        get: function () {
	            return this._firstname;
	        },
	        set: function (value) {
	            validateName(value);
	            this._firstname = value;
	        }
	    })
	    Object.defineProperty(Person.prototype, 'lastname', {
	        get: function () {
	            return this._lastname;
	        },
	        set: function (value) {
	            validateName(value);
	            this._lastname = value;
	        }
	    })

	    Object.defineProperty(Person.prototype, 'fullname', {
	        get: function () {
	            return this.firstname + ' ' + this.lastname;
	        },
	        set: function (value) {
	            var names = value.split(' ');
	            this.firstname = names[0];
	            this.lastname = names[1];
	        }
	    })

	    Object.defineProperty(Person.prototype, 'age', {
	        get: function () {
	            return this._age;
	        },
	        set: function (value) {
	            validateAge(value);
	            this._age = value;
	        }
	    })

	    Person.prototype.introduce = function () {
	        return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
	    }

	    return Person;
	} ());
	return Person;
}
module.exports = solve;