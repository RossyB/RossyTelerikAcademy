﻿// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

(function () {
    'use strict';
    function isPalindrome(str) {
        var i
        for (i = 0; i < parseInt(str.length / 2, 10) ; i++)
            if (str[i] !== str[str.length - 1 - i])
                return false
        return true
    }
    var str = 'Static void Main() ABBA, using System lamal, exe.';
    console.log(str.match(/\w+/g).filter(function (word) {
        return isPalindrome(word);
    }))
}());