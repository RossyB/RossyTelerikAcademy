// Write a function that creates a HTML UL using a template for every HTML LI. The source of the list
// should an array of elements. Replace all placeholders marked with –{…}– with the value of
// the corresponding property of the object.
// to view the result, start index.html and click the 'Generate List' button.

var people = [
    {name: 'Ivan', age: 23},
    {name: 'George', age: 35},
    {name: 'Niki', age: 15},
    {name: 'Eva', age: 31},
    {name: 'Lili', age: 30}],
	template = document.getElementById('list-item').innerHTML;

function generateList() {
    var ul = document.createElement('ul');

    for (var ind in people) {
        var li = document.createElement('li');
        li.innerHTML = format(template, people[ind]);
        ul.appendChild(li);
    }
    document.body.appendChild(ul);
};

function format(string, person){
    return string.replace(/\-{(\w+)\}-/g, function (match, prop) {
        return person[prop] || '';
    });
}