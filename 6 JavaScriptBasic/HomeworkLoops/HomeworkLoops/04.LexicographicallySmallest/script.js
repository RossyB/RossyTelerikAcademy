function findSmalestAndLargestProperty() {

    var outputString = '',
    textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    var windowArr = [];

    for (var property in window) {

        windowArr.push(property);
    }

    windowArr.sort();

    outputString += 'window object: smallest: ' + windowArr[0] + '; largest: ' + windowArr[windowArr.length - 1] + '</br>';
       
    var documentArr = [];

    for (var property in document) {

        documentArr.push(property);
    }

    documentArr.sort();

    outputString += 'document object: smallest: ' + documentArr[0] + '; largest: ' + documentArr[documentArr.length - 1] + '</br>';

    var navigatorArr = [];

    for (var property in navigator) {

        navigatorArr.push(property);
    }

    navigatorArr.sort();

    outputString += 'navigator object: smallest: ' + navigatorArr[0] + ';  largest: ' + navigatorArr[navigatorArr.length - 1] + '</br>';

    textLine.innerHTML = outputString;
    
}