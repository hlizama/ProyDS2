using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_EnvioPendiente : System.Web.UI.Page
{
    EnvioBL objEnvioBL = new EnvioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if(Page.IsPostBack == false)
            {
                grvEnvioPe.DataSource = objEnvioBL.ListarEnviosPendientes();
                grvEnvioPe.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
}