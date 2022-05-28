<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmSearchPersonnel.aspx.cs" Inherits="frmSearchPersonnel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Images/CIS407A_iLab_ACITLogo.jpg" NavigateUrl="~/frmMain.aspx">Academy of Computing and Information Technology</asp:HyperLink>
        <br />
        <asp:Label ID="lblSearch" runat="server" Text="Search for employee by last name:"></asp:Label>
        <br />
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSearch" runat="server"  PostBackUrl="~/frmViewPersonnel.aspx" Text="Search" />
    
    </div>
    </form>
</body>
</html>
