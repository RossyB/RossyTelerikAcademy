function printNumber() {

    var number = parseInt(document.getElementById('input_number').value),
        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a number!'
    }
    else {

        for (var i = 1; i <= number; i++) {

            outputString += i + ', ';
        }

        outputString = outputString.substring(0, outputString.length - 2);
       
        textLine.innerHTML = outputString;
    }
}