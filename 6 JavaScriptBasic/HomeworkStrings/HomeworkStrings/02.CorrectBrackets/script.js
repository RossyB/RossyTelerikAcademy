function checkExpression() {

    var inputString = document.getElementById('input_string').value,
        leftBrCount,
        rightBrCount,
        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter an expression!'
    }
    else {

        leftBrCount = checkBracket(inputString, '(');
        rightBrCount = checkBracket(inputString, ')');

        if (leftBrCount === rightBrCount) {

            outputString = 'The expression is valid!';
        }
        else {

            outputString = 'The expression is NOT valid!';
        }

        textLine.innerHTML = outputString;
    }
}

function checkBracket(input, bracket) {
    var count = 0;

    for (var i = 0; i < input.length; i++) {

        if (input[i] === bracket) {
            count += 1;
        }
    }
    return count;
}
