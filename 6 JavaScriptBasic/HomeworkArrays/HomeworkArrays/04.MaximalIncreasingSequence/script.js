function findMaxIncreasingSequence() {

    var array = [3, 2, 3, 4, 6, 2, 4],
        leng = 1,
        bestLeng = 0,
        lengIndex = 0,
        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    for (var i = 0; i < array.length; i++) {

        if (array[i] < array[i + 1]) {

            leng++;
        }
        else {

            if (leng > bestLeng) {

                bestLeng = leng;
                lengIndex = i;
            }
            leng = 1;
        }
    }

    if (leng > bestLeng) {

        bestLeng = leng;
        lengIndex = array.length - 1;
    }

    for (var i = lengIndex - bestLeng + 1; i < lengIndex + 1; i++) {

        outputString += array[i] + ' ';
    }

    textLine.innerHTML = 'The maximal sequence is: ' + outputString;
}