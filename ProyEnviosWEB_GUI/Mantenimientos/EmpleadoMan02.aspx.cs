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


public partial class Mantenimientos_EmpleadoMan02 : System.Web.UI.Page
{
    EmpleadoBE objEmpleadoBE = new EmpleadoBE();
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        if (txtPass.Text.Equals(txtPass2.Text))
        {
            try
            {
                objEmpleadoBE.Idempleado = "";
                objEmpleadoBE.Nombre = txtNombre.Text;
                objEmpleadoBE.Apellido_pat = txtApePaterno.Text;
                objEmpleadoBE.Apellido_mat = txtApeMaterno.Text;
                objEmpleadoBE.FechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);
                objEmpleadoBE.Direccion = txtDireccion.Text;
                objEmpleadoBE.Telefono = txtTelefono.Text;
                objEmpleadoBE.Dni = Convert.ToInt32(txtDni.Text);
                if (optMasculino.Checked == true)
                {
                    objEmpleadoBE.Sexo = "Masculino";
                }
                else if (optFemenino.Checked == true)
                {
                    objEmpleadoBE.Sexo = "Femenino";
                }
                objEmpleadoBE.Pass = txtPass.Text;
                ////////////////////////////////////foto

                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
                {
                    Response.Redirect("EmpleadoMan01.aspx");
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

    }
}