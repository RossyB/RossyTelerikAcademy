function printReverseNumber() {
    var number = document.getElementById('number').value,
        textLine = document.getElementById('output'),
        revNumber = '';

    textLine.style.color = 'blue';

    function chekInput(inputNumber) {
        return (!inputNumber) ? false : true;
    }

    function reverseNumber(number) {

        var numToString = number.toString(),
            revNum = '';

        for (var i = numToString.length - 1; i >= 0; i--) {
            revNum += numToString[i];
        }
        return revNum
    }

    if (chekInput(number)) {
        
        revNumber = reverseNumber(number);
    }

    textLine.innerHTML = 'The reverse number is: ' + revNumber;
}