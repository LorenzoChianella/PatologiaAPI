using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class Certificati : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                RootObject<Certificato> cer;
                cer = ApiRestClient.GetCertificatiDataFromServer();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[13] {
                            new DataColumn("Codice Paziente", typeof(string)),
                            new DataColumn("Codice Medico", typeof(string)),
                            new DataColumn("Data Emissione", typeof(string)),
                            new DataColumn("Codice Patologia", typeof(string)),
                            new DataColumn("Data Inizio", typeof(string)),
                            new DataColumn("Data Fine", typeof(string)),
                            new DataColumn("Tipologia", typeof(string)),
                            new DataColumn("Comune", typeof(string)),
                            new DataColumn("Provincia", typeof(string)),
                            new DataColumn("Indirizzo", typeof(string)),
                            new DataColumn("CAP", typeof(string)),
                            new DataColumn("Domicilio", typeof(string)),
                            new DataColumn("Note", typeof(string))
                });

                for (int i = 0; i < cer.items; i++)
                {
                    dt.Rows.Add(cer.data[i].codPaziente, cer.data[i].codMedico, cer.data[i].dataEmissione, cer.data[i].codPatologia, cer.data[i].dataInizio,
                        cer.data[i].dataFine, cer.data[i].tipologia, cer.data[i].comune, cer.data[i].provincia, cer.data[i].indirizzo,
                        cer.data[i].cap, cer.data[i].domicilio, cer.data[i].note);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //GridView1.Columns[1].Visible = false;
            }
        }

    }
}