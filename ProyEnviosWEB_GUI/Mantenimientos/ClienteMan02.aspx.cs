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

public partial class Mantenimientos_ClienteMan02 : System.Web.UI.Page
{
    ClienteBE objClienteBE = new ClienteBE();
    ClienteBL objClienteBL = new ClienteBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        //if (txtPass.Text.Equals(txtPass2.Text))
      //  {
            try
            {
                objClienteBE.Idcliente = "";
                objClienteBE.Nombre = txtNombre.Text;
                objClienteBE.Apellido_pat = txtApePat.Text;
                objClienteBE.Apellido_mat = txtApeMat.Text;
                objClienteBE.FechaNacimiento = Convert.ToDateTime(txtFecNac.Text);
                objClienteBE.Direccion = txtDireccion.Text;
                objClienteBE.Ruc = txtRuc.Text;
                objClienteBE.Telefono = txtTelefono.Text;
                objClienteBE.Dni = txtDni.Text;
                objClienteBE.Pass = txtPass.Text;
                objClienteBE.Correo = txtCorreo.Text;

                if (objClienteBL.InsertarCliente(objClienteBE) == true)
                {
                    Response.Redirect("ClienteMan01.aspx");
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
       // }
       // else
       // {
           // lblMensaje.Text = "Contraseñas diferentes";
       // }
    }
}