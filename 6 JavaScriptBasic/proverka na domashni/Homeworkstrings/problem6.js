//Problem 6. Extract text from HTML

console.log('Problem 6');

var str = "<html>                 \
              <head>               \
                <title>Sample site</title>            \
              </head>  \
              <body>      \
                <div>text            \
                  <div>more text</div>  \
              and more...  \
                </div>  \
                in body  \
                </body>  \
            </html>"

function htmlExtractText(text) {
    var i,
        curr,
        flag = true,
        answer = '',
        len = text.length;

    for (i = 0 ; i < len ; i += 1) {
        curr = text[i];
        if (curr === '<') {
            flag = false;
        } else if (curr === '>') {
            flag = true;
        } else if (curr === '\\') {
            answer += '';
        } else if (flag) {
            if ((curr >= 'a' && curr <= 'z') || (curr >= 'A' && curr <= 'Z')) {
                answer += curr;
            }
            if (curr === ' ' && text[i - 1] >= 'a' && text[i - 1] <= 'z' && text[i + 1] >= 'a' && text[i + 1] <= 'z') {
                answer += ' ';
            }
        }
    }

    return answer;
}

console.log(htmlExtractText(str) + '\n\r');