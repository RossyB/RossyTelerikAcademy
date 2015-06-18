function quadraticEquation() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,
        c = document.getElementById('input_c').value,
        x1,
        x2,
        resultAsString,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b || !c) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a, b and c!'
    }
    else {
        var d = (b * b) - 4 * (a * c);

        if (d < 0) {

            resultAsString = 'The equation has no real roots';
        }

        else if (d === 0) {

            x1 = (-b) / (2 * a);

            resultAsString = 'The equation has one root x = ' + x1;
        }
        else if (d > 0) {

            x1 = (-b + Math.sqrt(d)) / (2 * a);
            x2 = (-b - Math.sqrt(d)) / (2 * a);

            resultAsString = 'The equation has two roots x1 = ' + x1 + ' x2 = ' + x2;
        }

        

        textLine.innerHTML = resultAsString;
    }
}