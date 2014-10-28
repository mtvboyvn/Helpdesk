<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="t.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnChonTat" runat="server" Text="Chọn toàn bộ" />
        <asp:Button ID="btnBoHet" runat="server" Text="Bỏ chọn toàn bộ" />
        <hr />
        <asp:CheckBox ID="SIKNO" Text="SỐ TK" Enabled="true" runat="server" Checked="true" />
    </div>
    </form>
</body>
</html>
