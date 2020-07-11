using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin : System.Web.UI.MasterPage
{
    OleDbConnection baglanti;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["oturum"] == null) && (Session["txtkadi"] == null))
        {
            Panel2.Visible = false;
        }
        else
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            ltbil.Text = "Hoşgeldiniz " + Session["kullaniciadi"].ToString()+"</br>"+"</br>"+"<a href='mekle.aspx'>"+"Müziğini ekle, dünya gerçek bir müzik dinlesin!"+"</a>";
        }


        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand("select id, gonderen, konu, istek from ziyaretci order by id desc", baglanti);

        OleDbDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            ltyorum.Text += "<h3>" + oku["gonderen"].ToString() + "</h3>" + "</br>"+"<h4>"+oku["konu"].ToString()+"</h4>"+"</br>"+"<p>"+oku["istek"].ToString()+"</p>";

        }

    }
    protected void giris_Click(object sender, EventArgs e)
    {
        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
          + Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand("select id, kullaniciadi, sifre from kayitol where kullaniciadi='" + txtkadi.Text + "'and sifre='" + txtsifre.Text + "'", baglanti);

        OleDbDataReader oku = komut.ExecuteReader();


        if (oku.Read())
        {
            Session["oturum"] = oku["id"].ToString();
            Session["kullaniciadi"] = oku["kullaniciadi"].ToString();
            Panel1.Visible = false;
            Panel2.Visible = true;
            ltbil.Text = "Hoşgeldiniz " + Session["kullaniciadi"].ToString();
            Response.Redirect("Default.aspx");
        }
        else
        {
            ltuyari.Text = "</br>"+"<span class='hata' >Kullanıcı adı veya şifreniz yanlış</span>";
        }
        baglanti.Close();
    }
    protected void btnoturum_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Default.aspx");
    }
    protected void btnarama_Click(object sender, EventArgs e)
    {
        Response.Redirect("ara2.aspx?s=" + txtarama.Text);
    }
    }

