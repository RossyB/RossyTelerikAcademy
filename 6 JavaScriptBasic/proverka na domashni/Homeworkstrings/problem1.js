//Problem 1. Reverse string

console.log('Problem 1');

var str = 'sample';

function reverseString(text) {
    var ans = '',
        len = text.length;
    for (i = len - 1 ; i >= 0 ; i -= 1) {
        ans += text[i];
    }
    return ans;
}

console.log(reverseString(str) + '\n\r');
