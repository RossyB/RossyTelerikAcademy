function findPointInCircleAndOutsideRectangle() {
    var x = document.getElementById('input_x').value,
        y = document.getElementById('input_y').value,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!x || !y) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter x and y!'
    }
    else {

        if ((((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9) && ((x < -1) || ((x >= -1) && ((y <= -1) || (y >= 1))))) {

            textLine.innerHTML = 'The point is inside or on the circle and out of the rectangle!';
        }
        else {

            textLine.innerHTML = 'The point is NOT inside or on the circle and out of the rectangle!';
        }
    }
}