<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GaragePortal.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:25%;">
            <table style="width: 54%;">
               <tr>
                  <td>User Name:</td>
                  <td>
                        <asp:TextBox ID="tb_userName" runat="server"></asp:TextBox>
                  </td>
               </tr>
				
               <tr>
                  <td>Password</td>
                  <td >
                     <asp:TextBox ID="tb_password" runat="server"></asp:TextBox>
                  </td>
               </tr>	
               <tr>
                  <td>
                     <asp:Button ID="btLogin" runat="server" OnClick="btLogin_Click" style="width: 47px" Text="Login"></asp:Button>
                  </td>
               </tr>
            </table>
        </div>
        <p>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="tb_userName" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_password" ValidationExpression="^.*(?=.{8,}).*$"  ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        </p>
    </form>
</body>
</html>
