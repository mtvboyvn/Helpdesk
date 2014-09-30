<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="HelpDesk._Default" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <asp:Panel runat="server" ID="AuthenticatedMessagePanel">
        <asp:Label runat="server" ID="WelcomeBackMessage"></asp:Label>
    </asp:Panel>
    
    <asp:Panel runat="Server" ID="AnonymousMessagePanel">
        <asp:HyperLink runat="server" ID="lnkLogin" Text="Log In" NavigateUrl="~/Login.aspx"></asp:HyperLink>
    </asp:Panel>
     <span class="style1">HELPDESK</span><br />
    <br />
   <%-- <asp:LinkButton ID="LinkButton1" runat="server" 
        PostBackUrl="~/TaikhoanQT.aspx">Tài khoản quản trị</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Daily.aspx">Thêm 
    DN cho đại lý</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/Doiten.aspx">Đổi 
    tên đơn vị</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton4" runat="server" 
        PostBackUrl="~/ThongtinCKS.aspx">Xem thông tin chữ ký số</asp:LinkButton>
    <br />
    <br />--%>
    <b>Kiểm tra tình trạng thông tin chuyến sang VNACCS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </b>
    <asp:Button ID="Button1" runat="server" Text="Test" />
    <br />
</asp:Content>


