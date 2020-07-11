<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="ziyaretci.aspx.cs" Inherits="ziyaretci" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="istek">

<table>
	<tr>
		<td>
            <h4>Gönderen : </h4></td>
		<td>
            <asp:TextBox ID="txtgonderen" runat="server" Font-Size="Medium" 
                ForeColor="#666666" Height="34px" Width="165px"></asp:TextBox></td>
	</tr>
    
	<tr>
		<td> <h4>Konu : </h4> </td>
		<td>
            <asp:TextBox ID="txtkonu" runat="server" Font-Size="Medium" ForeColor="#666666" 
                Height="34px" Width="165px"></asp:TextBox></td>
	</tr>

	<tr>
		<td> <h4>Mesajınız: </h4> </td>
		<td> 
            <CKEditor:CKEditorControl ID="ck1" runat="server" width="550" ></CKEditor:CKEditorControl> </td>
	</tr>

	<tr>
		<td>
            <asp:Button ID="btngonder" runat="server" Text="Gönder" BackColor="#FF6600" 
                ForeColor="#FFFFCC" Height="40px" Width="70px" 
                 Font-Size="Large" onclick="btngonder_Click"/></td>
		<td>
            <asp:Literal ID="ltistek" runat="server"></asp:Literal></td>
	</tr>
</table>

</div><!-- istek sonu !-->

</asp:Content>

