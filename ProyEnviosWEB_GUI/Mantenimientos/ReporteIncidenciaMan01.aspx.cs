using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_ReporteIncidenciaMan01 : System.Web.UI.Page
{
    ReporteIncidenciaBL objReIncidenciaBL = new ReporteIncidenciaBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                grvReportes.DataSource = objReIncidenciaBL.ListarReporteIncidencia();
                grvReportes.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error..." + ex.Message;
        }
    }
    protected void grvReportes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;
            indicefila = Convert.ToInt16(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Session["IDReporte"] = grvReportes.Rows[indicefila].Cells[1].Text;
                Response.Redirect("ReporteIncidenciaMan03.aspx");
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error..." + ex.Message;
        }
    }
}