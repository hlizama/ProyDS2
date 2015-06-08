using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;


public partial class Mantenimientos_MarcaMan03 : System.Web.UI.Page
{
    MarcaBE objMarcaBE = new MarcaBE();
    MarcaBL objMarcaBL = new MarcaBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodMar = Session["IDMarca"].ToString();
            try
            {
                objMarcaBE = objMarcaBL.ConsultarMarca(strCodMar);

                lblCodigo.Text = strCodMar;
                txtMarca.Text = objMarcaBE.Nombre;
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error : " + ex.Message;
            }
        }

    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objMarcaBE.IDMarca = Session["IDMarca"].ToString();
            objMarcaBE.Nombre = txtMarca.Text;

            if (objMarcaBL.ActualizarMarca(objMarcaBE) == true)
            {
                Response.Redirect("MarcaMan01.aspx");
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
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objMarcaBL.EliminarMarca(lblCodigo.Text))
            {
                Response.Redirect("MarcaMan01.aspx");
            }
            else
            {
                lblMensaje.Text = "El vendedor no se pudo eliminar porque esta vinculado a otras tablas";
            }
        }
        catch (Exception ex)
        {
            lblMensaje.Text = "Se ha producido el error: " + ex.Message;
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("MarcaMan01.aspx");
    }
}