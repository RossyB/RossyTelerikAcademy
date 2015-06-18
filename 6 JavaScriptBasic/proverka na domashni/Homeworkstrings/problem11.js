//Problem 11. String format

console.log('Problem 11');

function formatString() {
    var i,
        args = arguments,
		answer = args[0],
		placeholder;

    for (i = 1; i < args.length; i += 1) {
        placeholder = '{' + (i - 1) + '}';

        while (answer.indexOf(placeholder) > -1) {
            answer = answer.replace(placeholder, args[i]);
        }
    }

    return answer;
}

console.log(formatString('{0}, {1}, {0} text {2}', 1, 'Pesho', 'Gosho'));



