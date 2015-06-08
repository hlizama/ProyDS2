using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;
using System.Threading;
using System.Globalization;

public partial class Mantenimientos_TipoServicioMan02 : System.Web.UI.Page
{
    TipoServicioBE objTServicioBE = new TipoServicioBE();
    TipoServicioBL objTServicioBL = new TipoServicioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objTServicioBE.IDtiposervicio = "";
            objTServicioBE.Nombre = txtNombre.Text;
            objTServicioBE.Dias = Convert.ToInt16(txtDias.Text);

            //Insertamos el tipo de servicio
            if (objTServicioBL.InsertarTipoServicio(objTServicioBE) == true)
            {
                Response.Redirect("TipoServicioMan01.aspx");
            }
            else
            {
                lblMensaje.Text = "Error, verifique los datos";
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error: " + ex.Message;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("TipoServicioMan01.aspx");
    }
}