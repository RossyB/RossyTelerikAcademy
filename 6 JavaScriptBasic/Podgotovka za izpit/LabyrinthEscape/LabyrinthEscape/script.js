function Solve(params) {
    var sizes = params[0].split(' '),
        rows = parseInt(sizes[0]),
        cols = parseInt(sizes[1]),
        startposition = params[1].split(' '),
        row = parseInt(startposition[0]),
        col = parseInt(startposition[1]),
        lab = params.slice(2),
        visited = {},
        sum = 0,
        count = 0,
        directions = {
            u: {
                row: -1,
                col: 0
            },
            r: {
                row: 0,
                col: +1
            },
            d: {
                row: +1,
                col: 0
            },
            l: {
                row: 0,
                col: -1
            }
        };

    function getValueAt(row, col, cols) {
        return row * cols + col + 1;
    }

    function inRange(value, border) {
        return 0 <= value && value < border;
    }

    while (true) {

        if (!inRange(row, rows) || !inRange(col, cols)) {

            return 'out ' + sum;

        }
        var sellValue = getValueAt(row, col, cols);

        if (visited[sellValue]) {
            return 'lost ' + count;
        }

        sum += sellValue;
        count++;
        visited[sellValue] = true;

        var dir = lab[row][col];
        row += directions[dir].row;
        col += directions[dir].col;

        
    }
}

var test1 = [
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"];

console.log(Solve(test1))
