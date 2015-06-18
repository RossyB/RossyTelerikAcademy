function checkCountAppearance() {
    var textLine = document.getElementById('output1'),
        
        number = parseInt(document.getElementById('number').value),
        array = [1, 2, 3, 4, 8, 9, 8, 6, 4, 3, 4, 9, 0, 0, 9, 7, 6, 5, 4, 6, 7, 6, 7, 8, 9],
        countNumber;

    textLine.style.color = 'blue';

    countNumber = countAppearance(number, array);

    textLine.innerHTML = 'The number ' + number + ' appearing in the array ' + countNumber + ' times';

    
}

function countAppearance(number, arr) {
    var count = 0;
    for (var i in arr) {

        if (arr[i] === number) {
            count += 1;
        }
    }
    return count;
}

function checkFunctionWork() {
    var textLine = document.getElementById('output2'),
        testNumber = 4,
        testArr = [4, 4, 4, 4, 4];
    var testCount = countAppearance(testNumber, testArr);
    textLine.style.color = 'darkblue';
    if (testCount === 5) {

        textLine.innerHTML = 'The function is working correctly';
    }
    else {
        textLine.innerHTML = 'The function is working NOT correctly';
    }
}

