function Solve(input) {
    var N = parseInt(input[0]);
    var arr = [];
    var count = 1;
    // Your code here...

    for (var i = 1; i < input.length; i++) {
        arr.push(parseInt(input[i]));
    }

    for (var i = 1; i < arr.length; i++) {
        
        if (arr[i - 1] > arr[i] ) {
            count++;
        }
    }
    return count;
}

var input = [
        6,
        1,
        3,
        -5,
        8,
        7,
        -6];

Solve(input);