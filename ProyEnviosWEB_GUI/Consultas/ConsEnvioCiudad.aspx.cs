using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Consultas_ConsEnvioCiudad : System.Web.UI.Page
{
    EnvioBL objEnvioBL = new EnvioBL();
    CiudadBL objCiudadBL = new CiudadBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            try
            {
                cboCiudad.DataSource = objCiudadBL.ListarCiudad();
                cboCiudad.DataValueField = "IDCiudad";
                cboCiudad.DataTextField = "Nombre";
                cboCiudad.DataBind();

                grvEnvios.DataSource = objEnvioBL.ConsultarEnviosCiudad(cboCiudad.SelectedValue.ToString());
                grvEnvios.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
    protected void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            grvEnvios.DataSource = objEnvioBL.ConsultarEnviosCiudad(cboCiudad.SelectedValue.ToString());
            grvEnvios.DataBind();
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Error: " + ex.Message;
        }
    }
}