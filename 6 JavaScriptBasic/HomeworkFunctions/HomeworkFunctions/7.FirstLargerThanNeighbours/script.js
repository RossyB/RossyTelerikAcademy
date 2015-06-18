function findFirstBiggerThanNeighbours() {
    var textLine = document.getElementById('output'),
        arr = [1, 2, 3, 4, 8, 9, 8, 6, 4, 3, 4, 9, 0, 0, 9, 7, 6, 5, 4, 6, 7, 6, 7, 8, 9],
        firstIndex,
        isBigger = false;

    textLine.style.color = 'blue';

    for (var i = 0; i < arr.length; i++) {

        isBigger = indexIsBigger(i, arr);
        if (isBigger) {
            firstIndex = i;
            break;
        }
    }

    textLine.innerHTML = 'The number ' + arr[firstIndex] + ' at index ' + firstIndex + ' is first bigger than its neighbours.';
}

function indexIsBigger(index, array) {
    if (index === 0) {

        if (array[index] > array[index + 1]) {
            return true;
        }
    }
    else if (index === array.length - 1) {
        if (array[index] > array[index - 1]) {
            return true;
        }
    }
    else if ((index > 0) && index < (array.length - 1)) {

        if (array[index] > array[index - 1] && array[index] > array[index + 1]) {
            return true;
        }
    }
    else {
        return false;
    }

}