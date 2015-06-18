function sort3Numbers() {
    var a = document.getElementById('input_a').value,
        b = document.getElementById('input_b').value,
        c = document.getElementById('input_c').value,
        sortedNumbers,

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!a || !b || !c) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter the a, b and c!'
    }
    else {

        if (a >= b) {

            if (b >= c) {

                sortedNumbers = a + ' ' + b + ' ' + c;
            }

            else {

                if (c > a) {

                    sortedNumbers = c + ' ' + a + ' ' + b;
                }

                else {

                    sortedNumbers = a + ' ' + c + ' ' + b;
                }
            }
        }

        else {

            if (b >= c) {

                if (a >= c) {

                    sortedNumbers = b + ' ' + a + ' ' + c;
                }

                else {

                    sortedNumbers = b + ' ' + c + ' ' + a;
                }
            }

            else {

                sortedNumbers = c + ' ' + b + ' ' + a;
            }
        }

        textLine.innerHTML = 'Sorted numbers are: ' + sortedNumbers;
    }
}