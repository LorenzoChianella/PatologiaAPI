using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class ModificaPatologia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string codice = Request["cod_patologia"];
            ApiRestClient.GetPatologia(codice);



        }

        protected void btnSalva_Click(object sender, EventArgs e)
        {

        }
    }
}