// Write a JavaScript function that finds how many times a substring is 
// contained in a given text (perform case insensitive search).

function countRepeatingSubstring(text, word) {
    var match = text.match(new RegExp(word, 'gi'))
    return match && match.length || 0
}
console.log(countRepeatingSubstring('We are living in an yellow submarine.We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.', 'in'))
