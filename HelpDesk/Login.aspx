<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" Inherits="HelpDesk.Login" title="Login Page" Codebehind="Login.aspx.vb" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>
        Đăng nhập</h2>
    <p>
       <nobr> Tài khoản:
        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
           </nobr>
           </p>

    <p>
        <nobr>
        Mật khẩu:
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox></p>
    </nobr>
    <p>
        <asp:CheckBox ID="RememberMe" runat="server" Text="Nhớ tài khoản trên máy tính này" />&nbsp;</p>
    <p>
        
     <asp:Button ID="LoginButton" runat="server"  OnClick="LoginButton_Click"   Text="Đăng nhập" Skin="Metro" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
    <p>
        <asp:Label ID="InvalidCredentialsMessage" runat="server" ForeColor="Red" Text="Sai tài khoản / mật khẩu"
            Visible="False"></asp:Label>&nbsp;</p>
</asp:Content>



