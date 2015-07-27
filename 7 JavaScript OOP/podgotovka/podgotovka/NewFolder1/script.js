function solve() {
    var module = (function () {
        var CONSTANS = {
            TEXT_MIN_LENGTH: 3,
            TEXT_MAX_LENGTH: 25,
            IMDB_MIN_RATHING: 1,
            IMDB_MAX_RATHING: 5
        };
        var validator = {
            validateIfUndefined: function (val, name) {
                name = name || 'Value';
                if (val === undefined) {
                    throw new Error(name + ' cannot be undefined!');
                }
            },

            validateIfNumber: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'number') {
                    throw new Error(name + ' must be a number!')
                }
            },
            validateString: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string!');
                }
                if (val.length < CONSTANS.TEXT_MIN_LENGTH || val.length > CONSTANS.TEXT_MAX_LENGTH) {
                    throw new Error(name + ' must be between ' + CONSTANS.TEXT_MIN_LENGTH + ' and ' + CONSTANS.TEXT_MAX_LENGTH + ' symbols!');
                }
            },
            validatePositiveNumber: function (val, name) {
                name = name || 'Value';
                this.validateIfUndefined(val, name);
                this.validateIfNumber(val, name);
                if (val <= 0) {
                    throw new Error(name + ' must be positive number!')
                }   
            },
            validateImdbRating: function (val) {
                this.validateIfUndefined(val, 'ImdbRating');
                this.validateIfNumber(val, 'ImdbRating');
                if (val < CONSTANS.IMDB_MIN_RATHING || val > CONSTANS.IMDB_MAX_RATHING) {
                    throw new Error('Imdb rating must be between ' + CONSTANS.IMDB_MIN_RATHING + ' and ' + CONSTANS.IMDB_MAX_RATHING + ' !');
                }
            },
            validateIfObject: function (val, name) {
                name = name || 'Value';
                if (typeof val !== 'object') {
                    throw new Error(name + 'must be an object')
                }
            },
            validatePlayableId: function (id) {
                this.validateIfUndefined(id, 'PlayableId');
                if (typeof id !== 'number') {
                    id = id.id;
                }
                this.validateIfUndefined(id, 'Playable must have id!');
                return id;
            },
            validatePageAndSize: function (page, size, maxElements) {
                this.validateIfUndefined(page);
                this.validateIfUndefined(size);
                this.validateIfNumber(page);
                this.validateIfNumber(size);

                if (page < 0) {
                    throw new Error('Page must be greater or equal to 0!')
                }

                this.validatePositiveNumber(size, 'Size');

                if (page * size > maxElements) {
                    throw new Error('Page * size will not return any elements from colection');
                }
            }
        };

        var playlist = (function () {
            var curentPlaylistID = 0
            playlist = Object.create({});

            function findIndexInPlaylist(id) {
                var len,
                    i;
                for (i = 0, len = this._playables.length; i < len; i++) {
                    if (this._playables[i].id == id) {
                        return i;
                    }
                }
                return -1;
            };

            function sortByTitleThenById(first, second) {

                if (first.title < second.title) {
                    return -1;
                }
                else if (first.title > second.title) {
                    return 1;
                }

                if (first.id < second.id) {
                    return -1;
                }
                else if (first.id > second.id) {
                    return 1;
                }
                else {
                    return 0;
                }
            };

            Object.defineProperty(playlist, 'init', {
                value: function (name) {
                    this.name = name;
                    this._playables = [];
                    this._id = ++curentPlaylistID;
                    return this;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.validateString(value, 'Playlist name');
                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function (playable) {
                    validator.validateIfUndefined(playable, 'Playlist add playable');
                    validator.validateIfObject(playable, 'Playlist add parameter');
                    validator.validateIfUndefined(playable.id);
                    this._playables.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function (id) {
                    validator.validateIfUndefined(id, 'Playable ID');
                    validator.validateIfNumber(id, 'Playable ID')

                    var foundIndex = findIndexInPlaylist.call(this, id);
                    if (foundIndex < 0) {
                        return null;
                    }
                    return this._playables[foundIndex];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function (id) {
                    id = validator.validatePlayableId(id);

                    var foundIndex = findIndexInPlaylist.call(this, id);
                    if (foundIndex < 0) {
                        throw new Error('Playable whit id ' + id + ' was not found in playlist!')
                    }

                    this._playables.splice(foundIndex, 1);

                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function (page, size) {
                    validator.validatePageAndSize(page, size, this._playables.length);

                    return this._playables.slice()
                        .sort(sortByTitleThenById)
                        .splice(page * size, size);
                }
            })

            return playlist;
        }());

        var playable = (function () {
            var currentPlayableID = 0,
                playable = Object.create({});

            Object.defineProperty(playable, 'init', {
                value: function (title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentPlayableID;
                    return this;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {
                    return this._title;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable title');
                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function () {
                    return this._author;
                },
                set: function (value) {
                    validator.validateString(value, 'Playable author');
                    this._author = value;
                }
            });
            
            Object.defineProperty(playable, 'play', {
                value: function () {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
        })
            return playable;
        }());

        var audio = (function (parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function (title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;
                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get: function () {
                    return this._length;
                },
                set: function (value) {
                    validator.validatePositiveNumber(value, 'Audio length');
                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.length;
                }
            });

            return audio;
        }(playable));

        var video = (function (parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function (title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;
                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function () {
                    return this._imdbRating;
                },
                set: function (value) {
                    validator.validateImdbRating(value);
                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function () {
                    return parent.play.call(this) + ' - ' + this.imdbRating;
                }
            });

            return video;

        }(playable));
        

        return {
            getPlayer: function (name) {
                // returns a new player instance with the provided name
                return Object.create(player).init(name);
            },
            getPlaylist: function (name) {
                //returns a new playlist instance with the provided name
                return Object.create(playlist).init(name);
            },
            getAudio: function (title, author, length) {
                //returns a new audio instance with the provided title, author and length
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function (title, author, imdbRating) {
                //returns a new video instance with the provided title, author and imdbRating
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}

var module = solve();

for (var i = 0; i < 10; i++) {
    var currentAudio = module.getAudio('Title' + i, 'author' + i, i + 1);
    console.log(currentAudio.play());
}