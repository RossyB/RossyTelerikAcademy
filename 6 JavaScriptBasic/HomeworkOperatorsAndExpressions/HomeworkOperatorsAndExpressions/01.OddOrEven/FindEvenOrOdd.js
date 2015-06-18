function findEvenOrOdd() {
    var number = document.getElementById('input_number').value;
    var textLine = document.getElementById('output');
    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the number!'
    }

    else {

        if (number % 2 === 0) {

            textLine.innerHTML = 'The number is even';
        }
        else {

            textLine.innerHTML = 'The number is odd';
        }
    }
}