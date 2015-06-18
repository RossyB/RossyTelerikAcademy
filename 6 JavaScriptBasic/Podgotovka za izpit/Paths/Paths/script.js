function solve(input) {
    var rowsCols = input[0].split(' '),
        bounds = {
            rows: +rowsCols[0],
            cols: +rowsCols[1]
        },
        matrix = input.slice(1)
        .map(function (line) {
            return line.split(' ')
        }),
        row = 0,
        col = 0,
        sum = 0,
        count = 0,
        dir,
        deltas = {
            u: -1,
            d: +1,
            l: -1,
            r: +1
        },
        upDown,
        leftRight;

    while (true) {
        //check range
        if (row < 0 || row >= bounds.rows || col < 0 || col >= bounds.cols) {
            return 'successed with ' + sum;
        }
        if (matrix[row][col] === 'used') {
            return 'failed at ('+ row +', ' + col + ')';
        }

        
        //update sum
        sum += (1 << row) + col;

        dir = matrix[row][col];
        upDown = dir[0];
        leftRight = dir[1];
        matrix[row][col] = 'used';
        //update row
        row += deltas[upDown];
        //update col
        col += deltas[leftRight];

    }
}

var test1 = [
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];

var test2 = [
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
    ]
console.log(solve(test1));
console.log(solve(test2));