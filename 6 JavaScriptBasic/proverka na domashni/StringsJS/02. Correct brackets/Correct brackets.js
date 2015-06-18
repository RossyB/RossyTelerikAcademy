﻿// Write a JavaScript function to check if in a given expression the brackets are put correctly.

function checkBrackets(expression) {
    var stack = 0
      , i
    for (i = 0; i < expression.length && stack >= 0; i++) {
        if (expression.charAt(i) === '(') stack++;
        if (expression.charAt(i) === ')') stack--;
    }
    return !stack;
}
console.log(checkBrackets('((a+b)/5-d)'));
console.log(checkBrackets(')(a+b)).'));