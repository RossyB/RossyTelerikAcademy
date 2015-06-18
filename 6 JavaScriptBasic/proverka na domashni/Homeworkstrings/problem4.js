//Problem 4. Parse tags

console.log('Problem 4');

var str = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anYTHIng</lowcase> else.'

function changeText(text) {
    var i,
        len,
        answer = '';

    len = text.length;

    for (i = 0; i < len; i += 1) {
        if (text[i] === '<' && text[i + 1] === 'u') {
            i += 8;
            while (text[i] !== '<') {
                answer += text[i].toUpperCase();
                i += 1;
            }
            if (text[i + 1] === '/') {
                i += 8;
            }
            else {
                i--;
            }
        } else if (text[i] === '<' && text[i + 1] === 'm') {
            i += 9;
            while (text[i] !== '<') {
                if (Math.random() < 0.5) {
                    answer += text[i].toUpperCase();
                    i += 1;
                }
                else {
                    answer += text[i].toLowerCase();
                    i += 1;
                }
            }
            if (text[i + 1] == '/') {
                i += 9;
            } else {
                i--;
            }
        } else if (text[i] === '<' && text[i + 1] === 'l') {
            i += 9;
            while (text[i] !== '<') {
                answer += text[i].toLowerCase();
                i += 1;
            }
            if (text[i + 1] == '/') {
                i += 9;
            } else {
                i--;
            }
        } else {
            answer += text[i];
        }
    }

    return answer;
}

console.log(changeText(str) + '\n\r');

