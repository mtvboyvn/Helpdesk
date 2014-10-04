<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="SearchItem.ascx.vb" Inherits="HelpDesk.SearchItem" %>
 <br /> 
<table style="width:500px;border-bottom:1px dotted gray;">
        <tr>
            <td>
                <nobr>
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Blue" PostBackUrl="~/Dashboard.aspx?q=0100101308">0100101308 - Công ty THHH May 10</asp:LinkButton>
                </nobr>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Dashboard.aspx?q=TuyểnHM">TuyểnHM</asp:HyperLink>&nbsp;
                 <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Dashboard.aspx?q=20/08/2014">(14h30 20/08/2014)</asp:HyperLink>
                <span>&nbsp;hỏi:&nbsp;</span>
                <asp:Literal ID="lblCauHoi" Text="Ông Clinton đề cập đến tình hình trên Biển Đông khi được hỏi về ảnh hưởng ngày càng gia tăng của Trung Quốc trên trường quốc tế. Cựu tổng thống Mỹ nghi ngại về quan điểm của Bắc Kinh đòi thảo luận tay đôi với từng nước để giải quyết tranh chấp" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
                <asp:HyperLink ID="HyperLink2" runat="server">LanNH (17h30 20/08/2014) trả lời:&nbsp;</asp:HyperLink>
                <asp:Literal ID="Literal2" Text="Cái này phải xử lý thế này thế kia và vào. Đông khi được hỏi về ảnh hưởng ngày càng gia tăng của Trung Quốc trên trường quốc tế. Cựu tổng thống Mỹ nghi ngại về quan điểm của Bắc Kinh đòi thảo luận tay đôi với từng nước để giải quyết tranh chấp" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
