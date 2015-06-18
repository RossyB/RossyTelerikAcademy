function findMostFrequentNumber() {

    var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        tempMax,
        maxCount = 0,
        maxRep = 0,
        maxNum = 0,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    for (var i = 0; i < array.length; i++) {

        tempMax = array[i];

        for (var j = 0; j < array.length; j++) {

            if (tempMax == array[j]) {

                maxCount++;
            }
        }

        if (maxCount > maxRep) {
            maxRep = maxCount;
            maxCount = 0;
            maxNum = tempMax;
        }

        maxCount = 0;
    }
    
    if (maxRep > 1) {

        textLine.innerHTML = maxNum + ' (' + maxRep + ' times)';
    }
    else {
        textLine.innerHTML = 'All elements are different';
    }
}