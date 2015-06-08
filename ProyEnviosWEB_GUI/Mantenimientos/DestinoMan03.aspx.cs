using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_DestinoMan03 : System.Web.UI.Page
{
    DestinoBE objDestinoBE = new DestinoBE();
    DestinoBL objDestinoBL = new DestinoBL();

    CiudadBL objCiudadBL = new CiudadBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodDesti = Session["IDDestino"].ToString();
            try
            {
                cboCiudad.DataSource = objCiudadBL.ListarCiudad();
                cboCiudad.DataTextField = "Nombre";
                cboCiudad.DataValueField = "IDCiudad";
                cboCiudad.Text = objDestinoBE.Nombre;
                cboCiudad.DataBind();

                objDestinoBE = objDestinoBL.ConsultarDestino(strCodDesti);

                lblCodigo.Text = strCodDesti;
                txtDistrito.Text = objDestinoBE.Distrito;
                txtDireccion.Text = objDestinoBE.Direccion;

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
            objDestinoBE.Iddestino = Session["IDDestino"].ToString();
            objDestinoBE.Idciudad = cboCiudad.SelectedValue;
            objDestinoBE.Distrito = txtDistrito.Text;
            objDestinoBE.Direccion = txtDireccion.Text;

            if (objDestinoBL.ActualizarDestino(objDestinoBE) == true)
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
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objDestinoBL.EliminarDestino(lblCodigo.Text))
            {
                Response.Redirect("DestinoMan01.aspx");
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
        Response.Redirect("DestinoMan01.aspx");
    }
}