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
            SedeController.CargarSedes();

            if (!Page.IsPostBack)
            {
                CargarDropLocal();
            }
        }

        protected void CargarDropLocal()
        {
            DropLocal.DataSource = from com in SedeController.FindAll()
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
            DropHoras.DataSource = from com in HoraController.FindAll()
                                   select new
                                   {
                                       codigo = com.Codigo,
                                       texto = com.Hora,
                                   };
            DropHoras.DataValueField = "codigo";
            DropHoras.DataTextField = "texto";

            DropHoras.DataBind();
        }

        protected void CargarDropMesas()
        {
            DropMesas.DataSource = from com in MesaController.FindAll()
                                   select new
                                   {
                                       codigo = com.Codigo,
                                       texto = com.Comensales,
                                   };
            DropMesas.DataValueField = "codigo";
            DropMesas.DataTextField = "texto";

            DropMesas.DataBind();
        }

        protected void DropLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar1.SelectedDates.Clear();
            DropHoras.Items.Clear();
            DropMesas.Items.Clear();
            //cargar datos calendario
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DropHoras.Items.Clear();
            DropMesas.Items.Clear();
            //cargar datos horas
            //cargar datos mesas
        }
        protected void DropHoras_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropMesas.Items.Clear();
            //cargar datos mesas
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            System.Threading.Thread.Sleep(2500);
        }
    }
}