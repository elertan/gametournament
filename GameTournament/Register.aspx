<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GameTournament.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
	<form id="form" runat="server">
		<input name="firstname" class="form-control" placeholder="Firstname" type="text" />
		<input name="lastname" class="form-control" placeholder="Lastname" type="text" />
		<input name="studentnumber" class="form-control" placeholder="Studentnumber" type="number" />
		<input type="submit" value="Send lel" runat="server" id="formSubmit" />
	</form>
</asp:Content>
