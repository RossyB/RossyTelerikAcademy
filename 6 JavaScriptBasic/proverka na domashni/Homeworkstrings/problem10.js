//Problem 10. Find palindromes

console.log('Problem 10');

var text = 'ABBA lamal exe kemek adsf asdfgfdsa jiad9034m kmladsfmkl';

function isPlaindrome(word) {
    var ind;

    for (ind = 0; ind < word.length / 2; ind++) {
        if (word[ind] !== word[word.length - ind - 1]) {
            return false;
        }
    }
    return true;
}

function extractPalindromes(text) {
    var ind,
        palindromes = [];
    
    text = text.split(' ');

    for (ind in text) {
        if (isPlaindrome(text[ind])) {
            palindromes.push(text[ind]);
        }
    }

    return palindromes;
}

console.log(extractPalindromes(text).join(', ') + '\n\r');

