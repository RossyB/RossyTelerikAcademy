function extractingAllEmail() {

    var inputString = document.getElementById('input_string').value,
        outputString = '';
        textLine = document.getElementById('output');
    

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a string!'
    }
    else {

        var validMail = /(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@[\w*]{2,}.[\w*]{2,}\s/gi;
        var vMail = /(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@[\w*]{2,}.[\w*]{2,}\S[\w*]{2,}/gi;
        var result = [];
        result.push(inputString.match(validMail));
        result.push(inputString.match(vMail));

        textLine.innerHTML = result.toString();
    }
}
