<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="mekle.aspx.cs" Inherits="mekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="muzikekle">

<table>
	<tr>
		<td> <h2>Müzik Ekleyin</h2> </td>
		
	</tr>

	<tr>
		<td>
            <h3>Eklemek istediğin müziği seç</h3></td>
            <td>
                 </td>
		<td>
            <asp:FileUpload ID="fu2" runat="server" /></td>
	</tr>

	<tr>
		
		<td>
            <asp:Button ID="btnmekle" runat="server" Text="Ekle" BackColor="#FF6600" 
                ForeColor="#FFFFCC" Height="40px" Width="70px" 
                 Font-Size="Large" onclick="btnmekle_Click"/></td>

        <td>
            <asp:Literal ID="ltmuzik" runat="server"></asp:Literal></td>
	</tr>
</table>

</div><!-- muzikekle sonu !-->

</asp:Content>

