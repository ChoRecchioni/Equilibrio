using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS_ADM
{
    public partial class Formulario_web17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargarDropLocal();
            }

        }
        protected void CargarDropLocal()
        {
            DropLocal.DataSource = from com in LocalController.findAll()
                                   select new
                                   {
                                       codigo = com.codigo,
                                       texto = com.nombre,
                                   };
            DropLocal.DataValueField = "codigo";
            DropLocal.DataTextField = "texto";

            DropLocal.DataBind();
        }

        protected void CargarDropHoras()
        {
            var mesas = MesaController.findAll().Where(m => m.Sede.codigo == int.Parse(DropLocal.SelectedValue));

            //for (int hora = 12; hora < 21; hora++)
            for (int hora = int.Parse(ConfigurationManager.AppSettings["HoraInicio"]); hora < int.Parse(ConfigurationManager.AppSettings["HoraTermino"]); hora++)
            {
                var reservasLocal = ReservaController.findAll().Where(r => r.Sede.codigo == int.Parse(DropLocal.SelectedValue) && r.fecha == Calendar1.SelectedDate.AddHours(hora));

                if ((mesas.Count() * 0.25) - reservasLocal.Count() > 0)
                {
                    DropHoras.Items.Add(new ListItem(hora.ToString() + ":00", hora.ToString()));
                }
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            string codLocal = DropLocal.SelectedValue;
            
            var mesas = MesaController.findAll().Where(m => m.Sede.codigo == int.Parse(codLocal));

            //deshabilita domingos y dias anteriores a hoy.
            if (e.Day.Date.DayOfWeek == DayOfWeek.Sunday || e.Day.Date < DateTime.Now.Date)
                e.Day.IsSelectable = false;
            else
            {
                e.Day.IsSelectable = false;

                for (int hora = int.Parse(ConfigurationManager.AppSettings["HoraInicio"]); hora < int.Parse(ConfigurationManager.AppSettings["HoraTermino"]); hora++)
                {
                    var reservasLocal = ReservaController.findAll().Where(r => r.Sede.codigo == int.Parse(DropLocal.SelectedValue) && r.fecha == e.Day.Date.AddHours(hora));
                    if ((mesas.Count() * 0.25) - reservasLocal.Count() > 0)
                    {
                        e.Day.IsSelectable = true;
                        break;
                    }
                }
            }
        }

        protected void DropLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            DropHoras.Items.Clear();
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DropHoras.Items.Clear();
            CargarDropHoras();
        }
        protected void DropHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ///TODO: Generar validaciones de los parámetros de entrada: Sesion de Usuario, Local y Horas

            Mesa mesa = MesaController.EncontrarMesa(int.Parse(DropLocal.SelectedValue), int.Parse(Check.SelectedValue), Calendar1.SelectedDate.AddHours(int.Parse(DropHoras.SelectedValue)));
            
            if (mesa != null)
            {
                //modificar usuario (debe llegar nombre y telefono)
                ReservaController.AddReserva(" ", mesa.codigo.ToString(),Calendar1.SelectedDate.AddHours(int.Parse(DropHoras.SelectedValue)).ToString(), DropLocal.SelectedValue, ((Usuario)Session["ActiveUser"]).codigo.ToString());
                System.Threading.Thread.Sleep(2500);
                Response.Redirect("GestionarReservas.aspx");
            }
        }
    }
}