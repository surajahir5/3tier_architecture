<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="_3tier_architecture.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous" />
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css" integrity="sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A==" crossorigin="anonymous" referrerpolicy="no-referrer" />
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js" integrity="sha512-aVKKRRi/Q/YV+4mjoKBsE4x3H+BkegoM/em46NNlCqNTmUYADjBbeNefNxYV7giUp0VxICtqdrbqU7iVaeZNXA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <link rel="stylesheet" href="//cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
  <%--<link href="BootStrap/css/dataTables.bootstrap5.min.css" rel="stylesheet" />
  <script src="BootStrap/css/dataTables.bootstrap5.min.js"></script>--%>
  <script src="//cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
  <script>
    $(document).ready(function () {
      $('#mytable').DataTable();

            });
  </script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server" onitemcommand="Repeater1_ItemCommand">
            <HeaderTemplate>
                <table id="mytable">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Mobile</th>
                            <th>Gender</th>
                            <th>Usertype</th>
                            <th>Image</th>
                            <th>Update</th>
                            <th>
                                <asp:Button ID="Button1" runat="server" Text="Delete" /></th>
                        </tr>
                    </thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl1" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("name") %>' Visible="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("email") %>' Visible="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("mobile") %>'></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("mobile") %>' Visible="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("gender") %>'></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Text='<%# Eval("gender") %>' Visible="false">
                            <asp:ListItem Value="Male"> </asp:ListItem>
                            <asp:ListItem Value="Female"></asp:ListItem>
                            <asp:ListItem Value="Other"></asp:ListItem>
                        </asp:RadioButtonList>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("usertype") %>'></asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Eval("usertype") %>' Visible="false">
                            <asp:ListItem Value="admin"></asp:ListItem>
                            <asp:ListItem Value="user"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Image ID="lbl_Image" runat="server" ImageUrl='<%# Eval("image") %>' Height="40px" Width="40px" />
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' height="150px" Width="150px" Visible="false"/>
                        <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
                    </td>
                    <td>
                        <asp:LinkButton ID="Linkedit" runat="server" CommandArgument="'<%#Eval(id) %>'" CommandName="edit">edit</asp:LinkButton>
                        <asp:LinkButton ID="Linkupdate" Visible="false" CommandArgument="'<%#Eval(id) %>'" CommandName="update" runat="server">update</asp:LinkButton>
                        <asp:LinkButton ID="Linkcancel" Visible="false" runat="server" CommandArgument="'<%#Eval(id) %>'" CommandName="cancel">cancel</asp:LinkButton>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
