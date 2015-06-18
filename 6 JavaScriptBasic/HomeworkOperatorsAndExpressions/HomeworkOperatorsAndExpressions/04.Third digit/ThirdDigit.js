function findThirdDigit() {
    var number = document.getElementById('input_number').value;
    var textLine = document.getElementById('output');
    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the number!'
    }

    else {

        var thirdDigit = parseInt(number / 100);

        if (thirdDigit % 10 === 7) {

            textLine.innerHTML = 'Third digit of number ' + number + ' is 7'
        }

        else {

            textLine.innerHTML = 'Third digit of number ' + number + ' is NOT 7'
        }
    }
}