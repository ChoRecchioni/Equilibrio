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

    $('#cart').click(function () {
        if ($('.Container').is(':visible')) {
            $('.Container').css({ 'display': 'none' });
        } else {
            $('.Container').css({ 'display': 'block' });
        }

    });

    var mytext = document.querySelector(".LblInfoProd");
    var mytextHeight = mytext.offsetHeight;
    var mytextstyle = window.getComputedStyle(mytext);

    if (mytextHeight > 22) {
        do {
            var fz = mytextstyle.getPropertyValue("font-size");
            fz = parseInt(fz.slice(0, -2)) - 1;
            mytext.style["font-size"] = fz + "px";
            mytextHeight = mytext.offsetHeight;
        } while (mytextHeight > 22);
    }

});

function Restar(id) {
    if (parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) > 0) {
        if (parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) - 1 === 0) {
            $("#li" + id).remove();
        }

        $("#ContentPlaceHolder1_LblArticulo" + id).text(parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) - 1);
        $("#lblCantCarro" + id).text($("#ContentPlaceHolder1_LblArticulo" + id).text());
        $("#lblPrecioCarro" + id).text(formatter.format(parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) * parseFloat($("#ContentPlaceHolder1_LblBotProd" + id).text().replace('$', '').replace('.', '').replace('-', ''))) + ".-");
    }
    sumaTotal();
    return false;
}

function sumaTotal() {
    var total = 0;
    $(".itemPrecio").each(function () {
        total = total + parseFloat(this.innerText.replace('$', '').replace('.', '').replace('-', ''));
    });
    $("#precioTotal").text(formatter.format(total) + ".-");
}

const formatter = new Intl.NumberFormat('es-CL', {
    style: 'currency',
    currency: 'CLP',
    minimumFractionDigits: 0
});

function Sumar(id) {
    $("#ContentPlaceHolder1_LblArticulo" + id).text(parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) + 1);
    if ($("#li" + id).length) {
        $("#lblCantCarro" + id).text($("#ContentPlaceHolder1_LblArticulo" + id).text());
        $("#lblPrecioCarro" + id).text(formatter.format(parseInt($("#ContentPlaceHolder1_LblArticulo" + id).text()) * parseFloat($("#ContentPlaceHolder1_LblBotProd" + id).text().replace('$', '').replace('.', '').replace('-', ''))) + ".-");
    }
    else {
        var li = document.createElement('li');
        li.setAttribute("class", "CarroItem");
        li.setAttribute("id", "li" + id);

        var itemNombre = document.createElement('label');
        itemNombre.setAttribute("class", "itemNombre");
        itemNombre.textContent = $("#ContentPlaceHolder1_LblNombreProducto" + id).text();

        var itemPrecio = document.createElement('label');
        itemPrecio.setAttribute("class", "itemPrecio");
        itemPrecio.textContent = $("#ContentPlaceHolder1_LblBotProd" + id).text();
        itemPrecio.setAttribute("id", "lblPrecioCarro" + id);

        var itemCantidad = document.createElement('label');
        itemCantidad.setAttribute("class", "itemCantidad");
        itemCantidad.textContent = $("#ContentPlaceHolder1_LblArticulo" + id).text();
        itemCantidad.setAttribute("id", "lblCantCarro" + id);

        li.append(itemNombre, itemPrecio, itemCantidad);

        $(".CarroItems").append(li);
    }
    sumaTotal();
    return false;
}

function BtnPagar() {
    if (confirm("¿Pagar?")) {
        var listaProductos = [];
        $(".CarroItem").each(function () {
            listaProductos.push({ "id": this.id.replace("li", ""), "cantidad": $("#lblCantCarro" + this.id.replace("li", "")).text() });
        });

        $.ajax({
            type: "post",
            url: "CarroCompras.aspx/GenerarCarro",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ usuario: $("#HdnCodUser").val(), lista: listaProductos }),
            dataType: "json",
            success: function (response) {
                if (!response.d.error) {
                    window.location = "CarroCompras.aspx?ID=" + response.d.idCarro;
                }
                else {
                    alert(response.d.msg);
                }
            },
            error: function (response) {
                alert("Error: " + response.d.msg);
            },
            async: true
        });

        return false;
    }
}