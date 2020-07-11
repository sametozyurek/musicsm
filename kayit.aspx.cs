using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class kayit : System.Web.UI.Page
{
    OleDbConnection baglanti = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
       


    }
    protected void btnkaydet_Click(object sender, EventArgs e)
    {
        baglanti.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand( "insert into kayitol(kullaniciadi, sifre, eposta) values( '"+ txtkadi.Text +"', '"+txtsifre.Text+"', '"+txtmail.Text+"' )",baglanti );

        txtkadi.Text = "";
        txtsifre.Text = "";
        txtmail.Text = "";

        lt1.Text =" Kayıt Oldunuz " ;

        komut.ExecuteNonQuery();
        baglanti.Close();
        
    }
}