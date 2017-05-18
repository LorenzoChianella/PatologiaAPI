using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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



                for (int i = 0; i < pat.items; i++)
                {
                    dt.Rows.Add(pat.data[i].cod_patologia, pat.data[i].nome, pat.data[i].descrizione);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //GridView1.Columns[1].Visible = false;
            }
        }
        protected void Gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string s = row.Cells[1].Text;
            ApiRestClient.DeletePatologia(s);
            GridView1.DataBind();

            // recuperare il codice della patologia associato alla riga eliminata
            // inviare tale codice ( mediante le classi del webclient ) al webservice di tipo restful esposto, in formato JSON.
        }

        protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[1].Visible = false; // hides the first column
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.NewEditIndex];
            string s = row.Cells[1].Text;
            Response.Redirect("");

        }

        protected void btnInserisci_Click(object sender, EventArgs e)
        {
            Response.Redirect("InserisciPatologia.aspx");
        }
    }
}