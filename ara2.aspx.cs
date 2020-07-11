using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class ara2 : System.Web.UI.Page
{
    OleDbConnection baglanti;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {

            if (Request.QueryString["s"] != null)
            {

                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb") + ";");
                baglanti.Open();

                string konu1 = Request.QueryString["s"].ToString();


                OleDbCommand komut = new OleDbCommand("SELECT * FROM muzik WHERE muzikyol LIKE '%" + konu1.ToString() + "%'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    ltarama.Text += "<h3>" + oku["muzikyol"].ToString() + "</h3>" + "</br>" + "<audio id='muzikk' controls='controls' runat='server'>" + "<source src='muzikler/" + oku["muzikyol"].ToString() + "'>" + "</source>" + "</audio>";
                }

            }

                 else
                 {
                     Response.Redirect("Default.aspx");
                 }

            baglanti.Close();

        }
    }
}