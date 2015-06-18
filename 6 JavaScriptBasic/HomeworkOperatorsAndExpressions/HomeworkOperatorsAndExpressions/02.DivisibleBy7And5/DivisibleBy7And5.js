function findDivisibleBy7And5() {
    var number = document.getElementById('input_number').value;
    var textLine = document.getElementById('output');
    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the number!'
    }

    else {

        if (number % 5 === 0 && number % 7 === 0) {

            textLine.innerHTML = 'Number is divisible by 7 and 5.'
        }
        else {

            textLine.innerHTML = 'Number is NOT divisible by 7 and 5.'
        }
    }

    
}