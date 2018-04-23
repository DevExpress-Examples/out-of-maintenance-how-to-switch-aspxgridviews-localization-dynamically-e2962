<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<%@ Register Assembly="DevExpress.Web.ASPxGridView.v11.2, Version=11.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v11.2, Version=11.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
	<title>How to select ASPxGridView's localization with a user interface</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<br />
		<dx:ASPxGridView ID="grid" runat="server">
			<Settings ShowGroupPanel="True" />
		</dx:ASPxGridView>
	</div>
	<dx:ASPxComboBox ID="combo" runat="server" AutoPostBack="True"
		SelectedIndex="0" ValueType="System.String" oninit="combo_Init" >
		<ClientSideEvents SelectedIndexChanged="function (e, s) { ASPxClientUtils.SetCookie('Lang', combo.GetValue()); }" />
		<Items>
			<dx:ListEditItem Selected="True" Text="English" Value="en-US" />
			<dx:ListEditItem Text="Deutsch" Value="de-DE" />
			<dx:ListEditItem Text="Française" Value="fr-FR" />
		</Items>
	</dx:ASPxComboBox>
	</form>
</body>
</html>