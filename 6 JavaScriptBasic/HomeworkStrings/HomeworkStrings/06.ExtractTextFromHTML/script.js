function extractText() {
    var textLine = document.getElementById('output');
    var text = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

    var result = '';
    var indexRightBraket = text.indexOf('>');

    while (indexRightBraket > -1 && indexRightBraket < text.length - 1) {

        if (indexRightBraket +1 != '<') {

            var stringStart = text.substring(indexRightBraket + 1, text.indexOf('<', indexRightBraket + 1));
            result += stringStart + ' ';
        }
        indexRightBraket = text.indexOf('>', indexRightBraket + 1);
    }

    textLine.style.color = 'blue';

    textLine.innerHTML = result;
}