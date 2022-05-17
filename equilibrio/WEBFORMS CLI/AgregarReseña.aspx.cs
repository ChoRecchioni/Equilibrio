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
    public partial class Formulario_web19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SedeController.CargarSedes();


            if (!Page.IsPostBack)
            {
                cargarDropSedes();
            }
        }

        public void cargarDropSedes()
        {

            DropLocal.DataSource = from sed in SedeController.FindAll()
                                    select new
                                    {
                                        codigo = sed.Codigo,
                                        texto = sed.Nombre,
                                    };
            DropLocal.DataValueField = "codigo";
            DropLocal.DataTextField = "texto";

            DropLocal.DataBind();
        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {

             string value;
             if (rd1.Checked)
             {
                  value = rd1.Value;
             }
             else if (rd2.Checked)
             {
                  value = rd2.Value;
             }
             else if (rd3.Checked)
             {
                 value = rd3.Value;
            }
            else if (rd4.Checked)
            {
                value = rd4.Value;
            }
            else if (rd5.Checked)
            {
                value = rd5.Value;
            }

            //string var = estrellas.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            Response.Redirect("MisReservas.aspx");


            
        }

    }
}