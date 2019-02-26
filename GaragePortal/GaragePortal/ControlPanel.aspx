<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="GaragePortal.ControlPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <h1>Control Panel</h1>
                <asp:SqlDataSource ID="sql_grage"  runat="server"></asp:SqlDataSource>
                <asp:GridView ID="grid__carsTable" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
