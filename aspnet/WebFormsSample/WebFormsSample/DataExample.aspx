<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataExample.aspx.cs" Inherits="WebFormsSample.DataExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="BookId" HeaderText="BookId" ReadOnly="True" SortExpression="BookId" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" SortExpression="Title" />
                <asp:BoundField DataField="Publisher" HeaderText="Publisher" ReadOnly="True" SortExpression="Publisher" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=RazorBooksEntities" DefaultContainerName="RazorBooksEntities" EnableFlattening="False" EntitySetName="Books" Select="it.[BookId], it.[Title], it.[Publisher]">
        </asp:EntityDataSource>
    </form>
</body>
</html>
