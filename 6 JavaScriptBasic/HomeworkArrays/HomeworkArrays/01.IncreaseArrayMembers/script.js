function printArray() {
    var array = [],
        outputString,
        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

        for (var i = 0; i < 20; i++) {

            array[i] = i * 5;
        }
        
        outputString = array.join(', ').toString();

        textLine.innerHTML = outputString;   
}