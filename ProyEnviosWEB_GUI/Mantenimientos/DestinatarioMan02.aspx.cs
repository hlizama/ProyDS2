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

public partial class Mantenimientos_DestinatarioMan02 : System.Web.UI.Page
{
    DestinatarioBE objDestinatarioBE = new DestinatarioBE();
    DestinatarioBL objDestinatarioBL = new DestinatarioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objDestinatarioBE.Iddestinatario = "";
            objDestinatarioBE.Nombre = txtNombre.Text;
            objDestinatarioBE.Apellido_Pat = txtApePaterno.Text;
            objDestinatarioBE.Apellido_Mat = txtApeMaterno.Text;
            objDestinatarioBE.Dni = txtDni.Text;
            objDestinatarioBE.Direccion = txtDireccion.Text;
            objDestinatarioBE.Telefono = txtTelefono.Text;

            if (objDestinatarioBL.InsertarDestinatario(objDestinatarioBE) == true)
            {
                Response.Redirect("DestinatarioMan01.aspx");
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
        Response.Redirect("DestinatarioMan01.aspx");
    }
}