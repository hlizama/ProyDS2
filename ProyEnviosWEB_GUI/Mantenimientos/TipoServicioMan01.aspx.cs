using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;

public partial class Mantenimientos_TipoServicioMan01 : System.Web.UI.Page
{
    TipoServicioBL objTServicioBL = new TipoServicioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Page.IsPostBack == false)
            {
                grvTipoServicio.DataSource = objTServicioBL.ListarTipoServicio();
                grvTipoServicio.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error...." + ex.Message;
        }
    }
    protected void grvTipoServicio_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int indicefila;

            //Se obtiene el indice de la fila seleccionada en el gridview
            indicefila = Convert.ToInt16(e.CommandArgument);

            // Si se hizo click en el boton Editar
            if (e.CommandName == "Editar")
            {
                //Guardamos en una variable de sesion el codigo del vendedor seleccionado
                Session["IDTipoServicio"] = grvTipoServicio.Rows[indicefila].Cells[1].Text;

                //E invocamos al web form TipoServicioMan03
                Response.Redirect("TipoServicioMan03.aspx");
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se produjo el error...." + ex.Message;
        }
    }
}