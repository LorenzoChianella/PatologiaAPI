using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class Pazienti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                RootObject<Paziente> paz;
                paz = ApiRestClient.GetPazientiDataFromServer();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[15] {
                            new DataColumn("Nome", typeof(string)),
                            new DataColumn("Cognome", typeof(string)),
                            new DataColumn("Sesso", typeof(string)),
                            new DataColumn("Data Nascita", typeof(string)),
                            new DataColumn("Luogo", typeof(string)),
                            new DataColumn("Codice Fiscale", typeof(string)),
                            new DataColumn("Residenza", typeof(string)),
                            new DataColumn("Provincia", typeof(string)),
                            new DataColumn("Indirizzo", typeof(string)),
                            new DataColumn("CAP", typeof(string)),
                            new DataColumn("Telefono", typeof(string)),
                            new DataColumn("Mobile", typeof(string)),
                            new DataColumn("Email", typeof(string)),
                            new DataColumn("Codice Sanitario", typeof(string)),
                            new DataColumn("Codice Medico", typeof(string))
                });

                for (int i = 0; i < paz.items; i++)
                {
                    dt.Rows.Add(paz.data[i].nome, paz.data[i].cognome, paz.data[i].Sesso,  paz.data[i].data_nascita,paz.data[i].luogo,
                        paz.data[i].cod_fis, paz.data[i].residenza, paz.data[i].provincia, paz.data[i].indirizzo,
                        paz.data[i].cap, paz.data[i].telefono, paz.data[i].mobile, paz.data[i].email, paz.data[i].cod_sanitario, paz.data[i].cod_medico);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //GridView1.Columns[1].Visible = false;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_OnRowDeleting(object sender, GridViewDeleteEventArgs e) {

            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string s = row.Cells[1].Text;
            ApiRestClient.DeletePaziente(s);
            GridView1.DataBind();

        }
    }
}