<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropdownSample.aspx.cs" Inherits="WebFormsSample.DropdownSample" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:dropdownlist runat="server" ID="DropDownList1" AutoPostBack="True" Height="108px" OnSelectedIndexChanged="OnSelectionChanged" Width="432px">
                <asp:ListItem>One</asp:ListItem>
                <asp:ListItem>Two</asp:ListItem>
                <asp:ListItem>Three</asp:ListItem>
            </asp:dropdownlist>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <button runat="server" id="htmlbutton1" onserverclick="htmlbutton1_ServerClick">html button - click me!</button>
    </form>
</body>

</html>
