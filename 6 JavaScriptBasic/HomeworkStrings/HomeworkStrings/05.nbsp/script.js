function replaceWhiteSpaces() {

    var inputString = document.getElementById('input_string').value,

        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a string with white-spaces!'
    }
    else {

        outputString = inputString.replace(/ /g, '&nbsp;');

        textLine.innerHTML = outputString;
    }
}

