//Problem 8. Replace tags

console.log('Problem 8');

var str = "<p>Please visit <a href='http://academy.telerik.com'>our site</a> to choose a training course. Also visit <a href='www.devbg.org'>our forum</a> to discuss the courses.</p>"

function replaceTags(text) {
    var i,
        len = text.length,
        ans = '';

    for (i = 0 ; i < len ; i += 1) {
        if (text[i] === '<') {
            if(text[i + 1] === 'a') {
            ans += '[URL=';
            i += 8;
            continue;    
            } else if (text[i + 1] === '/' && text[i + 2] === 'a') {
                ans += '[/URL]';
                i += 3;
                continue;
            }
        } else if (text[i] === '\'' && text[i+1] === '>') {
            ans += ']';
            i += 1;
            continue;
        } else {
            ans += text[i];
        }
    }

    return ans;
}

console.log(replaceTags(str) + '\n\r');