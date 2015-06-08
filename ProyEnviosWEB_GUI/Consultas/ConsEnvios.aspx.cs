using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Consultas_ConsEnvios : System.Web.UI.Page
{
    ChoferBL objChoferBL = new ChoferBL();
    EnvioBL objEnvioBL = new EnvioBL();

    EmpleadoBL objEmpleadoBL = new EmpleadoBL();

    ClienteBL objClienteBL = new ClienteBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            try
            {
                cboChofer.DataSource = objChoferBL.ListarChofer();
                cboChofer.DataValueField = "IDChofer";
                cboChofer.DataTextField = "Razon_Social";
                cboChofer.DataBind();

                cboEmpleado.DataSource = objEmpleadoBL.ListarEmpleado();
                cboEmpleado.DataValueField = "IDEmpleado";
                cboEmpleado.DataTextField = "Razon_Social";
                cboEmpleado.DataBind();

                cboCliente.DataSource = objClienteBL.ListarCliente();
                cboCliente.DataValueField = "IDCliente";
                cboCliente.DataTextField = "Razon_Social";
                cboCliente.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
    protected void btnConsultar1_Click(object sender, EventArgs e)
    {
        grvEnvios.DataSource = objEnvioBL.ListarEnvioChofer(cboChofer.SelectedValue.ToString());
        grvEnvios.DataBind();
    }
    protected void btnConsultar2_Click(object sender, EventArgs e)
    {
        grvEnvios.DataSource = objEnvioBL.ConsultarEnvioEmpleado(cboEmpleado.SelectedValue.ToString());
        grvEnvios.DataBind();
    }
    protected void btnConsultar3_Click(object sender, EventArgs e)
    {
        grvEnvios.DataSource = objEnvioBL.ConsultarEnvioCliente(cboCliente.SelectedValue.ToString());
        grvEnvios.DataBind();
    }
}