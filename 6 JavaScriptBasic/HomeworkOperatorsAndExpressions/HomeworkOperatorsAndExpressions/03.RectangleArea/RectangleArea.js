function findRectangleArea() {
    var width = document.getElementById('input_width').value,
        height = document.getElementById('input_height').value,
        rectArea,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!width || !height) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the width and height!'
    }
    else {

        rectArea = width * height;
        textLine.innerHTML = 'The rectangle area is: ' + rectArea;
    }
}