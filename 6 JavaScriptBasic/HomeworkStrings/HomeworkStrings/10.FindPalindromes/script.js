function findPalindromes() {

    var inputString = document.getElementById('input_string').value,
        output = [],
        textLine = document.getElementById('output');

    textLine.style.color = 'blue';

    if (!inputString) {

        textLine.style.color = 'red';
        textLine.innerHTML = 'Please enter a string!'
    }
    else {
        
        var words = inputString.split(" ");
        var isPalindrome = false;
        var word = "";
        console.log(words.length);

        for (var index = 0; index < words.length; index++) {

            word = words[index];

            for (var i = 0; i < parseInt(word.length / 2) ; i++) {

                if (word[i] == word[word.length - 1 - i]) {
                    isPalindrome = true;
                }
                else {
                    isPalindrome = false;
                }
            }
            if (isPalindrome && word.length > 1) {
                output.push(word);
            }
        }
        textLine.innerHTML = output.join(', ');
    }
}

