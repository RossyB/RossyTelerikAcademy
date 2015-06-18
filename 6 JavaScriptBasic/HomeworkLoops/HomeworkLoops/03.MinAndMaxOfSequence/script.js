var inputNumbers = [],
    minNumber,
    maxNumber,
    textLine;

function addNumbers() {

    var number = parseInt(document.getElementById('input_numbers').value);
    textLine = document.getElementById('output');

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a number!'
    }

    else {

        inputNumbers.push(number);
    }
}

function orderBy(a,b) {

    return (a == b) ? 0 : (a > b) ? 1 : -1;
}

function findMinAndMaxNumbers() {

    var outputString;
    textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    inputNumbers.sort(orderBy);
    minNumber = inputNumbers[0];
    maxNumber = inputNumbers[inputNumbers.length - 1];

    outputString = 'Min number is: ' + minNumber + 'and Max number is: ' + maxNumber;

    textLine.innerHTML = outputString;
}