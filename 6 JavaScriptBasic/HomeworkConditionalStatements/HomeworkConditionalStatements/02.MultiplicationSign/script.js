function calculateMultiplicationSign() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,
        c = document.getElementById('input_c').value,
        flag = 0,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b || !c) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a, b and c!'
    }
    else {

        if (a < 0) {
            flag += 1;
        }
        if (b < 0) {
            flag += 1;
        }
        if (c < 0) {
            flag += 1;
        }
      
        if (flag % 2 === 0) {

            textLine.innerHTML = 'The product of three numbers is positive';
        }
        else {

            textLine.innerHTML = 'The product of three numbers is negative';
        }
    }
}