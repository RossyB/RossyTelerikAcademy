﻿function solve() {



}


var test1 = [
'    6',
'    title:Telerik Academy',
'    showSubtitle:true',
'    subTitle:Free training',
'    showMarks:false',
'    marks:3,4,5,6',
'students:Pesho,Gosho,Ivan',
'42',
'@section menu {',
'    <ul id="menu">',
'    <li>Home</li>',
'    <li>About us</li>',
'    </ul>',
'}',
'@section footer {',
'   <footer>',
'    Copyright Telerik Academy 2014',
'    </footer>',
'}',
'<!DOCTYPE html>',
'<html>',
'<head>',
'<title>Telerik Academy</title>',
'</head>',
'<body>',
'@renderSection("menu")',
'<h1>@title</h1>',
'@if (showSubtitle) {',
'    <h2>@subTitle</h2>',
'    <div>@@JustNormalTextWithDoubleKliomba ;)</div>',
'}',
'<ul>',
'@foreach (var student in students) {',
'    <li>',
'    @student',
'    </li>',
'    <li>Multiline @title</li>',
'}',
'</ul>',
'@if (showMarks) {',
'    <div>',
'    @marks',
'    </div>',
'    academy.telerik.com',
'    Telerik Software Academy 2014 6 of 6 facebook.com/TelerikAcademy',
'}',
'@renderSection("footer")',
'</body>',
'</html>'
]

