var db = (function () {
    var lastID = 0,
        objects = [];

    function getNextID() {
        return ++lastID;
    }

    return {
        add: function (obj) {
            obj.id = getNextID();
            objects.push(obj);
        },
        list: function () {
            return objects.slice();
        }
    };
}());

db.add({ name: 'John' });
console.log(db.list());