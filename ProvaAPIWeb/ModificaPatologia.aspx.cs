using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ProvaAPIWeb
{
    public partial class ModificaPatologia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string codice = Request["cod_patologia"];
                Patologia pat = ApiRestClient.GetPatologia(codice);
            }
                
        }

        protected void btnsalva_Click(object sender, EventArgs e)
        {
            
        }

        protected void RiempiTxt()
        {
            

        }

    }
}