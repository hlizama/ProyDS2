using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyEnvios_BL;
using ProyEnvios_BE;

public partial class Mantenimientos_ChoferMan03 : System.Web.UI.Page
{
    ChoferBE objChoferBE = new ChoferBE();
    ChoferBL objChoferBL = new ChoferBL();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String strCodChof = Session["IDChofer"].ToString();
            try
            {
                objChoferBE = objChoferBL.ConsultarChofer(strCodChof);

                lblCodigo.Text = strCodChof;
                txtNombre.Text = objChoferBE.Nombre;
                txtApePaterno.Text = objChoferBE.Apellido_Pat;
                txtApeMaterno.Text = objChoferBE.Apellido_Mat;
                txtFecNacimiento.Text = objChoferBE.FechaNacimiento.ToShortDateString();
                txtDireccion.Text = objChoferBE.Direccion;
                txtTelefono.Text = objChoferBE.Telefono;
                txtDni.Text = objChoferBE.DNI.ToString();
                txtNroBrevete.Text = objChoferBE.NumeroBrevete;

                if (objChoferBE.TipoBrevete == "1")
                {
                    optC.Checked = true;
                }
                else
                {
                    optB.Checked = true;
                }
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
            objChoferBE.IDChofer = Session["IDChofer"].ToString();
            objChoferBE.Nombre = txtNombre.Text;
            objChoferBE.Apellido_Pat = txtApePaterno.Text;
            objChoferBE.Apellido_Mat = txtApeMaterno.Text;
            objChoferBE.FechaNacimiento = Convert.ToDateTime(txtFecNacimiento.Text);
            objChoferBE.Direccion = txtDireccion.Text;
            objChoferBE.Telefono = txtTelefono.Text;
            objChoferBE.DNI = Convert.ToInt32(txtDni.Text);
            objChoferBE.NumeroBrevete = txtNroBrevete.Text;

            if (optC.Checked == true)
            {
                objChoferBE.TipoBrevete = "C";
            }
            else if (optB.Checked == true)
            {
                objChoferBE.TipoBrevete = "B";
            }

            if (objChoferBL.ActualizarChofer(objChoferBE) == true)
            {
                Response.Redirect("ChoferMan01.aspx");
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
            if (objChoferBL.EliminarChofer(lblCodigo.Text))
            {
                Response.Redirect("ChoferMan01.aspx");
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
        Response.Redirect("ChoferMan01.aspx");
    }
}