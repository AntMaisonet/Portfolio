<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>

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
        <asp:Panel ID="Panel1" runat="server" Height="1100px" Width="500px">
            <asp:Image ID="imgbtnCalculator" runat="server" Height="150px" ImageUrl="~/Images/calculator.png" Width="150px" />
            <asp:LinkButton ID="linkbtnCalculator" runat="server" PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnNewEmployee" runat="server" Height="158px" ImageUrl="~/Images/personnel.jpg" Width="155px" />
            <asp:LinkButton ID="linkbtnNewEmployee" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add a New Employee</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnViewUserActivity" runat="server" ImageUrl="~/Images/UserActivity.jpg" Width="150px" />
            <asp:LinkButton ID="linkbtnViewUserActivity" runat="server" PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnViewPersonnel" runat="server" Height="150px" ImageUrl="~/Images/View Personnel.png" Width="150px" />
            <asp:LinkButton ID="linkbtnViewPersonnel" runat="server" PostBackUrl="~/frmViewPersonnel.aspx">View Personnel</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnSearch" runat="server" Height="125px" ImageUrl="~/Images/Search Personnel.jpg" Width="150px" />
            <asp:LinkButton ID="linkbtnSearch" runat="server" PostBackUrl="~/frmSearchPersonnel.aspx">Search Personnel</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnEditEmployees" runat="server" Height="150px" ImageUrl="~/Images/Edit Employees.png" Width="150px" />
            <asp:LinkButton ID="linkbtnEditEmployees" runat="server" PostBackUrl="~/frmEditPersonnel.aspx">Edit Employees</asp:LinkButton>
            <br />
            <asp:Image ID="imgbtnManageUsers" runat="server" Height="150px" ImageUrl="~/Images/Manage Users.png" Width="150px" />
            <asp:LinkButton ID="linkbtnManageUsers" runat="server" PostBackUrl="~/frmManageUsers.aspx">Manage Users</asp:LinkButton>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
