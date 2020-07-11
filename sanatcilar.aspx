<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="sanatcilar.aspx.cs" Inherits="sanatcilar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="sanatci">

<div class="icerik">

<h2>Tarkan Tevetoğlu</h2>
<img src="resimler/tarkan.jpg" alt="">

<h3>Genel Bilgiler</h3>

<table>
	<tr>
		<td>
            <h4>Doğum</h4></td>
		<td>
            <asp:Label ID="Label2" runat="server" Text="17 Ekim 1972 (42 yaşında) Alzey, Renanya-Palatina, Batı Almanya"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Tarzlar</h4></td>
		<td>
            <asp:Label ID="Label4" runat="server" Text="Pop ·  pop rock ·  dans pop ·  Türk sanat"></asp:Label></td>
	</tr>
	<tr>
		<td>
            <h4>Meslekler</h4></td>
		<td>
            <asp:Label ID="Label6" runat="server" Text="Şarkıcı ·  söz yazarı ·  besteci ·  prodüktör ·  aranjör"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Etkin Yılları</h4></td>
		<td>
            <asp:Label ID="Label8" runat="server" Text="1992–günümüz"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Plak Şirketi</h4></td>
		<td>
            <asp:Label ID="Label10" runat="server" Text="İstanbul ·  Universal ·  DMC ·  HITT"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Resmi Sitesi</h4></td>
		<td>
            <a href="http://www.tarkan.com/">tarkan.com</a></td>
	</tr>
</table>

</div>

<div class="icerik">

<h2>Sıla Gençoğlu</h2>
<img src="resimler/sila.jpg" alt="">

<h3>Genel Bilgiler</h3>

<table>
	<tr>
		<td>
            <h4>Doğum</h4></td>
		<td>
            <asp:Label ID="Label1" runat="server" Text="17 Haziran 1980 (34 yaşında) Acıpayam, Denizli, Türkiye"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>İkamet</h4></td>
		<td>
            <asp:Label ID="Label3" runat="server" Text="Beyoğlu, İstanbul, Türkiye"></asp:Label></td>
	</tr>
	<tr>
		<td>
            <h4>Eğitim</h4></td>
		<td>
            <asp:Label ID="Label5" runat="server" Text="İstanbul Üniversitesi - İstanbul Bilgi Üniversitesi"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Meslekler</h4></td>
		<td>
            <asp:Label ID="Label7" runat="server" Text="Şarkıcı ·  söz yazarı ·  besteci ·  yapımcı"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Tarzlar</h4></td>
		<td>
            <asp:Label ID="Label9" runat="server" Text="Pop ·  caz  ·  rock"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Resmi Sitesi</h4></td>
		<td>
            <a href="http://www.silagencoglu.com/">silagencoglu.com</a></td>
	</tr>
</table>

</div>

<div class="icerik">

<h2>MODEL</h2>
<img src="resimler/model.png" alt="">

<h3>Genel Bilgiler</h3>

<table>
	<tr>
		<td>
            <h4>Müziğe Başladığı Yer</h4></td>
		<td>
            <asp:Label ID="Label11" runat="server" Text="İzmir, Türkiye"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Tarzlar</h4></td>
		<td>
            <asp:Label ID="Label12" runat="server" Text="Alternatif Rock, Pop Rock"></asp:Label></td>
	</tr>
	<tr>
		<td>
            <h4>Etkin Yılları</h4></td>
		<td>
            <asp:Label ID="Label13" runat="server" Text="2005-günümüz"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Plak Şirketi</h4></td>
		<td>
            <asp:Label ID="Label14" runat="server" Text="Sony Music (2009) GNL / DMC (2011-günümüz)"></asp:Label></td>
	</tr>

	<tr>
		<td>
            <h4>Üyeler</h4></td>
		<td>
        <ul>
        	<li>Fatma Turgut ( Vokal )</li>
        	<li>Okan Işık ( Gitar )</li>
        	<li>Can Temiz ( Bas Gitar )</li>
        	<li>Kerem Sedef ( Davul )</li>
        </ul>
        </td> 
            
	</tr>

	<tr>
		<td>
            <h4>Eski Üyeler</h4></td>
		<td>
              <ul>
        	<li>Serkan Gürüzümcü</li>
        	<li>Aşkın Çolak</li>
        	<li>Burak Yerebakan</li>
        	
        </ul>
            </td>
      
	</tr>
</table>

</div>

</div><!-- sanatcılar sonu !-->

</asp:Content>

