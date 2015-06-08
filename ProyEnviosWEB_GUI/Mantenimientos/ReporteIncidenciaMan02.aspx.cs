using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BE;
using ProyEnvios_BL;
using System.Threading;
using System.Globalization;
using System.Net.Mail; //correo

public partial class Mantenimientos_ReporteIncidenciaMan02 : System.Web.UI.Page
{
    EnvioBL objEnvioBL = new EnvioBL();
    ReporteIncidenciaBL objReporteInBL = new ReporteIncidenciaBL();
    ReporteIncidenciaBE objReporteInBE = new ReporteIncidenciaBE();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

        if (Page.IsPostBack == false)
        {
            cboEnvioPe.DataSource = objEnvioBL.ListarEnviosPendientes();
            cboEnvioPe.DataTextField = "Nombre_Cliente";
            cboEnvioPe.DataValueField = "IDEnvio";
            cboEnvioPe.DataBind();

            //String id = cboEnvioPe.SelectedValue.ToString();
            //lblCorreo.Text = objEnvioBL.ListarCorreoClienteEnvio(id);
        }

    }
    protected void cboEnvioPe_SelectedIndexChanged(object sender, EventArgs e)
    {
        //lblCorreo.Text = cboEnvioPe.SelectedValue.ToString();
        String id = cboEnvioPe.SelectedValue.ToString();
        lblCorreo.Text = objEnvioBL.ListarCorreoClienteEnvio(id);
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objReporteInBE.IdReporte = "";
            objReporteInBE.Idenvio = cboEnvioPe.SelectedValue;
            objReporteInBE.Nombre = txtNombreIn.Text;
            objReporteInBE.Notificado = 0;//SIN NOTIFICAR
            objReporteInBE.Retraso = Convert.ToInt16(txtRetraso.Text);
            objReporteInBE.Descrip = txtDescripcion.Text;
            objReporteInBE.Fecha = Convert.ToDateTime(txtFecha.Text);

            if (objReporteInBL.InsertarReporteIncidencia(objReporteInBE) == true)
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
    protected void btnNotificar_Click(object sender, EventArgs e)
    {
        try
        {
            lblEstadoNotidicado.Text = "Notificado";

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(lblCorreo.Text);
            mail.To.Add(lblCorreo.Text);
            mail.Subject = "Reporte CargoCourier " + txtNombreIn.Text;
            mail.Body = txtDescripcion.Text;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("gonsalo_gm@hotmail.com", "ventasleon123");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
            lblMensaje.Text = "Correo Enviado";
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