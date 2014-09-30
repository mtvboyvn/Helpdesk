<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeBehind="ThemTaiKhoanQuanTri.aspx.vb" Inherits="HelpDesk.ThemTaiKhoanQuanTri"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
    
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
<br />
<asp:Button ID="Button1" runat="server" Text="Thêm mới tài khoản quản trị" />
    
    </div>
    <p>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx">Quay 
        lại</asp:LinkButton>
    </p>
    </div>
</asp:Content>



