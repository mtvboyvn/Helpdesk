<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeBehind="ThemDoiTen_VNACCS.aspx.vb" Inherits="HelpDesk.ThemDoiTen_VNACCS"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
    
       Mã đơn vị
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" 
            Text="Tên đơn vị VNACCS:"></asp:Label>
&nbsp;<asp:Label ID="Label6" runat="server" BackColor="Red" Text="Label"></asp:Label>
        &nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" 
            Text="Tên đơn vị mới:"></asp:Label>
&nbsp;<asp:Label ID="Label1" runat="server" BackColor="Red" Text="Label"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Text="Địa chỉ cũ:"></asp:Label>
        &nbsp;<asp:Label ID="Label8" runat="server" BackColor="Red" Text="Label"></asp:Label>
        &nbsp;
        <asp:Label ID="Label3" runat="server" Text="Địa chỉ mới:"></asp:Label>
        <asp:Label ID="Label4" runat="server" BackColor="Red" Text="Label"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Đổi tên đơn vị này" />
    
        &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Đổi địa chỉ đơn vị này" />
    
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx">Quay 
        lại</asp:LinkButton>
&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Doiten.aspx">Tải 
        lại trang</asp:LinkButton>
    </div>
</asp:Content>



