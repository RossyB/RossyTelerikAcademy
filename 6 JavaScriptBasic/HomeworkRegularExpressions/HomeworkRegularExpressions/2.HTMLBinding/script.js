String.prototype.bind = function (obj) {
    var prop,
        reContent,
        reHref,
        reClass,
        result = this;

    for (prop in obj) {
        reContent = new RegExp('(<.*data-bind-content="' + prop + '".*>)(.*)(<.*>)', 'gi'),
            reHref = new RegExp('(<.*data-bind-href="' + prop + '")', 'gi'),
            reClass = new RegExp('(data-bind-class="' + prop + '")', 'gi');

        result = result.replace(reContent, function (none, opening, content, closing) {
            content = obj[prop];
            return opening + content + closing;
        })
            .replace(reHref, function (none, content) {
                return content + ' href="' + obj[prop] + '"';
            })
            .replace(reClass, 'data-bind-class="' + obj[prop] + '"');
    }
    return result;
};

console.log('<div data-bind-content="name"></div>'.bind('', { name: 'Steven' }));
console.log('<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></div>'.bind('', { name: 'Elena', link: 'http://telerikacademy.com' }));
