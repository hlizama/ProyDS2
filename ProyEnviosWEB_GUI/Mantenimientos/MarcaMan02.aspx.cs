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

public partial class Mantenimientos_MarcaMan02 : System.Web.UI.Page
{
    MarcaBE objMarcaBE = new MarcaBE();
    MarcaBL objMarcaBL = new MarcaBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objMarcaBE.IDMarca = "";
            objMarcaBE.Nombre = txtMarca.Text;

            if(objMarcaBL.InsertarMarca(objMarcaBE) == true)
            {
                Response.Redirect("MarcaMan01.aspx");
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
        Response.Redirect("MarcaMan01.aspx");
    }
}