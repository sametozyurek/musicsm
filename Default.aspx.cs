﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    OleDbConnection baglanti = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        baglanti = new OleDbConnection("Provider="+"Microsoft.ACE.OLEDB.12.0;"+ "Data Source=" + Server.MapPath("~/App_Data/vta.accdb") + "; Persist Security Info=True");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand("select id, muzikyol from muzik order by id desc", baglanti);
        
        OleDbDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            ltmuzikler.Text += "<h3>"+oku["muzikyol"].ToString()+"</h3>" +"</br>"+"<audio id='muzikk' controls='controls' runat='server'>" + "<source src='muzikler/" + oku["muzikyol"].ToString()+"'>" + "</source>"+"</audio>";

        }
    }
}