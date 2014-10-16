<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="t.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 100%; background-color: #215a9d; text-align: center;">
            <span style="font-family: 'Segoe UI'; font-size: x-large; color: white;"><b>ĐĂNG NHẬP HỆ THỐNG TRA CỨU TỜ KHAI</b></span>
        </div>
        <div style="width:100%; ">
            <div style="width:300px;margin-left:auto;margin-right:auto;">
               
 <asp:Login  ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" PasswordLabelText="Mật khẩu:" RememberMeText="Tự động đăng nhập lần sau" UserNameLabelText="Tài khoản:" Width="300px" LoginButtonText="Đăng nhập" PasswordRequiredErrorMessage="Mật khẩu bắt buộc" TitleText="Đăng nhập" UserNameRequiredErrorMessage="Tài khoản bắt buộc" OnAuthenticate="Login1_Authenticate" UserName="TuyenHM" FailureText="Đăng nhập không thành công">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            </asp:Login>
                 
            </div>
           <div style="width:100%;text-align:center ">
               <asp:Label ID="lblMSG" BackColor="Yellow" runat="server" Text=""></asp:Label>
           </div>
        </div>
        <hr />
        <asp:Label ID="Label1" runat="server" Text="Hướng dẫn tra cứu"></asp:Label>
        <hr />
    </form>
</body>
</html>
