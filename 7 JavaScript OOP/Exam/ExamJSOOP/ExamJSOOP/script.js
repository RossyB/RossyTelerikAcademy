function solve() {

    var validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined!');
            }
        },
        validateNonEmptyString: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string!');
            }
            if (val.trim(' ').length <= 0) {
                throw new Error(name + ' must be non empty string!');
            }
        },
        validateString: function (val, minLength, maxLength, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string!');
            }

            if (val.length < minLength || val.length > maxLength) {
                throw new Error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols!');
            }
        },

        validateIsbn: function (val, name) {
            this.validateIfUndefined(val, 'ISBN');
            if (!(/^[0-9]{10,13}$/.test(val))) {
                throw new Error(name + ' must be 10 or 13 digits');
            }
        },
        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number!')
            }
        },
        validatePositiveNumber: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfNumber(val, name);
            if (val < 0) {
                throw new Error(name + ' must be positive number!')
            }
        },

    }

    var item = (function () {
        var currentitemId = 0,
            item = Object.create({});

        Object.defineProperty(item, 'init', {
            value: function (name, description) {
                this.name = name;
                this.description = description;
                this._id = ++currentitemId;
                return this;
            }
        });

        Object.defineProperty(item, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                validator.validateString(value, 2, 40, 'name');
                this._name = name;
            }
        });

        Object.defineProperty(item, 'description', {
            get: function () {
                return this._description;
            },
            set: function (value) {
                validator.validateIfUndefined(value, 'Description');
                validator.validateNonEmptyString(value, 'Description');
                this._description = value;
            }
        });

        Object.defineProperty(item, 'id', {
            get: function () {
                return this._id;
            }
        });

        return item;
    }());

    var book = (function (parent) {
        var book = Object.create(parent);

        Object.defineProperty(book, 'init', {
            value: function (name, isbn, genre, description) {
                parent.init.call(this, name, description);
                this.isbn = isbn;
                this.genre = genre;
                return this;
            }
        });

        Object.defineProperty(book, 'isbn', {
            get: function () {
                return this._isbn;
            },
            set: function (value) {
                validator.validateIsbn(value);
                this._isbn = value;
            }
        });

        Object.defineProperty(book, 'genre', {
            get: function () {
                return this._genre;
            },
            set: function (value) {
                validator.validateString(value, 2, 20, 'genre');
                this._genre = value;
            }
        });

        return book;
    }(item));

    var media = (function (parent) {
        var media = Object.create(parent);

        Object.defineProperty(media, 'init', {
            value: function (name, rating, duration, description) {
                parent.init.call(this, name, description);
                this.rating = rating;
                this.duration = duration;
                return this;
            }
        });

        Object.defineProperty(media, 'rating', {
            get: function () {
                return this._rating;
            },
            set: function (value) {
                validator.validatePositiveNumber(value, 'Rating');
                this._rating = value;
            }
        });

        Object.defineProperty(media, 'duration', {
            get: function () {
                return this._duration;
            },
            set: function (value) {
                validator.validateIfNumber(value);
                if (value < 0 || value > 6) {
                    throw new Error ('Duration must be greater than 0 and less than 6')
                }
                this._duration = value;
            }
        });

    }(item));

    var catalog = (function () {
        var currentcatalogID = 0,
            catalog = Object.create({});

        Object.defineProperty(catalog, 'init', {
            value: function (name) {
                this.name = name;
                this.items = [];
                this._id = ++currentcatalogID;
                return this;
            }

        });

        Object.defineProperty(catalog, 'id', {
            get: function () {
                return this._id;
            }
        });

        Object.defineProperty(catalog, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                validator.validateString(value, 2, 40, 'Catalog name');
                this._name = value;
            }
        });

        Object.defineProperty(catalog, 'add', {

            value: function (params) {
                var itemsToAdd;
                validator.validateIfUndefined(params, 'Items to add');

                if (params instanceof Array) {
                    itemsToAdd = params;
                }
                else {
                    itemsToAdd = Array.prototype.slice.call(params);
                }
                validator.validateIfUndefined(itemsToAdd);
                if (itemsToAdd.length === 0) {
                    throw new Error ('items to add is empty')
                }
                for (var i = 0; i < itemsToAdd.length; i++) {
                    if (typeof itemsToAdd[i] !== 'object') {
                        throw new Error('items must be object')
                    }
                    this.items.push(itemsToAdd[i]);
                }
                return this;
            }
        });

        Object.defineProperty(catalog, 'find', {
            value: function (id) {
                var result = [];
                validator.validateIfUndefined(id);
                if (validator.validateIfNumber(id)) {
                    for (var i = 0; i < items.lenth; i++) {
                        if (items[i].id === id) {
                            result.push(items[i]);
                        }
                    }
                }
                else {
                    if (id.hasOwnProperty(name)) {
                        for (var i = 0; i < items.length; i++) {
                            if (items[i].name === id.name) {
                                result.push(items[i]);
                            }
                        }
                    }
                    else if (id.hasOwnProperty(id)) {
                        for (var i = 0; i < items.length; i++) {
                            if (items[i].id === id.id) {
                                result.push(items[i]);
                            }
                        }
                    }
                }
               
                return result;
            }
        });

        return catalog;
    }());

    var bookCatalog = (function (parent) {
        var bookCatalog = Object.create(parent);

        Object.defineProperty(bookCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }
        });
        
        Object.defineProperty(bookCatalog, 'add', {
            value: function (params) {
                return parent.add.call(this);
            }
        });

        Object.defineProperty(bookCatalog, 'find', {
            value: function (params) {
                return parent.find.call(this);
            }
        });

        return bookCatalog

    }(catalog));

    var mediaCatalog = (function (parent) {
        var mediaCatalog = Object.create(parent);

        Object.defineProperty(mediaCatalog, 'init', {
            value: function (name) {
                parent.init.call(this, name);
                return this;
            }

        });

        Object.defineProperty(mediaCatalog, 'add', {
            value: function (params) {
                return parent.add.call(this);
            }
        });

        Object.defineProperty(mediaCatalog, 'find', {
            value: function (params) {
                return parent.find.call(this);
            }
        });

        return mediaCatalog;
    }(catalog));

    return {
        getBook: function (name, isbn, genre, description) {
            return Object.create(book).init(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return Object.create(media).init(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return Object.create(bookCatalog).init(name);
        },
        getMediaCatalog: function (name) {
            return Object.create(mediaCatalog).init(name);
        }
    }
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

//console.log(catalog.find(book1.id));
//returns book1

//console.log(catalog.find({ id: book2.id, genre: 'IT' }));
//returns book2

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'))
//returns []
