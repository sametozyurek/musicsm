﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yabanci : System.Web.UI.Page
{
    OleDbConnection baglanti = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand("select id, ymuzikyol from yabanci order by id desc", baglanti);

        OleDbDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            ymuzik.Text += "<h3>" + oku["ymuzikyol"].ToString() + "</h3>" + "</br>" + "<audio id='ymuzikk' controls='controls' runat='server'>" + "<source src='yabancimuzik/" + oku["ymuzikyol"].ToString() + "'>" + "</source>" + "</audio>";

        }
    }
}