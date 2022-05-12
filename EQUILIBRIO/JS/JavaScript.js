$(document).ready(function () {

    //$('.nav .menu > .item-submenu a').click(function () {
    //    //captura valor de atributo menu
    //    var posicionMenu = $(this).parent().attr('menu');
    //    $('.item-submenu[menu=' + posicionMenu + '] .submenu').css({ 'visibility' : 'hidden' });
    //});

    var coll = document.getElementsByClassName("subm");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener("click", function () {
            this.classList.toggle("active");
            var content = this.nextElementSibling;
            if (content.style.display === "block") {
                content.style.display = "none";
            } else {
                content.style.display = "block";
            }
        });
    }


});