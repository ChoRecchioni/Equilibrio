﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaReservas(new Usuario());
        }

        public void CargaReservas(Usuario usuario)
        {
            UsuarioController.CargarUsuario();
            ReservaController.CargarReserva();
            var reservas = ReservaController.FindAll();

            if (usuario != null)
                reservas.Where(r => r.Usuario.Codigo == usuario.Codigo);

            foreach (var item in reservas)
            {
                HtmlGenericControl Table = new HtmlGenericControl("table");
                Table.Attributes.Add("class", "auto-style1");

                HtmlGenericControl trFechaHora = new HtmlGenericControl("tr");
                HtmlGenericControl tdFecha = new HtmlGenericControl("td");
                tdFecha.Attributes.Add("class", "auto-style2");

                Label lblTituloFecha = new Label();
                lblTituloFecha.Attributes.Add("class", "TxtReserva");
                lblTituloFecha.Text = "FECHA:";

                Label lblFecha = new Label();
                lblFecha.Attributes.Add("class", "TxtReserva");
                lblFecha.Text = item.FechaHora.ToShortDateString();
                lblFecha.CssClass = "lblReserva";

                tdFecha.Controls.Add(lblTituloFecha);
                tdFecha.Controls.Add(lblFecha);
                trFechaHora.Controls.Add(tdFecha);

                HtmlGenericControl tdHora = new HtmlGenericControl("td");
                tdFecha.Attributes.Add("class", "auto-style3");

                Label lblTituloHora = new Label();
                lblTituloHora.Attributes.Add("class", "TxtReserva");
                lblTituloHora.Text = "HORA:";

                Label lblHora = new Label();
                lblHora.Attributes.Add("class", "TxtReserva");
                lblHora.Text = item.FechaHora.ToShortTimeString();
                lblHora.CssClass = "lblReserva";

                tdHora.Controls.Add(lblTituloHora);
                tdHora.Controls.Add(lblHora);
                trFechaHora.Controls.Add(tdHora);

                HtmlGenericControl tdbtnEditar = new HtmlGenericControl("td");
                ImageButton btnEditar = new ImageButton();
                btnEditar.CssClass = "BtnForm";
                btnEditar.Height = 20;
                btnEditar.Width = 20;
                btnEditar.ImageUrl = "~/IMG/edit.png";
                btnEditar.OnClientClick = "return EditarReserva('" + item.Codigo.ToString() + "');";
                btnEditar.ID = item.Codigo.ToString();
                tdbtnEditar.Controls.Add(btnEditar);
                trFechaHora.Controls.Add(tdbtnEditar);

                HtmlGenericControl tdbtnEliminar = new HtmlGenericControl("td");
                ImageButton btnEliminar = new ImageButton();
                btnEliminar.CssClass = "BtnForm";
                btnEliminar.Height = 20;
                btnEliminar.Width = 20;
                btnEliminar.ImageUrl = "~/IMG/delete.png";
                btnEliminar.OnClientClick = "return EliminarReserva('" + item.Codigo.ToString() + "');";
                btnEliminar.ID = item.Codigo.ToString();
                tdbtnEliminar.Controls.Add(btnEliminar);
                trFechaHora.Controls.Add(tdbtnEliminar);

                HtmlGenericControl trCliente = new HtmlGenericControl("tr");
                HtmlGenericControl tdCliente = new HtmlGenericControl("td");
                tdCliente.Attributes.Add("colspan", "4");

                Label lblTituloCliente = new Label();
                lblTituloCliente.Text = "CLIENTE:";

                Label lblCliente = new Label();
                lblCliente.Text = item.Usuario.Nombre + " " + item.Usuario.Apellido;
                lblCliente.CssClass = "lblReserva";

                tdCliente.Controls.Add(lblTituloCliente);
                tdCliente.Controls.Add(lblCliente);
                trCliente.Controls.Add(tdCliente);

                HtmlGenericControl trTelefono = new HtmlGenericControl("tr");
                HtmlGenericControl tdTelefono = new HtmlGenericControl("td");
                tdTelefono.Attributes.Add("colspan", "4");

                Label lblTituloTelefono = new Label();
                lblTituloTelefono.Text = "TELÉFONO:";

                Label lblTelefono = new Label();
                lblTelefono.Text = item.Usuario.Telefono;
                lblTelefono.CssClass = "lblReserva";

                tdTelefono.Controls.Add(lblTituloTelefono);
                tdTelefono.Controls.Add(lblTelefono);
                trTelefono.Controls.Add(tdTelefono);

                Table.Controls.Add(trFechaHora);
                Table.Controls.Add(trCliente);
                Table.Controls.Add(trTelefono);

                divReservas.Controls.Add(Table);
            }
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            Usuario u = UsuarioController.FindUserRut(TxtBuscar.Text);

            if (u != null)
            {
                CargaReservas(u);
            }
        }
    }
}