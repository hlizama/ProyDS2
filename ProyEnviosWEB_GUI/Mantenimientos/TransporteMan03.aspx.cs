using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_TransporteMan03 : System.Web.UI.Page
{
    TransporteBE objTransporteBE = new TransporteBE();
    TransporteBL objTransporteBL = new TransporteBL();

    ChoferBL chofBL = new ChoferBL();
    MarcaBL marcBL = new MarcaBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodTrans = Session["IDTransporte"].ToString();
            try
            {
                cboChofer.DataSource = chofBL.ListarChofer();
                cboChofer.DataTextField = "Razon_Social";
                cboChofer.DataValueField = "IDChofer";
                cboChofer.DataBind();
                cboChofer.SelectedValue = objTransporteBE.IDChofer;

                cboMarca.DataSource = marcBL.ListarMarca();
                cboMarca.DataTextField = "Nombre";
                cboMarca.DataValueField = "IDMarca";
                cboMarca.DataBind();
                cboMarca.SelectedValue = objTransporteBE.IDMarca;

                objTransporteBE = objTransporteBL.ConsultarTransporte(strCodTrans);

                lblCodigo.Text = strCodTrans;
                txtModelo.Text = objTransporteBE.Modelo;
                txtPlaca.Text = objTransporteBE.Placa;
                txtTPropiedad.Text = objTransporteBE.TarjetaProp;
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
            objTransporteBE.IDTransporte = Session["IDTransporte"].ToString();
            objTransporteBE.IDChofer = cboChofer.SelectedValue;
            objTransporteBE.IDMarca = cboMarca.SelectedValue;
            objTransporteBE.Modelo = txtModelo.Text;
            objTransporteBE.Placa = txtPlaca.Text;
            objTransporteBE.TarjetaProp = txtTPropiedad.Text;

            if (objTransporteBL.ActualizarTransporte(objTransporteBE) == true)
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
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (objTransporteBL.EliminarTransporte(lblCodigo.Text))
            {
                Response.Redirect("TransporteMan01.aspx");
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
        Response.Redirect("TransporteMan01.aspx");
    }
}