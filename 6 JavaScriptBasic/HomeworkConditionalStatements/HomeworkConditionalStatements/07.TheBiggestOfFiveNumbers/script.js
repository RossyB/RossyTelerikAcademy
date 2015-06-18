function findTheBiggestOfFiveNumbers() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,
        c = document.getElementById('input_c').value,
        d = document.getElementById('input_d').value,
        e = document.getElementById('input_e').value,
        resultAsString,
        biggest,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b || !c || !d || !e) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a, b, c, d and e!'
    }
    else {
       
        var array = [a, b, c, d, e];

        biggest = array[0];

        for (var i = 0; i < array.length; i++) {
            
            if (array[i] > biggest) {
                biggest = array[i];
            }
        }

        textLine.innerHTML = 'The biggest number is: ' + biggest;
    }
}