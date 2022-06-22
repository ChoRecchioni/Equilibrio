﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;
using equilibrio.Clases;


namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDropCat();
            }

            GenerarArticulo();
        }

        public void cargarDropCat()
        {
            CategoriaController.CargarCategoria();

            DropCategoria.DataSource = from cat in CategoriaController.FindAll()
                                       select new
                                       {
                                           codigo = cat.Codigo,
                                           texto = cat.Nombre,
                                       };
            DropCategoria.DataValueField = "codigo";
            DropCategoria.DataTextField = "texto";

            DropCategoria.DataBind();
        }

        public void GenerarArticulo()
        {
            CategoriaController.CargarCategoria();
            ArticuloController.CargarArticulo();

            var listadoArt = from ar in ArticuloController.FindAll()
                             select new
                             {
                                 Codigo = ar.Codigo,
                                 Nombre = ar.Nombre,
                                 Comentario = ar.Comentario,
                                 Precio = ar.Precio,
                                 Categoria = ar.Categoria,
                             };

            var listadoCat = from cat in CategoriaController.FindAll()
                             select new
                             {
                                 Nombre = cat.Nombre
                             };

            foreach (var it in listadoCat)
            {
                HtmlGenericControl divCat = new HtmlGenericControl("div");
                divCat.Attributes.Add("class", "CategoriaCarta");

                Label LblTituloCarta = new Label();
                LblTituloCarta.Attributes.Add("class", "LblTituloCartaCat");
                LblTituloCarta.Text = it.Nombre;

                divCat.Controls.Add(LblTituloCarta);

                foreach (var item in listadoArt.Where(li => li.Categoria.Nombre == it.Nombre))
                {
                    //generamos objeto DIV por cada articulo

                    HtmlGenericControl divArt = new HtmlGenericControl("div");
                    divArt.Attributes.Add("class", "ProductoCarta");

                    HtmlGenericControl NomPCarta = new HtmlGenericControl("div");
                    NomPCarta.Attributes.Add("class", "NomPCarta");

                    Label LblTitulo = new Label();
                    LblTitulo.Attributes.Add("class", "LblTituloCarta");
                    LblTitulo.Text = item.Nombre;
                    HtmlGenericControl br = new HtmlGenericControl("br");

                    NomPCarta.Controls.Add(LblTitulo);

                    HtmlGenericControl PrecProd = new HtmlGenericControl("div");
                    PrecProd.Attributes.Add("class", "PrecProd");

                    Label Lblprecio = new Label();
                    Lblprecio.Attributes.Add("class", "Lbl");
                    Lblprecio.Text = "$" + item.Precio + ".-";
                    Lblprecio.Attributes.Add("style", "font-weight: bold;");

                    ImageButton btnEditar = new ImageButton
                    {
                        CssClass = "BtnFormCA",
                        Height = 20,
                        Width = 20,
                        ImageUrl = "~/IMG/edit.png",
                        OnClientClick = "return EditarArticulo('" + item.Codigo.ToString() + "');",
                        ID = item.Codigo.ToString()
                    };

                    ImageButton btnEliminar = new ImageButton
                    {
                        CssClass = "BtnFormCA",
                        Height = 20,
                        Width = 20,
                        ImageUrl = "~/IMG/delete.png",
                        OnClientClick = "return EliminarArticulo('" + item.Codigo.ToString() + "');",
                        ID = item.Codigo.ToString()
                    };

                    PrecProd.Controls.Add(btnEliminar);
                    PrecProd.Controls.Add(btnEditar);

                    PrecProd.Controls.Add(new LiteralControl("<br/>"));
                    PrecProd.Controls.Add(Lblprecio);

                    HtmlGenericControl InfoPCarta = new HtmlGenericControl("div");
                    InfoPCarta.Attributes.Add("class", "InfoPCarta");

                    Label LblInfo = new Label();
                    LblInfo.Attributes.Add("class", "Lbl");
                    LblInfo.Text = item.Comentario;

                    InfoPCarta.Controls.Add(LblInfo);

                    divArt.Controls.Add(NomPCarta);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(PrecProd);
                    divArt.Controls.Add(new LiteralControl("<br/>"));
                    divArt.Controls.Add(InfoPCarta);

                    divCat.Controls.Add(divArt);
                }
                DivCartas.Controls.Add(divCat);

            }
        }

        protected void BtnCrearArt_Click(object sender, EventArgs e)
        {
            ArticuloController.CargarArticulo();
            int codArt = ArticuloController.ArticuloAI();
            LbAddArt.Text = ArticuloController.AddAarticulo(codArt.ToString(), TxtNombreArt.Text, TxtPrecioArt.Text, TxtDescripcionArt.Text, DropCategoria.SelectedValue);
            Response.Redirect("CartaAdmi.aspx");
        }
    }

}