<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeBehind="ThemCauHoi.aspx.vb" Inherits="HelpDesk.ThemCauHoi"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>

            
        <table style="width: 100%">
            <tr>
                <td style="width: 199px">
                    <asp:Label ID="Label1" runat="server" style="font-weight: 700" 
                        Text="Phân loại đối tượng:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="Doituong" runat="server">
                        <asp:ListItem Value="1">Doanh nghiệp</asp:ListItem>
                        <asp:ListItem Value="2">Hải quan</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label2" runat="server" style="font-weight: 700" 
                        Text="Mã số thuế:"></asp:Label>
                </td>
                <td style="width: 152px">
                    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label3" runat="server" style="font-weight: 700" 
                        Text="Mã số thuế:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label4" runat="server" style="font-weight: 700" 
                        Text="Tên người hỏi:"></asp:Label>
                </td>
                <td style="width: 152px">
                    <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label5" runat="server" style="font-weight: 700" 
                        Text="Số điện thoại:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 130px">
                    <asp:Label ID="Label6" runat="server" style="font-weight: 700" Text="Email:"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 0px" 
                        Width="304px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <table style="width: 100%">
            <tr>
                <td style="width: 199px">
                    <asp:Label ID="Label7" runat="server" style="font-weight: 700" 
                        Text="Phân loại câu hỏi:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="Doituong0" runat="server">
                        <asp:ListItem Value="1">VNACCS</asp:ListItem>
                        <asp:ListItem Value="2">VCIS</asp:ListItem>
                        <asp:ListItem Value="3">Nghiệp vụ Hải quan</asp:ListItem>
                        <asp:ListItem Value="4">E-manifest</asp:ListItem>
                        <asp:ListItem Value="5">E-Customs</asp:ListItem>
                        <asp:ListItem Value="6">Kế toán thuế</asp:ListItem>
                        <asp:ListItem Value="7">Đăng ký người sử dụng</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 199px; height: 144px;">
                    <asp:Label ID="Label8" runat="server" style="font-weight: 700" 
                        Text="Nội dung câu hỏi:"></asp:Label>
                </td>
                <td style="height: 144px">
                    <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 0px" 
                        TextMode="MultiLine" Width="100%" Height="177px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 199px; height: 129px;">
                    <asp:Label ID="Label9" runat="server" style="font-weight: 700" 
                        Text="Nội dung câu trả lời:"></asp:Label>
                </td>
                <td style="height: 129px">
                    <asp:TextBox ID="TextBox7" runat="server" style="margin-left: 0px" 
                        TextMode="MultiLine" Width="100%" Height="188px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 199px">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Cập nhật" />
                </td>
            </tr>
        </table>

            
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Default.aspx">Quay 
        lại</asp:LinkButton>
    
    </div>
</asp:Content>



