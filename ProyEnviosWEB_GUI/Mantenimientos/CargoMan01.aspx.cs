using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_CargoMan01 : System.Web.UI.Page
{
    CargoBL objCargoBL = new CargoBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                grvCargos.DataSource = objCargoBL.ListarCargo();
                grvCargos.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
    protected void grvCargos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;
            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IDCargo"] = grvCargos.Rows[indicefila].Cells[1].Text;
                Response.Redirect("CargoMan03.aspx");
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}