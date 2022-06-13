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
            Usuario u = (Usuario)Session["ActiveUser"];

            if (u != null)
            {
                Response.Redirect("AgregarReseña.aspx");
            }
            else
            {
                Response.Redirect("IniciarSesión.aspx");
            }
            ReseñaController.CargarReseña();
            LocalController.CargarLocales();


            if (!Page.IsPostBack)
            {
                cargarDropLocales();
            }
        }

        public void cargarDropLocales()
        {

            DropLocal.DataSource = from sed in LocalController.FindAll()
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

            //string var = estrellas.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            if (Session["ActiveUser"] == null)
            {
                Response.Redirect("IniciarSesión.aspx");
            }
            else
            {
                string puntuacion;

                if (rd1.Checked)
                {
                    puntuacion = rd1.Value;
                }
                else if (rd2.Checked)
                {
                    puntuacion = rd2.Value;
                }
                else if (rd3.Checked)
                {
                    puntuacion = rd3.Value;
                }
                else if (rd4.Checked)
                {
                    puntuacion = rd4.Value;
                }
                else
                {
                    puntuacion = rd5.Value;
                }

                int codRe = ReseñaController.ReseñaAI();
                Usuario u = (Usuario)Session["ActiveUser"];

                LbAddReseña.Text = ReseñaController.AddReseña(codRe.ToString(), DropLocal.SelectedValue, puntuacion, TxtComentario.Text, u);
                Response.Redirect("VerReseña.aspx");
            }
            
        }

    }
}