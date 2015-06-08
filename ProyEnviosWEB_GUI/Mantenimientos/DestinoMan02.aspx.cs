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

public partial class Mantenimientos_DestinoMan02 : System.Web.UI.Page
{
    DestinoBE objDestinoBE = new DestinoBE();
    DestinoBL objDestinoBL = new DestinoBL();

    CiudadBL objCiudadBL = new CiudadBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

        if (Page.IsPostBack == false)
        {
            cboCiudad.DataSource = objCiudadBL.ListarCiudad();
            cboCiudad.DataTextField = "Nombre";
            cboCiudad.DataValueField = "IDCiudad";
            cboCiudad.DataBind();
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objDestinoBE.Iddestino = "";
            objDestinoBE.Idciudad = cboCiudad.SelectedValue;
            objDestinoBE.Distrito = txtDistrito.Text;
            objDestinoBE.Direccion = txtDireccion.Text;

            if (objDestinoBL.InsertarDestino(objDestinoBE) == true)
            {
                Response.Redirect("DestinoMan01.aspx");
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
        Response.Redirect("DestinoMan01.aspx");
    }
}