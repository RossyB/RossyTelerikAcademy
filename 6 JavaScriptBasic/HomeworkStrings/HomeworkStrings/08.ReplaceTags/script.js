function replaceTags() {
    var textLine = document.getElementById('output');

    var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    var index = text.indexOf('<a');

    while (index > -1) {
        text = text.replace('<a', '[URL');
        text = text.replace('</a>', '[/URL]');
        index = text.indexOf('<a');

        for (var i = 0; i < text.length - 1; i++) {
            if (text[i] == '\"' || text[i] == '\'' && text[i + 1] == '>') {
                text = text.substr(0, i) + ']' + text.substr(i + 2);
            }
        }
    }

    textLine.style.color = 'blue';

    textLine.innerHTML = text;
}