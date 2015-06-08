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

public partial class Mantenimientos_TransporteMan02 : System.Web.UI.Page
{
    TransporteBE objTransporteBE = new TransporteBE();
    TransporteBL objTransporteBL = new TransporteBL();

    ChoferBL chofBL = new ChoferBL();
    MarcaBL marcBL = new MarcaBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        // Para manejar la fecha en formato dd-mm-yyyy
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

        if (Page.IsPostBack == false)
        {
            cboChofer.DataSource = chofBL.ListarChofer();
            cboChofer.DataTextField = "Razon_Social";
            cboChofer.DataValueField = "IDChofer";
            cboChofer.DataBind();
            

            cboMarca.DataSource = marcBL.ListarMarca();
            cboMarca.DataTextField = "Nombre";
            cboMarca.DataValueField = "IDMarca";
            cboMarca.DataBind();
        }
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        try
        {
            objTransporteBE.IDTransporte = "";
            objTransporteBE.IDChofer = cboChofer.SelectedValue;
            objTransporteBE.IDMarca = cboMarca.SelectedValue;
            objTransporteBE.Modelo = txtModelo.Text;
            objTransporteBE.Placa = txtPlaca.Text;
            objTransporteBE.TarjetaProp = txtTPropiedad.Text;

            if (objTransporteBL.InsertarTransporte(objTransporteBE) == true)
            {
                Response.Redirect("TransporteMan01.aspx");
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
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("TransporteMan01.aspx");
    }
}