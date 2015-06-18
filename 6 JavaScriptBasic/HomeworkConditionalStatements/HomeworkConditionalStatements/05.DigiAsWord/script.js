function printDigitAsWord() {
    var number = parseInt(document.getElementById('input_number').value),
        numberAsString,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a number!'
    }
    else {

        switch (number) {
            case 0: numberAsString = 'Zero'; break;
            case 1: numberAsString = 'One'; break;
            case 2: numberAsString = 'Two'; break;
            case 3: numberAsString = 'Three'; break;
            case 4: numberAsString = 'Four'; break;
            case 5: numberAsString = 'Five'; break;
            case 6: numberAsString = 'Six'; break;
            case 7: numberAsString = 'Seven'; break;
            case 8: numberAsString = 'Eight'; break;
            case 9: numberAsString = 'Nine'; break;
            default: numberAsString = 'Not a digit'; break;

        }

        textLine.innerHTML = numberAsString;
    }
}