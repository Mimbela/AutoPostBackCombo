using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutoPostBackCombo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarContactos();
            }

            if (IsPostBack)
            {
                CargarEquipos();
            }
        }

        private void CargarEquipos()
        {
            cmbEquipos.DataValueField = "IdEquipo";
            cmbEquipos.DataTextField = "NombreEquipo";
            cmbEquipos.DataSource = Equipos.ObtenerEquipos();
            cmbEquipos.DataBind();
        }

        private void CargarContactos()
        {
            cmbContactos.DataValueField = "IdEmployee"; //por detras
            cmbContactos.DataTextField = "LastName";//por delante
            cmbContactos.DataSource = Contact.ObtenerContactos();
            cmbContactos.DataBind();

            //DataBind : Utilice este método para enlazar datos de un origen a un control 
            //    de servidor. Normalmente, este método se utiliza después de
            //    recuperar un conjunto de datos mediante una consulta de base de datos. 
            //    El método lo usan principalmente los desarrolladores de controles;
            //la mayoría de los controles realizan el enlace de datos automáticamente.

        }

    }
}