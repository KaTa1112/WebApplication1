<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<asp:Panel ID="PanelLogIn" runat="server">
    <h1>Welcome!</h1>
    <h2>Please enter your username and password to login</h2>
    <asp:Label ID="Label1" runat="server" Text="Username:" BorderStyle="None"></asp:Label>
    <asp:TextBox ID="TextBoxUsername" runat="server" style="margin-left: 26px" Width="147px"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" BorderStyle="None" Text="Password:"></asp:Label>
    <asp:TextBox ID="TextBoxPassword" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 26px" Width="145px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" />
</asp:Panel>
<asp:Panel ID="PanelError" runat="server" Visible="False">
    <h3>Username or password not valid</h3></asp:Panel>
<asp:Panel ID="PanelDisplay" runat="server" Visible="False">
    <asp:GridView ID="GridViewData" runat="server">
    </asp:GridView>
</asp:Panel>

