Array.prototype.remove = function (thisArg) {
    var arr = this;
    for (var i = 0; i < arr.length; i++) {
        
        if (arr[i] == thisArg) {
            arr.splice(i, 1);

            //go back
            i--;
        }
    }
}

var arr = [1, 1, 2, 1, 1, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.remove(1);

//print result
console.log('1 removed: ' + arr.join(', '));