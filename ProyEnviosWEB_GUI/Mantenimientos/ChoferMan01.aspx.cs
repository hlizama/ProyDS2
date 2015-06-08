using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_ChoferMan01 : System.Web.UI.Page
{
    ChoferBL objChoferBL = new ChoferBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                grvChoferes.DataSource = objChoferBL.ListarChofer();
                grvChoferes.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
    protected void grvChoferes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;
            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IDChofer"] = grvChoferes.Rows[indicefila].Cells[1].Text;
                Response.Redirect("ChoferMan03.aspx");
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}