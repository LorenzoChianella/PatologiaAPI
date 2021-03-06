﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProvaAPIWeb
{
    public partial class Medici : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                RootObject<Medico> med;
                med = ApiRestClient.GetMediciDataFromServer();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[13] {
                            new DataColumn("Nome", typeof(string)),
                            new DataColumn("Cognome", typeof(string)),
                            new DataColumn("Data Nascita", typeof(string)),
                            new DataColumn("Luogo", typeof(string)),
                            new DataColumn("Codice Fiscale", typeof(string)),
                            new DataColumn("Residenza", typeof(string)),
                            new DataColumn("Provincia", typeof(string)),
                            new DataColumn("Indirizzo", typeof(string)),
                            new DataColumn("Telefono", typeof(string)),
                            new DataColumn("Mobile", typeof(string)),
                            new DataColumn("Email", typeof(string)),
                            new DataColumn("Codice Albo", typeof(string)),
                            new DataColumn("Codice Medico", typeof(string))
                });

                for (int i = 0; i < med.items; i++)
                {
                    dt.Rows.Add(med.data[i].nome, med.data[i].cognome, med.data[i].data_nascita, med.data[i].luogo,
                                med.data[i].cod_fis, med.data[i].residenza, med.data[i].provincia, med.data[i].indirizzo,
                                med.data[i].telefono, med.data[i].mobile, med.data[i].email, med.data[i].cod_albo,
                                med.data[i].cod_medico);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                //GridView1.Columns[1].Visible = false;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string s = row.Cells[14].Text;
            ApiRestClient.DeleteMedico(s);
            Response.Redirect("Medici.aspx");
            GridView1.DataBind();
        }

        protected void btnInserisciNuovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("InserisciMedico.aspx");
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.NewEditIndex];
            string cod_medico = row.Cells[14].Text;
            Response.Redirect("ModificaMedico.aspx?cod_medico=" + cod_medico);

        }
    }
}