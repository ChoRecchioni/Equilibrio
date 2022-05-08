﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="equilibrio.METODOS.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>EQUILIBRIO</title>

    <link href="../CSS/css.css" type="text/css" rel="stylesheet" />
    <script src="../JS/query.js"></script>
    <script src="../JS/JavaScript.js"></script>

</head>
<body>
    <section id="transparencia"></section>
    <header>
        <section id="redes">
            <a id="fb" href="http://www.facebook.com">
                <img class="red" src="../IMG/fb.png"></img></a>
            <a id="ig" href="http://www.instagram.com">
                <img class="red" src="../IMG/instagram.png" /></a>
            <img id="divisor" src="../IMG/line.png" />
            <a id="user" href="">
                <img class="opUser" src="../IMG/user.png" /></a>
            <a id="cart" href="">
                <img class="opUser" src="../IMG/cart.png" /></a>
        </section>
        <section id="titulo">
        </section>
        <section id="menu">
            <a id="logo" href="inicio.aspx">
                <img class="logo" src="../IMG/logo equilibrio.png"></img></a>
            <div class="curved-text">
                <span class="letra">E</span>
                <span class="letra">Q</span>
                <span class="letra">U</span>
                <span class="letra">I</span>
                <span class="letra">L</span>
                <span class="letra">I</span>
                <span class="letra">B</span>
                <span class="letra">R</span>
                <span class="letra">I</span>
                <span class="letra">O</span>
            </div>

            <nav class="nav">
                <!--Menu-->
                <ul class="menu">
                    <!--Submenu 1-->
                    <li class="item-submenu" menu="2">
                        <a href="#" class="subm"><span>RESERVAS</span></a>
                        <ul class="submenu">
                            <li class="MisReservas"><a href="#">MIS RESERVAS</a></li>
                            <li class="AddReserva"><a href="#">NUEVA RESERVA</a></li>
                        </ul>
                    </li>
                    <!--Fin submenu 1-->
                    <li class="Deli"><a href="#"><span>DELIVERY</span></a></li>
                    <li class="Carta"><a href="#"><span>CARTA</span></a></li>
                    <li class="Local"><a href="#"><span>LOCALES</span></a></li>
                    <li class="Preg"><a href="#"><span>PREGUNTAS FRECUENTES</span></a></li>
                    <!--Submenu 2-->
                    <li class="item-submenu" menu="1">
                        <a href="#" class="subm"><span>RESEÑAS</span></a>
                        <ul class="submenu">
                            <li class="Reseñas"><a href="#">RESEÑAS</a></li>
                            <li class="AddReseña"><a href="#">NUEVA RESEÑA</a></li>
                        </ul>
                    </li>
                    <!--Fin submenu 2-->
                </ul>
                <!--Fin Menu-->
            </div>
        </section>
    </header>
</body>
</html>
