using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class sunutma : System.Web.UI.Page
{
    OleDbConnection baglanti;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
           + Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");

        OleDbCommand komut = new OleDbCommand("select id, kullaniciadi from kayitol", baglanti);
        baglanti.Open();

        OleDbDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            lta.Text += "<div class='aa'>"+"<a href='sunutma2.aspx?s=" + oku["id"].ToString() + "'>"+"Hesabı Güncelle"+"</a>"+"</div>" + " - " + "Kullanıcı Adı : " + oku["kullaniciadi"].ToString()+"</br>"+"</br>"; 
        }

        
    }
    protected void txtskadi_TextChanged(object sender, EventArgs e)
    {

    }
}