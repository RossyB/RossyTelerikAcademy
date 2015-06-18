function compareArrays() {

    var firstArray = ['a', 'b', 'c', 'd'],
        secondArray = ['a', 'e', 'c', 'd'],
        areEqual = true,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (firstArray.length === secondArray.length) {

        for (var i = 0; i < firstArray.length; i++) {

            if (firstArray[i] !== secondArray[i]) {

                areEqual = false;
                break;
            }
        }
    }

    if (areEqual) {

        textLine.innerHTML = 'The arrays are equal.';
    }
    else {

        textLine.innerHTML = 'The arrays are not equal.';
    }

}