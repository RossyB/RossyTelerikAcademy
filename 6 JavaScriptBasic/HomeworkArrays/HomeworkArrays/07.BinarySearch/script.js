function findIndex() {

    var key = parseInt(document.getElementById('number').value),
        array = [3, 4, 5, 6, 7, 34, 54, 78, 88],
        min = 0,
        max = array.length - 1,
        found = false,
        mid,
        index,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    while (!found && min <= max) {

        mid = parseInt((min / 2) + (max / 2));

        if (array[mid] == key) {

            index = mid;
            found = true;
        }
        else if (array[mid] < key) {

            min = mid + 1;
        }
        else {

            max = mid - 1;
        }
    }

    if (index == undefined) {
        textLine.innerHTML = 'The number is not in array';
    }
    else {
        textLine.innerHTML = 'The index is: ' + index;
    }
}