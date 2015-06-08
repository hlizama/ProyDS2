using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_CargoMan03 : System.Web.UI.Page
{
    CargoBE objCargoBE = new CargoBE();
    CargoBL objCargoBL = new CargoBL();

    TipoCargoBL objTipoCargoBL = new TipoCargoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodCarg = Session["IDCargo"].ToString();
            try
            {
                cboTipoCargo.DataSource = objTipoCargoBL.ListarTipoCargo();
                cboTipoCargo.DataTextField = "Nombre";
                cboTipoCargo.DataValueField = "IDTipoCargo";
                cboTipoCargo.DataBind();
                cboTipoCargo.Text = objCargoBE.Nombre;

                objCargoBE = objCargoBL.ConsultarCargo(strCodCarg);

                lblCodigo.Text = strCodCarg;
                txtDescripcion.Text = objCargoBE.Descripcion;
                txtPeso.Text = objCargoBE.Peso.ToString();
                txtUniMedida.Text = objCargoBE.UnidadMedida;
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
            objCargoBE.IDCargo = Session["IDCargo"].ToString();
            objCargoBE.IDTipoCargo = cboTipoCargo.SelectedValue;
            objCargoBE.Descripcion = txtDescripcion.Text;
            objCargoBE.Peso = Convert.ToSingle(txtPeso.Text);
            objCargoBE.UnidadMedida = txtUniMedida.Text;
        
            if (objCargoBL.ActualizarCargo(objCargoBE) == true)
            {
                Response.Redirect("CargoMan01.aspx");
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
            if(objCargoBL.EliminarCargo(lblCodigo.Text))
            {
                Response.Redirect("CargoMan01.aspx");
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
        Response.Redirect("CargoMan01.aspx");
    }
}