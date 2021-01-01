<%@ Page Title="Lab 1" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_1._Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Lab 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Моя первая страница</div>
        <div style="margin-top: 10px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" style="margin-left: 20px" OnClick="Button1_Click"/>
            <asp:Label ID="Label1" runat="server" Text="Text" style="margin-left: 20px" ></asp:Label>
        </div>
        <div style="margin-top: 10px">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true">
                <asp:ListItem Selected="True" Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div style="margin-top: 10px">
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </div>
    </form>
</body>
</html>