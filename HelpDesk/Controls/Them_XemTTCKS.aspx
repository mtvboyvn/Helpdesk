<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeBehind="Them_XemTTCKS.aspx.vb" Inherits="HelpDesk.Them_XemTTCKS"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
   
    <div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Button ID="Button1" runat="server" Text="Xem thông tin CKS" />
<asp:GridView ID="GridView1" runat="server">
</asp:GridView>

    </div>
</asp:Content>



