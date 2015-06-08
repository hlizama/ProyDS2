using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_ReporteIncidenciaMan03 : System.Web.UI.Page
{
    EnvioBL objEnvioBL = new EnvioBL();
    EnvioBE objEnvioBE = new EnvioBE();
    ReporteIncidenciaBL objReporteInBL = new ReporteIncidenciaBL();
    ReporteIncidenciaBE objReporteInBE = new ReporteIncidenciaBE();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodRep = Session["IDReporte"].ToString();
            try
            {
                cboEnvioPe.DataSource = objEnvioBL.ListarEnviosPendientes();
                cboEnvioPe.DataTextField = "Nombre_Cliente";
                cboEnvioPe.DataValueField = "IDEnvio";
                cboEnvioPe.Text = objEnvioBE.Nombre_Cliente;
                cboEnvioPe.DataBind();

                objReporteInBE = objReporteInBL.ConsultarReporteIncidencia(strCodRep);

                lblCodigo.Text = strCodRep;
                txtNombreIn.Text = objReporteInBE.Nombre;
                lblNotifica.Text = "Sin Notificar";
                txtRetraso.Text = objReporteInBE.Retraso.ToString();
                txtDescripcion.Text = objReporteInBE.Descrip;
                txtFecha.Text = objReporteInBE.Fecha.ToShortDateString();
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
            objReporteInBE.IdReporte = Session["IDReporte"].ToString();
            objReporteInBE.Idenvio = cboEnvioPe.SelectedValue;
            objReporteInBE.Nombre = txtNombreIn.Text;
            objReporteInBE.Retraso = Convert.ToInt16(txtRetraso.Text);
            objReporteInBE.Descrip = txtDescripcion.Text;
            objReporteInBE.Fecha = Convert.ToDateTime(txtFecha.Text);

            if (objReporteInBL.ActualizarReporteIncidencia(objReporteInBE) == true)
            {
                Response.Redirect("ReporteIncidenciaMan01.aspx");
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
            if (objReporteInBL.EliminarReporteIncidencia(lblCodigo.Text))
            {
                Response.Redirect("ReporteIncidenciaMan01.aspx");
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
        Response.Redirect("ReporteIncidenciaMan01.aspx");
    }
}