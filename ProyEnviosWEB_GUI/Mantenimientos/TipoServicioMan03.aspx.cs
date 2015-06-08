using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_TipoServicioMan03 : System.Web.UI.Page
{
    TipoServicioBE objTServicioBE = new TipoServicioBE();
    TipoServicioBL objTServicioBL = new TipoServicioBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strID = Session["IDTipoServicio"].ToString();
            try
            {
                objTServicioBE = objTServicioBL.ConsultarTipoServicio(strID);

                //Mostramos los datos
                lblCodigo.Text = strID;
                txtNombre.Text = objTServicioBE.Nombre;
                txtDias.Text = objTServicioBE.Dias.ToString();
                txtPrecio.Text = objTServicioBE.Precio.ToString();
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
            objTServicioBE.IDtiposervicio = Session["IDTipoServicio"].ToString();
            objTServicioBE.Nombre = txtNombre.Text;
            objTServicioBE.Dias = Convert.ToInt16(txtDias.Text);
            objTServicioBE.Precio = Convert.ToSingle(txtPrecio.Text);

            //Actualizamos el tipo de servicio
            if (objTServicioBL.ActualizarTipoServicio(objTServicioBE) == true)
            {
                Response.Redirect("TipoServicioMan01.aspx");
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
            if (objTServicioBL.EliminarTipoServicio(lblCodigo.Text))
            {
                Response.Redirect("TipoServicioMan01.aspx");
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
        Response.Redirect("TipoServicioMan01.aspx");
    }
}