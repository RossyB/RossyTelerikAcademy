function findMaximalSequence() {

    var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
        leng = 1,
        bestLeng = 0,
        lengNumber = 0,
        outputString = '',
        
        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    for (var i = 0; i < array.length; i++) {

        if (array[i]== array[i+1]) {
            
            leng++;
        }
        else {

            if (leng > bestLeng) {

                bestLeng = leng;
                lengNumber = array[i];
            }
            leng = 1;
        }
    }

    if (leng > bestLeng) {

        bestLeng = leng;
        lengNumber = array[array.length - 1];
    }

    for (var i = 0; i < bestLeng; i++) {
        outputString += lengNumber + ' ';
    }

    textLine.innerHTML = 'The maximal sequence is: ' + outputString;
}