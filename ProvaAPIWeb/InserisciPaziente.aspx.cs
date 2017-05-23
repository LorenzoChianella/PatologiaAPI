using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class InserisciPaziente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalva_Click(object sender, EventArgs e)
        {
            Paziente paz = new Paziente();
            paz.nome = txtnome.Text;
            paz.cognome = txtcognome.Text;
            paz.Sesso = txtsesso.Text;
            paz.luogo = txtluogo.Text;
            paz.data_nascita = txtdatanascita.Text;
            paz.cod_fis = txtcodicefiscale.Text;
            paz.residenza = txtresidenza.Text;
            paz.provincia = txtprovincia.Text;
            paz.indirizzo = txtindirizzo.Text;
            paz.cap = txtcap.Text;
            paz.telefono = txttel.Text;
            paz.mobile = txtcell.Text;
            paz.email = txtemail.Text;
            paz.cod_sanitario = txtcodSanitario.Text;
            paz.cod_medico = txtcodMedico.Text;

            ApiRestClient.SendPazienteToServer(paz);
            Response.Redirect("Pazienti.aspx");
        }
    }
}