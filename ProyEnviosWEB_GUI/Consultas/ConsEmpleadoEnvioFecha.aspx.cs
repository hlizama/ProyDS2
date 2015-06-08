using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Consultas_ConsEmpleadoEnvioFecha : System.Web.UI.Page
{
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();
    EnvioBL objEnvioBL = new EnvioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            try
            {
                cboEmpleado.DataSource = objEmpleadoBL.ListarEmpleado();
                cboEmpleado.DataValueField = "IDEmpleado";
                cboEmpleado.DataTextField = "Razon_Social";
                cboEmpleado.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
    protected void btnCosultar_Click(object sender, EventArgs e)
    {
        DateTime FecIni;
        DateTime FecFin;

        FecIni = Convert.ToDateTime(txtFecInicio.Text);
        FecFin = Convert.ToDateTime(txtFecFin.Text);

        grvEnvios.DataSource = objEnvioBL.ConsultarEmpleadoEnvioFecha(cboEmpleado.SelectedValue.ToString(), FecIni, FecFin);
        grvEnvios.DataBind();
    }
}