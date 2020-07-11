using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class sunutma2 : System.Web.UI.Page
{
    OleDbConnection baglanti = new OleDbConnection();
    int gelenid;
    protected void Page_Load(object sender, EventArgs e)
    {
        gelenid = Convert.ToInt32(Request.QueryString["s"]);
        if (!Page.IsPostBack)
        {
            baglanti.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb");
            baglanti.Open();


            OleDbCommand komut = new OleDbCommand("Select id, kullaniciadi, sifre, eposta from kayitol where id=" + gelenid, baglanti);

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                txtkadi.Text = oku["kullaniciadi"].ToString();
                txtsifre.Text = oku["sifre"].ToString();
                txtmail.Text = oku["eposta"].ToString();


            }
            else
            {
                ltsifredegisti.Text = "Böyle bir kayıt yok.";
            }


            baglanti.Close();
        }
    }

    protected void btnkaydet_Click(object sender, EventArgs e)
    {
        baglanti.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb");
        baglanti.Open();

        string sql = ("Update  kayitol set kullaniciadi = '" + txtkadi.Text + "', sifre = '" + txtsifre.Text + "', eposta = '" + txtmail.Text + "' where id =" + gelenid);
        OleDbCommand komut = new OleDbCommand(sql, baglanti);

        ltsifredegisti.Text = "Güncelleme işlemi Başarıyla Gerçekleşmiştir.. ";

        komut.ExecuteNonQuery();
        baglanti.Close();
    }
   
}
   
