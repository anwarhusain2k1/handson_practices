<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View2" runat="server">
                User Name :<asp:TextBox ID="txtusername" runat="server" Width="169px"></asp:TextBox>
                <br />
                <br />
                Password&nbsp;&nbsp; :<asp:TextBox ID="txtpass" runat="server" MaxLength="20" Width="167px">
</asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" BorderColor="#00CC00" style="margin-left: 22px" Text="login" Width="86px" OnClick="Button1_Click" />
                <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="margin-left: 42px" Text="create account" Width="144px" />
                <br />
            </asp:View>
            <asp:View ID="View3" runat="server">
                First Name:<asp:TextBox ID="TextBox6" runat="server" style="margin-left: 18px" Width="250px"></asp:TextBox>
                <br />
                <br />
                Last Name :<asp:TextBox ID="TextBox7" runat="server" style="margin-left: 17px"></asp:TextBox>
                <br />
                <br />
                Date of Birth:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <br />
                City:<asp:TextBox ID="TextBox9" runat="server" style="margin-left: 72px"></asp:TextBox>
                <br />
                <br />
                Sate :<asp:TextBox ID="TextBox10" runat="server" style="margin-left: 66px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="margin-left: 29px" Text="signin" Width="94px" />
            </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
