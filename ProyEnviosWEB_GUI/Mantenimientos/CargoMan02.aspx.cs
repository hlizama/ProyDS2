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

public partial class Mantenimientos_CargoMan02 : System.Web.UI.Page
{
    CargoBE objCargoBE = new CargoBE();
    CargoBL objCargoBL = new CargoBL();

    TipoCargoBL objTipoCargoBL = new TipoCargoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

        if (Page.IsPostBack == false)
        {
            cboTipoCargo.DataSource = objTipoCargoBL.ListarTipoCargo();
            cboTipoCargo.DataTextField = "Nombre";
            cboTipoCargo.DataValueField = "IDTipoCargo";
            cboTipoCargo.DataBind();
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objCargoBE.IDCargo = "";
            objCargoBE.IDTipoCargo = cboTipoCargo.SelectedValue;
            objCargoBE.Descripcion = txtDescripcion.Text;
            objCargoBE.Peso = Convert.ToSingle(txtPeso.Text);
            objCargoBE.UnidadMedida = txtUniMedida.Text;

            if (objCargoBL.InsertarCargo(objCargoBE) == true)
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
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("CargoMan01.aspx");
    }
}