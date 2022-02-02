<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FootWareIndex.aspx.cs" Inherits="OnlineFootWare.FootWareIndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online FootWare</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <asp:DropDownList ID="DDCategory" runat="server">
                    <asp:ListItem>Kid</asp:ListItem>
                    <asp:ListItem>Men</asp:ListItem>
                    <asp:ListItem>Women</asp:ListItem>
                </asp:DropDownList>
                <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
                <asp:Label ID="lblHeader" runat="server" Text="FootWare Shop"></asp:Label>
            </nav>
        </div>
        <div class="table ">
            <asp:GridView ID="GVProductData" runat="server"></asp:GridView>
        </div>
        <div id="div1" runat="server">
            <asp:TextBox ID="txtProductCode" runat="server" PlaceHolder="Enter a ProductId" ></asp:TextBox>
            <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
        </div>
        
    </form>
</body>
</html>
