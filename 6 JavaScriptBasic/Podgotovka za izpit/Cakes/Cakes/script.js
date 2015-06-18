function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    var sum = 0;

    for (var i = 0; i <= s / c1; i++) {

        for (var j = 0; j < s / c2; j++) {

            for (var k = 0; k < s / c3; k++) {

                sum = i * c1 + j * c2 + k * c3;

                if (sum <= s) {
                    answer = Math.max(answer, sum);
                }
            }
        }
    }

    console.log(answer);
}

var test1 = [
    '110',
    '13',
    '15',
    '17'
];

var test2 = [
    '20',
    '11',
    '200',
    '300'
]

var test3 = [
    '110',
    '19',
    '29',
    '39'
]

console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));

