using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BE;
using ProyEnvios_BL;
using System.Threading;
using System.Globalization;


public partial class Mantenimientos_TipoCargoMan02 : System.Web.UI.Page
{
    TipoCargoBE objTipoCargoBE = new TipoCargoBE();
    TipoCargoBL objTipoCargoBL = new TipoCargoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objTipoCargoBE.Idtipocargo = "";
            objTipoCargoBE.Nombre = txtNombre.Text;

            if (objTipoCargoBL.InsertarTipoCargo(objTipoCargoBE) == true)
            {
                Response.Redirect("TipoCargoMan01.aspx");
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
        Response.Redirect("TipoCargoMan01.aspx");
    }
}