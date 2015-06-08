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

public partial class Mantenimientos_ChoferMan02 : System.Web.UI.Page
{
    ChoferBE objChoferBE = new ChoferBE();
    ChoferBL objChoferBL = new ChoferBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objChoferBE.IDChofer = "";
            objChoferBE.Nombre = txtNombre.Text;
            objChoferBE.Apellido_Pat = txtApePaterno.Text;
            objChoferBE.Apellido_Mat = txtApeMaterno.Text;
            objChoferBE.FechaNacimiento = Convert.ToDateTime(txtFecNacimiento.Text);
            objChoferBE.Direccion = txtDireccion.Text;
            objChoferBE.Telefono = txtTelefono.Text;
            objChoferBE.DNI = Convert.ToInt32(txtDni.Text);
            objChoferBE.NumeroBrevete = txtNroBrevete.Text;

            if (optC.Checked == true)
            {
                objChoferBE.TipoBrevete = "C";
            }
            else if (optB.Checked == true)
            {
                objChoferBE.TipoBrevete = "B";
            }

            if (objChoferBL.InsertarChofer(objChoferBE) == true)
            {
                Response.Redirect("ChoferMan01.aspx");
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
        Response.Redirect("ChoferMan01.aspx");
    }
}