using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using equilibrio.Clases;
using equilibrio.Controller;

namespace equilibrio.WEBFORMS
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LocalController.CargarLocales();

            if (!Page.IsPostBack)
            {
                CargarDropLocal();
            }
        }

        protected void CargarDropLocal()
        {
            DropLocal.DataSource = from com in LocalController.FindAll()
                                   select new
                                   {
                                       codigo = com.Codigo,
                                       texto = com.Nombre,
                                   };
            DropLocal.DataValueField = "codigo";
            DropLocal.DataTextField = "texto";

            DropLocal.DataBind();
        }

        protected void CargarDropHoras()
        {
            MesaController.CargarMesa();
            ReservaController.CargarReserva();
            var mesas = MesaController.FindAll().Where(m => m.Local.Codigo == int.Parse(DropLocal.SelectedValue));

            //for (int hora = 12; hora < 21; hora++)
            for (int hora = 12; hora < 15; hora++)
            {
                var reservasLocal = ReservaController.FindAll().Where(r => r.Local.Codigo == int.Parse(DropLocal.SelectedValue) && r.FechaHora == Calendar1.SelectedDate.AddHours(hora));

                if ((mesas.Count() * 0.25) - reservasLocal.Count() > 0)
                {
                    DropHoras.Items.Add(new ListItem(hora.ToString() + ":00", hora.ToString()));
                }
            }
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            string codLocal = DropLocal.SelectedValue;
            LocalController.CargarLocales();
            MesaController.CargarMesa();
            ReservaController.CargarReserva();

            var reservas = ReservaController.FindAll().Where(r => r.Local.Codigo == int.Parse(codLocal) && r.FechaHora.Date == e.Day.Date);
            var mesas = MesaController.FindAll().Where(m => m.Local.Codigo == int.Parse(codLocal));

            if (e.Day.Date.DayOfWeek == DayOfWeek.Sunday)
                e.Day.IsSelectable = false;
            else
            {
                if ((mesas.Count() * 0.25) - reservas.Count() > 0)
                {
                    e.Day.IsSelectable = true;
                }
            }
            //foreach (var fecha in lista)
            //{
            //    if (e.Day.Date == fecha.Fecha && e.Day.Date > DateTime.Now)
            //    {
            //        e.Day.IsSelectable = true;
            //        break;
            //    }
            //    else
            //        e.Day.IsSelectable = false;
            //}
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
            System.Threading.Thread.Sleep(2500);


        }


    }
}