function findThirdBit() {
    var number = document.getElementById('input_number').value;
    var textLine = document.getElementById('output');
    textLine.style.color = 'blue';

    if (!number) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the number!'
    }

    else {
        var a = 3;

        var mask = 1 << a;
        var result = number & mask;
        var bit = result >> a;

        textLine.innerHTML = 'Third bit of number ' + number.toString(2) + ' is: ' + bit;
       
    }

}