<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TaikhoanQT.aspx.vb" Inherits="HelpDesk.TaikhoanQT" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form2" runat="server">
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
    </form>
</body>
</html>
