function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        temparr = [],
        tempresult = 0
        result = 0,
        n = nk[0],
        k = nk[1];

    for (var j = 0; j < k; j++) {

        for (var i = 0; i < n; i++) {
            temparr[i] = s[i];

            if (s[i] == 0) {

                if (s[i - 1] == undefined) {
                    temparr[i] = Math.abs(s[n - 1] - s[i + 1]);
                }
                else if (s[i + 1] == undefined) {
                    temparr[i] = Math.abs(s[i - 1] - s[0]);
                }
                else {
                    temparr[i] = Math.abs(s[i - 1] - s[i + 1]);
                }
            }
            else if (s[i] == 1) {

                if (s[i - 1] == undefined) {
                    temparr[i] = s[n - 1] + s[i + 1];
                }
                else if (s[i + 1] == undefined) {
                    temparr[i] = s[i - 1] + s[0];
                }
                else {
                    temparr[i] = s[i - 1] + s[i + 1];
                }
            }
            else if (s[i] % 2 == 0) {

                if (s[i - 1] == undefined) {
                    temparr[i] = Math.max(s[n - 1], s[i + 1]);
                }
                else if (s[i + 1] == undefined) {
                    temparr[i] = Math.max(s[i - 1], s[0]);
                }
                else {
                    temparr[i] = Math.max(s[i - 1], s[i + 1]);
                }
            }
            else if (s[i] % 2 != 0) {

                if (s[i - 1] == undefined) {
                    temparr[i] = Math.min(s[n - 1], s[i + 1]);
                }
                else if (s[i + 1] == undefined) {
                    temparr[i] = Math.min(s[i - 1], s[0]);
                }
                else {
                    temparr[i] = Math.min(s[i - 1], s[i + 1]);
                }
            }
            
        }
        
        
        s = temparr.slice(0);
    }
    for (var p = 0; p < temparr.length; p++) {
        result += temparr[p];
    }
    console.log(result);
}

var test1 = [
    '5 1',
    '9 0 2 4 1'
]

var test2 = [
    '10 3',
    '1 9 1 9 1 9 1 9 1 9'
]

var test3 = [
    '10 10',
    '0 1 2 3 4 5 6 7 8 9',

]

solve(test1);
solve(test2);
solve(test3);