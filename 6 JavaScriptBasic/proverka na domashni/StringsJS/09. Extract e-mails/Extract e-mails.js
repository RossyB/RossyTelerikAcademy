// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.

(function () {
    'use strict';
    var str = 'Static void Main() ivanov@telerik.com. using System,ivanov@gmail.com return'
    console.log(str.match(/\w+@\w+\.\w+/g))
}());