function exchangeIfGreater() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a and b!'
    }
    else {
        if (a > b) {

            b = [a, a = b][0];

            textLine.innerHTML = 'Numbers: ' + a + ' ' + b;
        }
        else {

            textLine.innerHTML = 'Numbers: ' + a + ' ' + b;
        }
        
    }
}