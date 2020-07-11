using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.IO;


public partial class mekle : System.Web.UI.Page
{
    OleDbConnection baglanti = new OleDbConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnmekle_Click(object sender, EventArgs e)
    {
       

        HttpPostedFile muzikler = fu2.PostedFile;
       if (muzikler != null)
        {
            FileInfo yuklenecek = new FileInfo(muzikler.FileName);
            string yuklemeyeri = Server.MapPath("~/muzikler" + "/" + yuklenecek.Name);
            fu2.SaveAs(yuklemeyeri);
        }

        OleDbConnection baglanti;

        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Server.MapPath("~/App_Data/vta.accdb") + ";Persist Security Info=True");
        baglanti.Open();

        OleDbCommand komut = new OleDbCommand("INSERT into muzik (muzikyol) values('" + fu2.FileName.ToString() +"') " , baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        }
}
