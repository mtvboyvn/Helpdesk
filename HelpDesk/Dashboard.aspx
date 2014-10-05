<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.master" CodeBehind="Dashboard.aspx.vb" Inherits="HelpDesk.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="lblMSG" runat="server" Text="100 câu hỏi mới nhất"></asp:Label>
    </h2>
    <hr />
    <asp:Label ID="lblError" Visible="false" ForeColor="Red" runat="server" Text=""></asp:Label>
    <div id="divSearch" style="padding-left: 50px;" runat="server">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <table style="width: 500px; border-bottom: 1px dotted gray;">
                    <tr>
                        <td>
                            <nobr>
                               
                    <asp:LinkButton ID="LinkButton1" runat="server" ForeColor="Blue" PostBackUrl="~/Dashboard.aspx?q=<%#Eval("CH_DONVI_MST")%>"><%#Eval("CH_DONVI_MST")%> - <%#Eval("CH_DONVI_TEN")%></asp:LinkButton>
                </nobr>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Dashboard.aspx?q=<%#Eval("CH_NGUOIHOI_TEN")%>"><%#Eval("CH_NGUOIHOI_TEN")%></asp:HyperLink>&nbsp;
                 <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Dashboard.aspx?q=<%#Eval("CH_CAUHOI_NGAYHOI")%>"><%#Eval("CH_CAUHOI_NGAYHOI")%></asp:HyperLink>
                            <span>&nbsp;hỏi:&nbsp;</span>
                            <asp:Literal ID="lblCauHoi" Text="<%#Eval("CH_CAUHOI_NOIDUNGCAUHOI")%>" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Dashboard.aspx?q=<%#Eval("CH_NGUOITRALOI_TEN")%>"><%#Eval("CH_NGUOITRALOI_TEN")%></asp:HyperLink>&nbsp;
                 <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Dashboard.aspx?q=<%#Eval("CH_CAUHOI_NGAYTRALOI")%>"><%#Eval("CH_CAUHOI_NGAYTRALOI")%></asp:HyperLink>
                            <span>&nbsp;trả lời:&nbsp;</span>
                            <asp:Literal ID="Literal1" Text="<%#Eval("CH_CAUHOI_NOIDUNGTRALOI")%>" runat="server"></asp:Literal>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
