function findTheBiggestOfThree() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,
        c = document.getElementById('input_c').value,
        biggestnumber,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b || !c) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a, b and c!'
    }
    else {

        if (a < b) {

            if (b < c){

                biggestnumber = c;
            }

            else {
                biggestnumber = b;
            }
        }
        
        else {

            if (a < c) {

                biggestnumber = c;
            }
            else {

                biggestnumber = a;
            }
        }

        textLine.innerHTML = 'Biggest number is: ' + biggestnumber;
    }
}