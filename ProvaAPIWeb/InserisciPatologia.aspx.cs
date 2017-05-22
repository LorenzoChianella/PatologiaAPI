using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class InserisciPatologia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalva_Click(object sender, EventArgs e)
        {
            Patologia pat = new Patologia();
            pat.cod_patologia = txtcodice.Text;
            pat.nome = txtnome.Text;
            pat.descrizione = txtdescrizione.Text;
            ApiRestClient.SendPatologiaToServer(pat);
            Response.Redirect("Patologie.aspx");
        }
    }
}