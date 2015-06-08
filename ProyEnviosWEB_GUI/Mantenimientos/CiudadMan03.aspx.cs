using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_CiudadMan03 : System.Web.UI.Page
{
    CiudadBE objCiudadBE = new CiudadBE();
    CiudadBL objCiudadBL = new CiudadBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodCiu = Session["IDCiudad"].ToString();
            try
            {
                objCiudadBE = objCiudadBL.ConsultarCuidad(strCodCiu);

                lblCodigo.Text = strCodCiu;
                txtNombre.Text = objCiudadBE.Nombre;
                txtKilometro.Text = objCiudadBE.Kilometros.ToString();
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
            objCiudadBE.IDCiudad = Session["IDCiudad"].ToString();
            objCiudadBE.Nombre = txtNombre.Text;
            objCiudadBE.Kilometros = Convert.ToInt32(txtKilometro.Text);

            if (objCiudadBL.ActualizarCiudad(objCiudadBE) == true)
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
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if(objCiudadBL.EliminarCiudad(lblCodigo.Text))
            {
                Response.Redirect("CiudadMan01.aspx");
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
        Response.Redirect("CiudadMan01.aspx");
    }
}