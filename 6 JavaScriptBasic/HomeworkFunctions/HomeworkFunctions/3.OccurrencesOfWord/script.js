function checkText() {
    var textLine1 = document.getElementById('output1'),
        textLine2 = document.getElementById('output2'),
        text = 'We are living in an yellow submarine. In the sky there are no clouds. So we are drinking all the day. We will move out of it in 5 days.',
        word = 'in',
        isCaseSensitive = false,
        result = '';

    textLine1.style.color = 'blue';
    textLine2.style.color = 'darkblue';

    function CountOccurenceWord(text, word, isCaseSensitive) {
        isCaseSensitive = isCaseSensitive || false;
        var count = 0;
       
        if (isCaseSensitive === false) {
            var stringArray = text.split(word);  //split is case-insensitive

            for (var str in stringArray) {
                count++;
            }
            result = 'The count of word ' + word + ' (case-insensitive search) is: ' + count;
        }
        else {
            var index = text.indexOf(word); //indexOf is case-sensitive

            while (index >= 0) {
                count++;
                index = text.indexOf(word, index + 1);
            }
            result = 'The count of word "' + word + '" (case-sensitive search) is: ' + count;
        }
    }

    CountOccurenceWord(text, word);
    textLine1.innerHTML = result;
    CountOccurenceWord(text, word, true);
    textLine2.innerHTML = result;
}