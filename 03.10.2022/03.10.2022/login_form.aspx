<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_form.aspx.cs" Inherits="_03._10._2022.login_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style ="background-color :antiquewhite" >

            WELCOME TO THE LIBRARY...<br />
            <br />
            <br />
            USERNAME&nbsp; :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            PASSWORD&nbsp; :<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
            <br />
            <br />

        </div>
    </form>
</body>
</html>
