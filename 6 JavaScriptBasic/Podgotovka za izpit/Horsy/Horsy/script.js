function solve(params) {
    var rowsAndCols = getRowsAndCols(params[0]),
        rows = rowsAndCols[0],
        cols = rowsAndCols[1],
        row = rows - 1,
        col = cols - 1,
        points = 0,
        moves = 0,
        used = [];

    var horseMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1],
                      [2, -1], [1, -2], [-1, -2], [-2, -1]];

    while (true) {

        if (row < 0 || row >= rows || col < 0 || col >= cols) {
            return 'Go go Horsy! Collected ' + points + ' weeds';
        }

        if (used[row + ' ' + col] == true) {
            return 'Sadly the horse is doomed in ' + moves + ' jumps';
        }

        points += getPoints(row, col);
        moves += 1;
        var move = horseMoves[getValue(params, row, col) - 1];
        used[row + ' ' + col] = true;
        row += move[0];
        col += move[1];

    }

    function getPoints(row, col) {
        return Math.pow(2, row) - col;
    }

    function getRowsAndCols(str) {
        var parts = str.split(' ')
        return [parseInt(parts[0]), parseInt(parts[1])];
    }

    function getValue(params, row, col) {
        return params[row + 1][col];
    }

}

var test1 = [
'3 5',
'54561',
'43328',
'52388',
];

var test2 = [
'3 5',
'54361',
'43326',
'52188',
];

console.log(solve(test1));
console.log(solve(test2));