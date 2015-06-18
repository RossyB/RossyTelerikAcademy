function parseURL() {

    var inputString = document.getElementById('input_string').value,

        outputString = '',

        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter an URL!'
    }
    else {

        var protocol = inputString.substring(0, inputString.indexOf(':'));
        var server = inputString.substring(inputString.indexOf(':') + 3, inputString.indexOf('/', inputString.indexOf(':') + 3));
        var resourse = inputString.substr(inputString.indexOf('/', inputString.indexOf(':') + 3) + 1);

        var urlAsJSON = {
            'protocol': protocol,
            'server': server,
            'resourse': resourse,
            toString: function () {
                return 'Protocol: ' + urlAsJSON.protocol + ',<br /> Server: ' + urlAsJSON.server + ',<br /> Resourse: ' + urlAsJSON.resourse;
            }
        }
        textLine.innerHTML = urlAsJSON.toString();
    }  
}