function selectionSort() {

    var array = [31, 34, 12, 22, 11, 16, 19, 90, 122, 72],
        min,
        tempNum,

        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    for (var i = 0; i < array.length - 1; i++) {

        min = i;

        for (var j = i + 1; j < array.length; j++) {

            if (array[j] < array[min]) {

                min = j;
            }
        }

        //swap the values

        tempNum = array[i];
        array[i] = array[min];
        array[min] = tempNum;
    }

    outputString = array.join(', ').toString();
    
    textLine.innerHTML = outputString;
}