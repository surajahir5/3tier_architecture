<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="uppropic.aspx.cs" Inherits="_3tier_architecture.uppropic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <script src="//code.jquery.com/jquery-1.11.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ShowImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(240)
                        .height(150);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Text="Upload Your Profile Picture"></asp:Label>

    <asp:FileUpload ID="FileUpload1" onchange="ShowImagePreview(this)" runat="server" />
    <br />
<asp:Image ID="Image1" runat="server" Height="176px" Width="229px" />
<br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />

&nbsp;
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>
