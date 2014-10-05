﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.master" CodeBehind="Dashboard.aspx.vb" Inherits="HelpDesk.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="lblMSG" runat="server" Text="100 câu hỏi mới nhất"></asp:Label>
    </h2>
    <hr />
    <asp:Label ID="lblError" Visible="false" ForeColor="Red" runat="server" Text=""></asp:Label>
    <div id="divSearch" style="padding-left: 50px;" runat="server">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <br />
                <table style="width: 500px; border-bottom: 1px dotted gray;">
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink1" ForeColor="Blue"
                                NavigateUrl='<%#Eval("CH_DONVI_MST","~/Dashboard.aspx?q={0}")%>'
                                runat="server"><%#Eval("CH_DONVI_MST")%></asp:HyperLink>
                            &nbsp;-&nbsp;
                             <asp:HyperLink ID="HyperLink6" ForeColor="Blue"
                                 NavigateUrl='<%#Eval("CH_DONVI_TEN","~/Dashboard.aspx?q={0}")%>'
                                 runat="server"><%#Eval("CH_DONVI_TEN")%></asp:HyperLink>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" 
                                NavigateUrl='<%#Eval("CH_NGUOIHOI_TEN","~/Dashboard.aspx?q={0}")%>'>
                                <%#Eval("CH_NGUOIHOI_TEN")%></asp:HyperLink>&nbsp;
                 <asp:HyperLink ID="HyperLink5" runat="server"
                     NavigateUrl='<%#Eval("CH_CAUHOI_NGAYHOI","~/Dashboard.aspx?q={0}")%>'>
                     <%#Eval("CH_CAUHOI_NGAYHOI")%></asp:HyperLink>
                            <span>&nbsp;hỏi:&nbsp;</span>
                            <asp:Literal ID="lblCauHoi" Text='<%#Eval("CH_CAUHOI_NOIDUNGCAUHOI")%>' runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink7" runat="server"
                                NavigateUrl='<%#Eval("CH_NGUOITRALOI_TEN","~/Dashboard.aspx?q={0}")%>'>
                                <%#Eval("CH_NGUOITRALOI_TEN")%></asp:HyperLink>&nbsp;
                 <asp:HyperLink ID="HyperLink8" runat="server"
                     NavigateUrl='<%#Eval("CH_CAUHOI_NGAYTRALOI","~/Dashboard.aspx?q={0}")%>'>
                     <%#Eval("CH_CAUHOI_NGAYTRALOI")%></asp:HyperLink>
                            <span>&nbsp;trả lời:&nbsp;</span>
                            <asp:Literal ID="Literal2" Text='<%#Eval("CH_CAUHOI_NOIDUNGTRALOI")%>' runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink3" runat="server"
                                NavigateUrl='<%#Eval("CH_ID", "~/Controls/ThemCauHoi.aspx?CH_ID={0}")%>'>
                                Sửa</asp:HyperLink>&nbsp;
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
