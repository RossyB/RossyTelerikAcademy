function create() {
        
    var textLine = document.getElementById('output');

    textLine.style.color = 'blue';

        var people = [
                { name: "Peter", age: 14 },
                { name: "Adasha", age: 5 },
                { name: "Joro", age: 20 },
        ];
        var template = document.getElementById("list-item").innerHTML.valueOf();
        var peopleList = generateList(people, template);
        textLine.innerHTML = peopleList;
       
        textLine.innerHTML = output.join(', ');
    }

function generateList(ppl, tmpl) {
    var i;
    var list = "<ul>";
    for (i = 0; i < ppl.length; i++) {
        list += "<li>";
        list += tmpl.replace("-{name}-", ppl[i]["name"]);
        list = list.replace("-{age}-", ppl[i]["age"]);
        list += "</li>";
    }
    list += "</ul>";
    return list;
}
