function convertString() {
    var textLine = document.getElementById('output');
    var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";
    var objText = new String(text);

    textLine.style.color = 'blue';

    objText = doUpCase(objText);
    objText = doLowCase(objText);
    objText = doMixCase(objText);

    textLine.innerHTML = objText;
}

function doUpCase(text) {

    var indexStart = text.indexOf('<upcase>');
    while (indexStart > -1) {
        var findText = text.substring(indexStart + 8, text.indexOf('</upcase>', indexStart));
        var upprerText = findText.toUpperCase();
        text = text.replace(findText, upprerText);
        indexStart = text.indexOf('<upcase>', indexStart + 1);
    }
    return text;
}

function doLowCase(text) {

    var indexStart = text.indexOf('<lowcase>');
    while (indexStart > -1) {
        var findText = text.substring(indexStart + 9, text.indexOf('</lowcase>', indexStart));
        var lowText = findText.toLowerCase();
        text = text.replace(findText, lowText);
        indexStart = text.indexOf('<lowcase>', indexStart + 1);
    }
    return text;
}


function doMixCase(text) {
    var indexStart = text.indexOf("<mixcase>");
    while (indexStart > -1) {
        var findText = text.substring(indexStart + 9, text.indexOf("</mixcase>", indexStart));
        var mixedText = new String(findText);
        for (var i = 0; i < mixedText.length ; i++) {
            if (i % 2 == 0) {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toUpperCase())
            }
            else {
                mixedText = mixedText.replace(mixedText[i], mixedText[i].toLowerCase())
            }
        }
        text = text.replace(findText, mixedText);
        indexStart = text.indexOf("<mixcase>", indexStart + 1);
    }

    return text;
}