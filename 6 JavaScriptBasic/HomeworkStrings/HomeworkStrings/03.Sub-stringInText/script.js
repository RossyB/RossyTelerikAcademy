function findSubString() {
    var textLine = document.getElementById('output');
    var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    var subString = 'in';
    var result = countSubstring(text, subString);

    textLine.style.color = 'blue';

    textLine.innerHTML = 'The substring ' + subString + ' is contained in a given text ' + result + ' times.';

}

function countSubstring(text, sub) {

    text = text.toLowerCase();
    sub = sub.toLowerCase();
    var indexOfSub = text.indexOf(sub);
    var count = 0;
    while (indexOfSub > -1) {
        count++;
        indexOfSub = text.indexOf(sub, indexOfSub + 1);
    }
    return count;
}