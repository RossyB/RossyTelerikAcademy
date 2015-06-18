function printNumberAsWord() {
    var number = parseInt(document.getElementById('input_number').value),
        result = "",
        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (number < 0 || number > 999) {
        result = "Error! Number must be in range [0,999]!";
    }

    if (number == 0) {
        result = ' Zero';
    }

    //Pronounciation arrays
    var beforeTen = new Array("", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten");
    var afterTen = new Array("ten", "eleven", "tweleve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen");
    var hundreeds = new Array("", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety");

    //Begun calculations
    //Get hundreeds
    if (parseInt(number / 100) > 0) {
        result += beforeTen[parseInt(number / 100)] + " hundred ";
    }

    //Get tens and units 20+
    if (parseInt(number % 100) > 19) {
        //tens
        result += hundreeds[parseInt(parseInt(number % 100) / 10)] + " ";
        //units
        result += beforeTen[parseInt(parseInt(number % 100) % 10)] + " ";
    }

        //Greter than 100 and less than 20. Resolved AND problem
    else if (parseInt(number % 100) > 9 && parseInt(number / 100) > 0) {
        //tens
        result += " and " + afterTen[parseInt(parseInt(number % 100) % 10)] + " ";
    }
    else if (parseInt(number % 100) > 0 && parseInt(number / 100) > 0) {
        //units
        result += " and " + beforeTen[parseInt(parseInt(number % 100) % 10)] + " ";
    }

        //Less than 100 without AND
    else if (parseInt(number % 100) > 9) {
        //tens
        result += afterTen[parseInt(parseInt(number % 100) % 10)] + " ";
    }
    else if (parseInt(number % 100) > 0) {
        //units
        result += beforeTen[parseInt(parseInt(number % 100) % 10)] + " ";
    }

    //Print result
    //Capitalise first letter
    textLine.innerHTML = number + " -> " + result.charAt(0).toUpperCase() + result.slice(1);
}