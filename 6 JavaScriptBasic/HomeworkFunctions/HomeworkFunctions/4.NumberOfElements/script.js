function countDivs() {
    var textLine = document.getElementById('output'),
        count;

    textLine.style.color = 'blue';

    count = document.getElementsByTagName('div').length;

    
    textLine.innerHTML = 'The number of divs in your page is ' + count;
}