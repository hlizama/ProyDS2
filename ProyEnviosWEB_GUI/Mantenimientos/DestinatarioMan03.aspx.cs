using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_DestinatarioMan03 : System.Web.UI.Page
{
    DestinatarioBE objDestinatarioBE = new DestinatarioBE();
    DestinatarioBL objDestinatarioBL = new DestinatarioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodDesti = Session["IDDestinatario"].ToString();
            try
            {
                objDestinatarioBE = objDestinatarioBL.ConsultarDestinatario(strCodDesti);

                lblCodigo.Text = strCodDesti;
                txtNombre.Text = objDestinatarioBE.Nombre;
                txtApePaterno.Text = objDestinatarioBE.Apellido_Pat;
                txtApeMaterno.Text = objDestinatarioBE.Apellido_Mat;
                txtDni.Text = objDestinatarioBE.Dni;
                txtDireccion.Text = objDestinatarioBE.Direccion;
                txtTelefono.Text = objDestinatarioBE.Telefono;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error : " + ex.Message;
            }
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objDestinatarioBE.Iddestinatario = Session["IDDestinatario"].ToString();
            objDestinatarioBE.Nombre = txtNombre.Text;
            objDestinatarioBE.Apellido_Pat = txtApePaterno.Text;
            objDestinatarioBE.Apellido_Mat = txtApeMaterno.Text;
            objDestinatarioBE.Dni = txtDni.Text;
            objDestinatarioBE.Direccion = txtDireccion.Text;
            objDestinatarioBE.Telefono = txtTelefono.Text;

            if (objDestinatarioBL.ActualizarDestinatario(objDestinatarioBE) == true)
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
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objDestinatarioBL.EliminarDestinatario(lblCodigo.Text))
            {
                Response.Redirect("DestinatarioMan01.aspx");
            }
            else
            {
                lblMensaje.Text = "El vendedor no se pudo eliminar porque esta vinculado a otras tablas";
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