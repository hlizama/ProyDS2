using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_TipoCargoMan03 : System.Web.UI.Page
{
    TipoCargoBE objTipoCargoBE = new TipoCargoBE();
    TipoCargoBL objTipoCargoBL = new TipoCargoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodTCar = Session["IDTipoCargo"].ToString();
            try
            {
                objTipoCargoBE = objTipoCargoBL.ConsultarTipoCargo(strCodTCar);
                lblCodigo.Text = strCodTCar;
                txtNombre.Text = objTipoCargoBE.Nombre;
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
            objTipoCargoBE.Idtipocargo = Session["IDTipoCargo"].ToString();
            objTipoCargoBE.Nombre = txtNombre.Text;

            if (objTipoCargoBL.ActualizarTipoCargo(objTipoCargoBE) == true)
            {
                Response.Redirect("TipoCargoMan01.aspx");
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
            if (objTipoCargoBL.EliminarTipoCargo(lblCodigo.Text))
            {
                Response.Redirect("TipoCargoMan01.aspx");
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
        Response.Redirect("TipoCargoMan01.aspx");
    }
}
