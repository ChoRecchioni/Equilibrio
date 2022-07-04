using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web15 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Usuario usuario = ((Usuario)Session["ActiveUser"]);
                if (usuario != null)
                {
                    CargaReservas(usuario);
                }
            }

            Usuario u = (Usuario)Session["ActiveUser"];

            if (u == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }
        }

        public void CargaReservas(Usuario usuario)
        {
            Usuario u = UsuarioController.FindUsuario(usuario.codigo);
            var reservas = ReservaController.findAll();

            foreach (var item in reservas.Where(r => r.Usuario.codigo == u.codigo))
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
                lblFecha.Text = item.fecha.ToShortDateString();
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
                lblHora.Text = item.fecha.ToShortTimeString();
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
                btnEditar.OnClientClick = "return EditarReserva('" + item.codigo.ToString() + "');";
                btnEditar.ID = item.codigo.ToString();
                tdbtnEditar.Controls.Add(btnEditar);
                trFechaHora.Controls.Add(tdbtnEditar);

                HtmlGenericControl tdbtnEliminar = new HtmlGenericControl("td");
                ImageButton btnEliminar = new ImageButton();
                btnEliminar.CssClass = "BtnForm";
                btnEliminar.Height = 20;
                btnEliminar.Width = 20;
                btnEliminar.ImageUrl = "~/IMG/delete.png";
                btnEliminar.OnClientClick = "return EliminarReserva('" + item.codigo.ToString() + "');";
                btnEliminar.ID = item.codigo.ToString();
                tdbtnEliminar.Controls.Add(btnEliminar);
                trFechaHora.Controls.Add(tdbtnEliminar);

                HtmlGenericControl trLocal = new HtmlGenericControl("tr");
                HtmlGenericControl tdLocal = new HtmlGenericControl("td");
                tdLocal.Attributes.Add("colspan", "4");

                Label lblTituloLocal = new Label();
                lblTituloLocal.Text = "LOCAL:";

                Label lblLocal = new Label();
                lblLocal.Text = item.Sede.nombre;
                lblLocal.CssClass = "lblReserva";

                tdLocal.Controls.Add(lblTituloLocal);
                tdLocal.Controls.Add(lblLocal);
                trLocal.Controls.Add(tdLocal);

                HtmlGenericControl trDireccion = new HtmlGenericControl("tr");
                HtmlGenericControl tdDireccion = new HtmlGenericControl("td");
                tdDireccion.Attributes.Add("colspan", "4");

                Label lblTituloDireccion = new Label();
                lblTituloDireccion.Text = "DIRECCIÓN:";

                Label lblDireccion = new Label();
                lblDireccion.Text = item.Sede.Direccion.calleYnum + ", " + item.Sede.Direccion.Comuna.nombre;
                lblDireccion.CssClass = "lblReserva";

                tdDireccion.Controls.Add(lblTituloDireccion);
                tdDireccion.Controls.Add(lblDireccion);
                trDireccion.Controls.Add(tdDireccion);

                HtmlGenericControl trTelefono = new HtmlGenericControl("tr");
                HtmlGenericControl tdTelefono = new HtmlGenericControl("td");
                tdTelefono.Attributes.Add("colspan", "4");

                Label lblTituloTelefono = new Label();
                lblTituloTelefono.Text = "TELÉFONO:";

                Label lblTelefono = new Label();
                lblTelefono.Text = item.Sede.telefono;
                lblTelefono.CssClass = "lblReserva";

                tdTelefono.Controls.Add(lblTituloTelefono);
                tdTelefono.Controls.Add(lblTelefono);
                trTelefono.Controls.Add(tdTelefono);

                Table.Controls.Add(trFechaHora);
                Table.Controls.Add(trLocal);
                Table.Controls.Add(trDireccion);
                Table.Controls.Add(trTelefono);

                divReservas.Controls.Add(Table);
            }
        }

        [WebMethod]
        public static object EliminarReserva(string id)
        {
            try
            {
                ReservaController.removeReserva(int.Parse(id));
                return new
                {
                    error = false,
                    msg = "Reserva eliminada"
                };
            }
            catch (Exception e)
            {
                return new
                {
                    error = true,
                    msg = e.Message
                };
            }
        }
    }
}