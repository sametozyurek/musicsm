<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="kayit.aspx.cs" Inherits="kayit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="kayitol">

<h1> Bize Katılın ve Kendi Müzik Dünyanızı Oluşturun </h1>
<table>
	<tr>
		<td>
            <asp:Label ID="lblkadi" runat="server" Text="Kullanıcı Adı : " Font-Size="Large" Height="35"></asp:Label></td>
		<td>
            <asp:TextBox ID="txtkadi" runat="server" Height="20" placeholder="Kullanıcı Adı"></asp:TextBox></td>
		<td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Bu Alan Boş Geçilemez." ControlToValidate="txtkadi"></asp:RequiredFieldValidator></td>
	</tr>
	<tr>
		<td>
            <asp:Label ID="lblsifre" runat="server" Text="Şifreniz : " Font-Size="Large" Height="35"></asp:Label></td>
		<td>
            <asp:TextBox ID="txtsifre" runat="server" Height="20" placeholder="Şifre" TextMode="Password"></asp:TextBox></td>
		<td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Bu Alan Boş Geçilemez." ControlToValidate="txtsifre"></asp:RequiredFieldValidator></td>
	</tr>
	<tr>
		<td>
            <asp:Label ID="lblmail" runat="server" Text="E-Posta Adresiniz : " Font-Size="Large" Height="35"></asp:Label></td>
		<td>
            <asp:TextBox ID="txtmail" runat="server" Height="20" placeholder="E-Posta" 
                 ></asp:TextBox></td>
		<td>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="E-Posta Adresinizi Girin" ControlToValidate="txtmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
	</tr>
    <tr>
    	<td>
            <asp:Button ID="btnkaydet" runat="server" Text="Kayıl Ol!" Font-Bold="True" 
                Font-Size="X-Large" BackColor="#FF6600" ForeColor="White" Height="45px" 
                Width="122px" onclick="btnkaydet_Click" /></td>
    	<td>
        <div class="lt">
            <asp:Literal ID="lt1" runat="server">
            
            </asp:Literal>
            </td>
    	</div>
    </tr>
</table>

</div><!-- kayıt ol sonu !-->


</asp:Content>

