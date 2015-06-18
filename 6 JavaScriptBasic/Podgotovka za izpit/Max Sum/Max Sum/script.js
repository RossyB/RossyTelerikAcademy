function Solve(input) {
    
    var inputInt = input.slice(1).map(Number);

    var bestSum = inputInt[0];
    for (var i = 0; i < inputInt.length; i++) {
        var curentSum = 0;
        for (var j = i; j < inputInt.length; j++) {
            curentSum += inputInt[j];
            if (curentSum > bestSum) {
                bestSum = curentSum;
            }
        }
    }
    return bestSum;
}

var test1 = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1'
];

console.log(Solve(test1));