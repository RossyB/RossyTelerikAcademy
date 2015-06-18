// Write a function that formats a string using placeholders.
// The function should work with up to 30 placeholders and all types.

function format(str) {
    var selfArguments = arguments
    return str.replace(/\{(\d+)\}/g, function (match, p1) {
        return selfArguments[+p1 + 1]
    })
}
console.log(format('{0}, {1}!', 'Hello', 'World'));