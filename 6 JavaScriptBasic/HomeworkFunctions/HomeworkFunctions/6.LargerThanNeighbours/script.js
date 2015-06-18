function findIfBiggerThanNeighbours() {
    var textLine = document.getElementById('output'),
        index = parseInt(document.getElementById('index').value),
        arr = [1, 2, 3, 4, 8, 9, 8, 6, 4, 3, 4, 9, 0, 0, 9, 7, 6, 5, 4, 6, 7, 6, 7, 8, 9],
        isBigger;    

    textLine.style.color = 'blue';

    isBigger = indexIsBigger(index, arr)

    if (isBigger) {
        textLine.innerHTML = 'The number ' + arr[index] + ' at index ' + index + ' is bigger than its neighbours.'
    }
    else {
        textLine.innerHTML = 'The number ' + arr[index] + ' at index ' + index + ' is NOT bigger than its neighbours.'
    }
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