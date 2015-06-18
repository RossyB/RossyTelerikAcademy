//Problem 5. nbsp

console.log('Problem 5');

str = 'Telerik Academy System';

function replaceSpace(text) {
    var answer = '';
    answer = str.replace(/ /g, '&nbsp');
    return answer;
}
console.log(replaceSpace(str) + '\n\r');