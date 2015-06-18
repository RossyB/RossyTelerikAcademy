function reverseString() {

    var inputString = document.getElementById('input_string').value,
        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a string!'
    }
    else {

        for (var i = inputString.length - 1; i >= 0; i--) {

            outputString += inputString[i];
        }

        textLine.innerHTML = outputString;
    }
}