// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] 
// and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.

function parse(uri) {
    var match = /(.*):\/\/(.*?)(\/.*)/.exec(uri)
    return { protocol: match[1], server: match[2], resource: match[3] }
}
console.log(parse('http://telerikacademy.com/Courses/Courses/Details/239'));