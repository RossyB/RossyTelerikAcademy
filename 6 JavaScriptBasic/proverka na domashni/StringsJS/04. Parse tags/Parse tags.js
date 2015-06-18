﻿// You are given a text. Write a function that changes the text in all regions:
// <upcase>text</upcase> to uppercase.
// <mixcase>text</mixcase> to mix casing(random).

function toMixCase(str) {
    var replaced = ''
      , i
    for (i = 0; i < str.length; i++)
        replaced += str.charAt(i)[Math.round(Math.random()) ? 'toLowerCase' : 'toUpperCase']()
    return replaced
}
function changeText(str) {
    return str.replace(/<upcase>(.*?)<\/upcase>/g, function (match, p1) {
        return p1.toUpperCase()
    }).replace(/<lowcase>(.*?)<\/lowcase>/g, function (match, p1) {
        return p1.toLowerCase()
    }).replace(/<mixcase>(.*?)<\/mixcase>/g, function (match, p1) {
        return toMixCase(p1)
    })
}

console.log(changeText('We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>ANYTH<mixcase>living</mixcase>ING</lowcase> else.'))