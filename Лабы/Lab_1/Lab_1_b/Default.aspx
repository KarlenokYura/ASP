<%@ Page Title="Lab 1 (b)" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab_1_b._Default" %>

<!DOCTYPE html>
<html>
<head>
    <title>Lab 1 (b)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top: 10px">
            <input type="hidden" name="_VIEWSTATEFIELDCOUNT" id="_VIEWSTATEFIELDCOUNT" value="3" />
            <input type="hidden" name="_VIEWSTATE1" id="_VIEWSTATE1" value="/wEPDwUKLTk2Njk3OTQxNg9kFgICAw9kFgICCQ88" />
            <input type="hidden" name="_VIEWSTATE2" id="_VIEWSTATE2" value="KwANAGQYAQUJR3JpZFZpZXcxD2dk4sjERFfnDXV/" />
            <input type="hidden" name="_VIEWSTATE3" id="_VIEWSTATE3" value="hMFGAL10HQUnZbk=" />
        </div>
        <div style="margin-top: 10px">
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"/>
            <asp:Button ID="Button2" runat="server" Text="Button" style="margin-left: 20px" OnClick="Button2_Click"/>
            <asp:Button ID="Button3" runat="server" Text="Button" style="margin-left: 20px" OnClick="Button3_Click"/>
        </div>
        <div style="margin-top: 10px">
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Events:"></asp:Label>
            <asp:Button ID="Button4" runat="server" Text="Button" style="margin-left: 20px" OnClick="Button4_Click"/>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" />
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>