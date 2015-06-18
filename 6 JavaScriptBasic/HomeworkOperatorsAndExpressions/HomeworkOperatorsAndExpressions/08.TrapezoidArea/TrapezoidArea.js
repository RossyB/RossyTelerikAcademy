function findTrapezoidArea() {
    var sideA = document.getElementById('input_a').value,
        sideB = document.getElementById('input_b').value,
        heightH = document.getElementById('input_h').value,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!sideA || !sideB || !heightH) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter side a, side b and height h!'
    }
    else {

        var area = ((parseFloat(sideA) + parseFloat(sideB)) * parseFloat(heightH)) / 2;

        textLine.innerHTML = 'The area of trapezoid is: ' + area;
    }
}