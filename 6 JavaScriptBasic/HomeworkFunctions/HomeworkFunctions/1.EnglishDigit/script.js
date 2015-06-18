function printDigitAsWord() {
    var number = parseInt(document.getElementById('number').value),
        textLine = document.getElementById('output'),
        lastDigitAsWord;

    textLine.style.color = 'blue';

    function chekInput(number) {
        return (!number) ? false : true;
    }

    function findLastDigitAsWord(number) {
        var lastDigit = number % 10;

        switch (lastDigit) {
            case 0: return 'Zero'; break;
            case 1: return 'One'; break;
            case 2: return 'Two'; break;
            case 3: return 'Three'; break;
            case 4: return 'Four'; break;
            case 5: return 'Five'; break;
            case 6: return 'Six'; break;
            case 7: return 'Seven'; break;
            case 8: return 'Eight'; break;
            case 9: return 'Nine'; break;
        }
    }
    
    if (chekInput(number)) {
        lastDigitAsWord = findLastDigitAsWord(number);
    } 

    textLine.innerHTML = 'The last digit is: ' + lastDigitAsWord;
}