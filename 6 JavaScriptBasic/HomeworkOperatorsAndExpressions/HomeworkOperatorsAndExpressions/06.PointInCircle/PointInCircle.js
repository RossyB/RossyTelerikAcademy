function findPointInCircle() {
    var pointX = document.getElementById('input_x').value,
        pointY = document.getElementById('input_y').value,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!pointX || !pointY) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter x and y!'
    }
    else {

        var radius = 5;

        if ((pointX * pointX + pointY * pointY) < radius * radius) {
            textLine.innerHTML ='Point (' + pointX + ',' + pointY + ') is within circle K(0,5)';
        }
        else {
            textLine.innerHTML ='Point (' + pointX + ',' + pointY + ') is outside circle K(0,5)';
        }
    }
}