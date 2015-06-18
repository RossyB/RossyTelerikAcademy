// Write a function that replaces non breaking white-spaces in a text with &nbsp;

function escapeWhiteSpace(text) {
    return text.replace(/ /g, '&nbsp;')
}
console.log(escapeWhiteSpace('  hello    world '))