//Problem 3. Sub-string in text

console.log('Problem 3');

var regex,
    substr = 'in',
    text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

regex = new RegExp(substr, 'ig');
console.log(text.match(regex).length + '\n\r');