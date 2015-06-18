//Problem 7. Parse URL

console.log('Problem 7');

var str = 'http:///telerikacademy.com/Courses/Courses/Details/239';

function buildAnswer(prot, serv, res) {
    var url = {
        protocol: prot,
        server: serv,
        resource: res
    };

    return url;
}

function parseUrl(url) {
    var answer,
        props,
        object = '{ ',
        i = 0,
        protocol = '',
        server = '',
        resource = '',
        len = url.length;

    while (url[i] !== ':') {
        protocol += url[i];
        i += 1;
    }
    i += 4;
    while (url[i] !== '/') {
        server += url[i];
        i += 1;
    }
    while (i !== len) {
        resource += url[i];
        i += 1;
    }
    answer = buildAnswer(protocol, server, resource);
    
    for (props in answer) {
        object += props + ': ' + answer[props];
    }
    object += ' }'
    console.log(object + '\n\r');
}

parseUrl(str);
