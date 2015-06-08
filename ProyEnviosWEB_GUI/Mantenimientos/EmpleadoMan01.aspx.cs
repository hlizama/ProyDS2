using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_EmpleadoMan01 : System.Web.UI.Page
{
    EmpleadoBL objEmpleadoBL = new EmpleadoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                grvEmpleados.DataSource = objEmpleadoBL.ListarEmpleado();
                grvEmpleados.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
}