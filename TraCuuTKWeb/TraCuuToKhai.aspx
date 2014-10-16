<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraCuuToKhai.aspx.cs" Inherits="t.TraCuuToKhai" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
        <asp:Timer ID="timer1" runat="server" Interval="1000000" OnTick="btnUpdate_Click"></asp:Timer>
        <div style="width: 100%; background-color: #215a9d; text-align: center;">
            <table style="width:100%;border-collapse:collapse;">
                <tr>
                    <td style="width:100%;">
                         <span style="font-family: 'Segoe UI'; font-size: x-large; color: white;"><b>TRA CỨU TỜ KHAI</b></span>
                    </td>
                    <td style="width:1px;margin-right:3px;">
                        <nobr>                            
                            <asp:LinkButton ID="btnLogOut" OnClick="btnLogOut_Click" ForeColor="White" Font-Bold="true" runat="server"><%=Session["USERNAME"] %> </asp:LinkButton>
                        </nobr>
                    </td>
                </tr>
            </table>
        </div>

        <div style="border: dashed 0px #222222;">
            <div id="up_container" style="background-color: #f1f1f1; height: 90%;">
                <asp:UpdatePanel ID="update" runat="server">
                    <ContentTemplate>
                        <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0">
                            <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Điều kiện tra cứu">
                                <HeaderTemplate>
                                    <div style="color: blue;">Điều kiện tra cứu</div>
                                </HeaderTemplate>
                                <ContentTemplate>
                                    <table style="width: 100%; border: solid 0px black; border-collapse: collapse;">
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label2" runat="server" Text="Số TK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;">
                                                <asp:TextBox ID="txtSoTK" runat="server" Width="100px">999999999999</asp:TextBox>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;Ngày ĐK:"></asp:Label>
                                                        <asp:TextBox ID="TextBox2" runat="server" Width="80px">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="TextBox2">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="TextBox2_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="TextBox2">
                                                    </cc1:MaskedEditExtender>
                                                        <asp:Label ID="Label6" runat="server" Text="đến:"></asp:Label>
                                                        <asp:TextBox ID="TextBox3" runat="server" Width="80px">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="TextBox3_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="TextBox3">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="TextBox3_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="TextBox3">
                                                    </cc1:MaskedEditExtender>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label9" runat="server" Text="&nbsp;&nbsp;Mã HS:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox8" runat="server" Width="185px"></asp:TextBox>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label4" runat="server" Text="Mã LH:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="TextBox4" Width="50px" runat="server"></asp:TextBox>
                                                    <asp:DropDownList ID="DropDownList1" Width="410px" runat="server" Height="22px"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label10" runat="server" Text="&nbsp;&nbsp;Tên hàng:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox9" runat="server" Width="400px"></asp:TextBox>
                                                        </nobr>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label5" runat="server" Text="Mã Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="TextBox5" Width="50px" runat="server"></asp:TextBox>
                                                    <asp:DropDownList ID="DropDownList2" Width="410px" runat="server" Height="22px"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label11" runat="server" Text="&nbsp;&nbsp;Nước XK, NK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox10" runat="server" Width="30px"></asp:TextBox>
                                                        <asp:DropDownList ID="DropDownList5" runat="server" Height="22px" Width="150px">
                                                    </asp:DropDownList>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label7" runat="server" Text="Mã Chi Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="TextBox7" Width="50px" runat="server"></asp:TextBox>
                                                    <asp:DropDownList ID="DropDownList4" Width="410px" runat="server" Height="22px"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label12" runat="server" Text="&nbsp;&nbsp;Nước xuất xứ:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox13" runat="server" Width="30px"></asp:TextBox>
                                                        <asp:DropDownList ID="DropDownList6" runat="server" Height="22px" Width="150px">
                                                    </asp:DropDownList>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 1px red;">
                                                <nobr>
                                                    <asp:Label ID="Label8" runat="server" Text="Mã Đơn vị:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 1px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="TextBox6" Width="100px" runat="server"></asp:TextBox>
                                                    <asp:DropDownList ID="DropDownList3" Width="360px" runat="server" Height="22px"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label13" runat="server" Text="&nbsp;&nbsp;Đơn vị đối tác:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 1px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox12" runat="server" Width="185px"></asp:TextBox>
                                                        </nobr>
                                            </td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </cc1:TabPanel>
                            <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Chỉ tiêu thông tin kết xuất">
                            </cc1:TabPanel>
                        </cc1:TabContainer>
                        <div id="background" style="text-align: left; vertical-align: top; padding: 5px; color: black;">
                            <asp:Button ID="btnDatLenh" runat="server" Text="Đặt lệnh tra cứu" OnClick="btnDatLenh_Click" />
                            <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" />
                            <asp:Label ID="lblUpdate" runat="server" Text=""></asp:Label>
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblMSG" runat="server" BackColor="Yellow" Text="Thông báo:"></asp:Label>
                            <hr />
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" EnableModelValidation="True">
                                <Columns>
                                    <asp:BoundField DataField="COMPUTER_NAME" HeaderText="Computer Name" />
                                    <asp:BoundField DataField="APP_TYPE" HeaderText="APP_TYPE" />
                                    <asp:BoundField DataField="SERVICES_NAME" HeaderText="Service Name" />
                                    <asp:BoundField DataField="APP_NAME" HeaderText="App Name" />
                                    <asp:BoundField DataField="SERVICES_TYPE" HeaderText="Service Type" />
                                    <asp:BoundField DataField="NGAY_INSERT" HeaderText="Online Date" />

                                    <asp:TemplateField HeaderText="Online Status">
                                        <ItemTemplate>
                                            <div style="padding: 2px; margin-right: 4px;">
                                                <asp:Label ID="Label1" ForeColor="White" Width="100%" Style="padding: 2px;"
                                                    BackColor='<%# System.Drawing.Color.FromName(Eval("MCOLOR").ToString())%>'
                                                    runat="server" Text='<%#Eval("MCOLOR")%>'></asp:Label>
                                            </div>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="timer1" EventName="Tick" />
                        <asp:AsyncPostBackTrigger ControlID="btnUpdate" EventName="Click" />
                    </Triggers>
                </asp:UpdatePanel>
            </div>
        </div>
        <cc1:UpdatePanelAnimationExtender ID="upae" BehaviorID="animation" runat="server" TargetControlID="update">
            <Animations>
                <OnUpdating>
                    <Sequence>
                        <%-- Store the original height of the panel --%>
                        <ScriptAction Script="var b = $find('animation'); b._originalHeight = b._element.offsetHeight;" />
                        
                        <%-- Disable all the controls --%>
                        <Parallel duration="0">
                            <EnableAction AnimationTarget="btnUpdate" Enabled="false" />                          
                        </Parallel>
                        <StyleAction Attribute="overflow" Value="hidden" />
                        
                        <%-- Do each of the selected effects --%>
                        <Parallel duration=".25" Fps="30">
                            <Condition ConditionScript="true">
                                <FadeOut AnimationTarget="up_container" minimumOpacity=".2" />
                            </Condition>
                            <Condition ConditionScript="false">
                                <Resize Height="0" />
                            </Condition>
                            <Condition ConditionScript="true">
                                <Color AnimationTarget="up_container" PropertyKey="backgroundColor"
                                    EndValue="#FF0000" StartValue="#40669A" />
                            </Condition>
                        </Parallel>
                    </Sequence>
                </OnUpdating>
                <OnUpdated>
                    <Sequence>
                        <%-- Do each of the selected effects --%>
                        <Parallel duration=".25" Fps="30">
                            <Condition ConditionScript="true">
                                <FadeIn AnimationTarget="up_container" minimumOpacity=".2" />
                            </Condition>
                            <Condition ConditionScript="false">
                                <%-- Get the stored height --%>
                                <Resize HeightScript="$find('animation')._originalHeight" />
                            </Condition>
                            <Condition ConditionScript="true">
                                <Color AnimationTarget="up_container" PropertyKey="backgroundColor"
                                    StartValue="#FF0000" EndValue="#f1f1f1" />
                            </Condition>
                        </Parallel>
                        
                        <%-- Enable all the controls --%>
                        <Parallel duration="0">                          
                            <EnableAction AnimationTarget="btnUpdate" Enabled="true" />
                        </Parallel>                            
                    </Sequence>
                </OnUpdated>
            </Animations>
        </cc1:UpdatePanelAnimationExtender>

        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <hr />
                    <p>&copy; 2014- Trung tâm quản lý và vận hành hệ thống CNTT - Tổng Cục Hải Quan</p>
                </div>
            </div>
        </footer>
    </form>
</body>
</html>
