<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.master" CodeBehind="Dashboard.aspx.vb" Inherits="HelpDesk.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        100 câu hỏi mới nhất</h2>
    <hr />

    <div id="divSearch" style="padding-left:50px;" runat="server">
        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <a ><%#Eval("CH_DONVI_MST")%></a>
                <br />
            </ItemTemplate>
        </asp:ListView>
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
