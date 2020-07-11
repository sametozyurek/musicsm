using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class ziyaretci : System.Web.UI.Page
{
    OleDbConnection baglanti;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btngonder_Click(object sender, EventArgs e)
    {
        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");
        baglanti.Open();
        OleDbCommand komut = new OleDbCommand("insert into ziyaretci(gonderen, konu, istek) values(@gonderen, @konu, @istek)", baglanti);

        komut.Parameters.AddWithValue("@gonderen", txtgonderen.Text);
        komut.Parameters.AddWithValue("@konu", txtkonu.Text);
        komut.Parameters.AddWithValue("@istek", ck1.Text);


        komut.ExecuteNonQuery();
        baglanti.Close();
        ltistek.Text = "Mesajınız Başarıyla Gönderildi.";
    }
}