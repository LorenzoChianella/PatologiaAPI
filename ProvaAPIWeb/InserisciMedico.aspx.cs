using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class InserisciMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalva_Click(object sender, EventArgs e)
        {
            Medico med = new Medico();
            med.nome = txtnome.Text;
            med.cognome = txtcognome.Text;
            med.luogo = txtluogo.Text;
            med.data_nascita = txtdatanascita.Text;
            med.cod_fis = txtcodicefiscale.Text;
            med.residenza = txtresidenza.Text;
            med.provincia = txtprovincia.Text;
            med.indirizzo = txtindirizzo.Text;
            med.telefono = txttel.Text;
            med.mobile = txtcell.Text;
            med.email = txtemail.Text;
            med.cod_albo = txtcodalbo.Text;
            med.cod_medico = txtcodmedico.Text;

            ApiRestClient.SendMedicoToServer(med);
            Response.Redirect("Medici.aspx");
        }
    }
}