function findIsPrime() {
    var number = document.getElementById('input_number').value;
    var textLine = document.getElementById('output');
    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the number!'
    }

    else {
        var isPrime = true;

        for (var i = 2; i <= Math.sqrt(number) ; i++) {
            if (number % i === 0) {

                isPrime = false;
                break;
            }
        }

        if (isPrime) {

            textLine.innerHTML = 'Number ' + number + ' is prime.';
        }
        else {
            textLine.innerHTML = 'Number ' + number + ' is NOT prime.';
        }

    }
}