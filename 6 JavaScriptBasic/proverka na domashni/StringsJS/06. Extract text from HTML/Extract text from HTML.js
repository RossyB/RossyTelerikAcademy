// Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

function extractText(html) {
    return html.replace(/<(.*?)>/g, '')
}
console.log(extractText('<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>'));