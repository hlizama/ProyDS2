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

public partial class Mantenimientos_CiudadMan02 : System.Web.UI.Page
{
    CiudadBE objCiudadBE = new CiudadBE();
    CiudadBL objCiudadBL = new CiudadBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objCiudadBE.IDCiudad = "";
            objCiudadBE.Nombre = txtNombre.Text;
            objCiudadBE.Kilometros = Convert.ToInt32(txtKilometro.Text);

            if (objCiudadBL.InsertarCiudad(objCiudadBE) == true)
            {
                Response.Redirect("CiudadMan01.aspx");
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
        Response.Redirect("CiudadMan01.aspx");
    }
}