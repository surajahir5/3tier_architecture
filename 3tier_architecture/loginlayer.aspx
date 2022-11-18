<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginlayer.aspx.cs" Inherits="_3tier_architecture.loginlayer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  
</head>
<body>
 <form id="form1"  runat="server">
     <div style="text-align:center">
     <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" Width="165px"></asp:TextBox>
     <br />
     <br />
     <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" Width="165px"></asp:TextBox>
     <br />
     <br />
      </div>
     <div style="text-align:center">
     <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" Width="60px" />
     &nbsp;&nbsp;&nbsp;
         <br />
         <asp:HyperLink ID="HyperLink1" runat="server" BackColor="Red">Forget Password ?</asp:HyperLink>
     </div>
</form>
</body>
</html>
