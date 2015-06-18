//Problem 2. Correct brackets

console.log('Problem 2');

var correctStr = '((a+b)/5-d)',
    incorrectStr = ')(a+b))';

function correctBrackets(str) {
    var i,
        open = 0,
        close = 0,
        flag = false;

    for (i in str) {
        if (open === close) {
            flag = false;
        }
        if (str[i] === '(') {
            open += 1;
            flag = true;
        } else if (str[i] === ')') {
            if (flag) {
                close += 1;
            } else {
                return false;
            }
        }
    }

    if (open === close) {
        return true;
    }
}

console.log(correctBrackets(correctStr));
console.log(correctBrackets(incorrectStr) + '\n\r');