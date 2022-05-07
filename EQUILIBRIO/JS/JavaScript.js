$(document).ready(function () {

    circle = document.getElementById("circle")
    circlearray = circle.textContent.split('')
    circle.textContent = ''
    for (var i = 0; i < circlearray.length; i++) {
        circle.innerHTML += '<span style="transform:rotate(' + ((i + 1) * 10 + (-230)) + 'deg)">' + circlearray[i] + '</span>'
    }

    


});