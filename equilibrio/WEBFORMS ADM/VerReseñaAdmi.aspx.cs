﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

//Se mostrarán las reservas según local del administrador.
//Filtro de estrellas.

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        public void CargarGrid()
        {
            Usuario u = (Usuario)Session["ActiveUser"];

            var listado = from re in ReseñaController.findAll()
                          select new
                          {
                              Local = re.Sede,
                              Puntuacion = re.puntuacion,
                              Comentario = re.comentario,
                              Usuario = re.Usuario
                          };

            string dropranking = FiltroEstrellas.SelectedValue;


            if (int.Parse(dropranking) == 0)
            {
                foreach (var item in listado)
                {
                    //generamos objeto DIV por cada reseña (con n)
                    HtmlGenericControl divResena = new HtmlGenericControl("div");

                    divResena.Attributes.Add("class", "Reseña");

                    //Si quisieramos generar la etiqueta título:
                    //Label labelTitulo = new Label();
                    //labelTitulo.Text = item.Puntuacion.ToString();
                    //labelTitulo.CssClass = "LblTitulo";
                    //divResena.Controls.Add(labelTitulo);

                    //Recorremos las puntuaciones que trae, para generar
                    //la cantidad de estrellas correspondiente
                    for (int i = 0; i < item.Puntuacion; i++)
                    {
                        //Generamos la imagen de estrella
                        Image imgTitulo = new Image();
                        imgTitulo.Height = 20;
                        imgTitulo.Width = 20;
                        imgTitulo.Style.Add("vertical-align", "bottom");
                        imgTitulo.ImageUrl = "~/IMG/full-star.png";

                        divResena.Controls.Add(imgTitulo);
                    }

                    //Generamos un Lbl con su clase de css de título
                    Label labelTituloComentario = new Label();
                    labelTituloComentario.CssClass = "LblTitulo";
                    labelTituloComentario.Text = "  - COMENTARIO: ";

                    //Generamos el comentario de cada reseNa
                    Label labelComentario = new Label();
                    labelComentario.CssClass = "Lbl";
                    labelComentario.Text = item.Comentario;

                    //Agregamos los objetos al nuevo div instanciado (linea 35)   
                    divResena.Controls.Add(labelTituloComentario);
                    divResena.Controls.Add(labelComentario);

                    //generamos objeto DIV por cada reseña (con n)
                    HtmlGenericControl divResenaUsuario = new HtmlGenericControl("div");

                    divResenaUsuario.Attributes.Add("class", "Usuario");

                    Label labelCliente = new Label();
                    labelCliente.CssClass = "LblTitulo";
                    labelCliente.Text = "CLIENTE: ";


                    Label labelClienteC = new Label();
                    labelClienteC.CssClass = "Lbl";
                    labelClienteC.Text = item.Usuario.nombre + " " + item.Usuario.apellido;

                    Label labelDatos = new Label();
                    labelDatos.CssClass = "LblTitulo";
                    labelDatos.Text = "  TELÉFONO: ";

                    Label labelDatos1 = new Label();
                    labelDatos1.CssClass = "Lbl";
                    labelDatos1.Text = item.Usuario.telefono;

                    divResenaUsuario.Controls.Add(labelCliente);
                    divResenaUsuario.Controls.Add(labelClienteC);
                    divResenaUsuario.Controls.Add(labelDatos);
                    divResenaUsuario.Controls.Add(labelDatos1);

                    divResena.Controls.Add(divResenaUsuario);

                    DivResenas.Controls.Add(divResena);
                }
            }
            else if (int.Parse(dropranking) > 1)
            {
                foreach (var item in listado.Where(L => L.Local.codigo == u.Sede.codigo && L.Puntuacion.ToString() == dropranking))
                {
                    //generamos objeto DIV por cada reseña (con n)
                    HtmlGenericControl divResena = new HtmlGenericControl("div");

                    divResena.Attributes.Add("class", "Reseña");

                    //Si quisieramos generar la etiqueta título:
                    //Label labelTitulo = new Label();
                    //labelTitulo.Text = item.Puntuacion.ToString();
                    //labelTitulo.CssClass = "LblTitulo";
                    //divResena.Controls.Add(labelTitulo);

                    //Recorremos las puntuaciones que trae, para generar
                    //la cantidad de estrellas correspondiente
                    for (int i = 0; i < item.Puntuacion; i++)
                    {
                        //Generamos la imagen de estrella
                        Image imgTitulo = new Image();
                        imgTitulo.Height = 20;
                        imgTitulo.Width = 20;
                        imgTitulo.Style.Add("vertical-align", "bottom");
                        imgTitulo.ImageUrl = "~/IMG/full-star.png";

                        divResena.Controls.Add(imgTitulo);
                    }

                    //Generamos un Lbl con su clase de css de título
                    Label labelTituloComentario = new Label();
                    labelTituloComentario.CssClass = "LblTitulo";
                    labelTituloComentario.Text = "  - COMENTARIO: ";

                    //Generamos el comentario de cada reseNa
                    Label labelComentario = new Label();
                    labelComentario.CssClass = "Lbl";
                    labelComentario.Text = item.Comentario;

                    //Agregamos los objetos al nuevo div instanciado (linea 35)   
                    divResena.Controls.Add(labelTituloComentario);
                    divResena.Controls.Add(labelComentario);

                    //generamos objeto DIV por cada reseña (con n)
                    HtmlGenericControl divResenaUsuario = new HtmlGenericControl("div");

                    divResenaUsuario.Attributes.Add("class", "Usuario");

                    Label labelCliente = new Label();
                    labelCliente.CssClass = "LblTitulo";
                    labelCliente.Text = "CLIENTE: ";


                    Label labelClienteC = new Label();
                    labelClienteC.CssClass = "Lbl";
                    labelClienteC.Text = item.Usuario.nombre + " " + item.Usuario.apellido;

                    Label labelDatos = new Label();
                    labelDatos.CssClass = "LblTitulo";
                    labelDatos.Text = "  TELÉFONO: ";

                    Label labelDatos1 = new Label();
                    labelDatos1.CssClass = "Lbl";
                    labelDatos1.Text = item.Usuario.telefono;

                    divResenaUsuario.Controls.Add(labelCliente);
                    divResenaUsuario.Controls.Add(labelClienteC);
                    divResenaUsuario.Controls.Add(labelDatos);
                    divResenaUsuario.Controls.Add(labelDatos1);

                    divResena.Controls.Add(divResenaUsuario);

                    DivResenas.Controls.Add(divResena);
                }
            }

           
        }

        protected void FiltroEstrellas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}