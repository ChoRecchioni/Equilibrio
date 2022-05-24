$(document).ready(function () {

    //función menu colapsable
    var coll = document.getElementsByClassName("subm");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener("click", function () {

            this.classList.toggle("active");
            var content = this.nextElementSibling;

            if (content.style.display === "block") {
                content.style.display = "none";
                $(this).find(".worra").removeClass("worra").addClass("arrow")
            } else {
                content.style.display = "block";
                $(this).find(".arrow").removeClass("arrow").addClass("worra")
            }
        });
    }

    //var btnE = document.getElementById("BtnEditar");
    //var btnC = document.getElementById("BtnEditConfirm");

    //btnE[i].addEventListener("click", function () {
    //    if (btnE.style.display === "block") {
    //        btnE.style.display = "none";
    //        btnC.style.display = "block";
    //    }
    //});

    //btnC[i].addEventListener("click", function () {
    //    if (btnC.style.display === "block") {
    //        btnC.style.display = "none";
    //        btnE.style.display = "block";
    //    }
    //});

    //$('#BtnEditar').click(function () {
    //    $('#BtnEditar').css({ 'display': 'none' });
    //    $('#BtnEditConfirm').css({ 'display': 'block' });
    //});


});