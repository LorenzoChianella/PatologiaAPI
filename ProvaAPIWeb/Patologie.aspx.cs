using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class Patologie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                RootObject<Patologia> pat;
                pat = ApiRestClient.GetPatologieDataFromServer();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] {
                            new DataColumn("Codice Patologia", typeof(string)),
                            new DataColumn("Nome", typeof(string)),
                            new DataColumn("Descrizione", typeof(string))});

                for(int i= 0; i< pat.items; i++)
                {
                    dt.Rows.Add(pat.data[i].cod_patologia, pat.data[i].nome, pat.data[i].descrizione);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string s = row.Cells[1].Text;
            // DataTable dt; 
            //dt = (DataTable) GridView1.DataSource;
            //dt.Rows.Find()

            // recuperare il codice della patologia associato alla riga eliminata
            // inviare tale codice ( mediante le classi del webclient ) al webservice di tipo restful esposto, in formato JSON.



        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}