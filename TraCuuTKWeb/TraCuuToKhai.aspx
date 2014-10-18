<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraCuuToKhai.aspx.cs" Inherits="t.TraCuuToKhai" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript">
        var postbackElement = null;
        function SetFocusToNextControl(newTabIndex) {
            for (var i = 0; i <= document.form1.elements.length; i++) {
                if (document.form1.elements[i].tabIndex == newTabIndex) {
                    document.form1.elements[i].focus();
                    break;
                }
            }
        }
        function RestoreFocus(source, args) {
            document.getElementById(postbackElement.id).focus();
            if (document.getElementById(postbackElement.id).type == 'text')
                SetFocusToNextControl(document.getElementById(postbackElement.id).tabIndex + 1)
        }
        function SavePostbackElement(source, args) {
            postbackElement = args.get_postBackElement();
        }
        function AddRequestHandler() {
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(RestoreFocus);
            prm.add_beginRequest(SavePostbackElement);
        }
    </script>
</head>
<body onload="AddRequestHandler()">
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
                                            <td style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label2" runat="server" Text="Số TK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;">
                                                <asp:TextBox ID="SOTK" runat="server" Width="100px">999999999999</asp:TextBox>
                                            </td>
                                            <td style=" text-align: left; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;Ngày ĐK:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_FROM" runat="server" Width="80px" TabIndex="1">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_FROM_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_FROM">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_FROM_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_FROM">
                                                    </cc1:MaskedEditExtender>
                                                        <asp:Label ID="Label6" runat="server" Text="đến:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_TO" runat="server" Width="80px" TabIndex="2">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_TO_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_TO">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_TO_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_TO">
                                                    </cc1:MaskedEditExtender>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label9" runat="server" Text="&nbsp;&nbsp;Mã HS:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                   <asp:TextBox ID="MA_HS" runat="server" Width="185px" TabIndex="3"></asp:TextBox>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label4" runat="server" Text="Mã LH:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="MA_LH" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_LH_TextChanged" TabIndex="4"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_LH" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_LH_SelectedIndexChanged" TabIndex="5">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                        <asp:ListItem Value="A11">Nhập kinh doanh tiêu dùng</asp:ListItem>
                                                        <asp:ListItem Value="A12">Nhập kinh doanh sản xuất</asp:ListItem>
                                                </asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label10" runat="server" Text="&nbsp;&nbsp;Tên hàng:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TEN_HANG" runat="server" Width="400px" TabIndex="6"></asp:TextBox>
                                                        </nobr>
                                            </td>

                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label5" runat="server" Text="Mã Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="MA_CUCHQ" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_CUCHQ_TextChanged" TabIndex="7"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CUCHQ" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_CUCHQ_SelectedIndexChanged" TabIndex="8">
                                                        <asp:ListItem>Thành phố Hà Nội</asp:ListItem>
                                                        <asp:ListItem Value="01"></asp:ListItem>
                                                        <asp:ListItem Value="02">Thành phố Hồ Chí Minh</asp:ListItem>
                                                </asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label11" runat="server" Text="&nbsp;&nbsp;Nước XK, NK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                   <asp:TextBox ID="MA_NUOCXNK" runat="server" Width="30px" AutoPostBack="True" OnTextChanged="MA_NUOCXNK_TextChanged" TabIndex="9"></asp:TextBox>
                                                        <asp:DropDownList ID="TEN_NUOCXNK" runat="server" Height="22px" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="TEN_NUOCXNK_SelectedIndexChanged" TabIndex="10">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem Value="AF">Afganistan</asp:ListItem>
                                                            <asp:ListItem Value="AL">Albania</asp:ListItem>
                                                    </asp:DropDownList>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label7" runat="server" Text="Mã Chi Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="MA_CC" Width="50px" runat="server" TabIndex="11"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CC" Width="410px" runat="server" Height="22px" TabIndex="12"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label12" runat="server" Text="&nbsp;&nbsp;Nước xuất xứ:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                   <asp:TextBox ID="MA_NUOCXX" runat="server" Width="30px" AutoPostBack="True" OnTextChanged="MA_NUOCXX_TextChanged" TabIndex="13"></asp:TextBox>
                                                        <asp:DropDownList ID="TEN_NUOCXX" runat="server" Height="22px" Width="150px" AutoPostBack="True" OnSelectedIndexChanged="TEN_NUOCXX_SelectedIndexChanged" TabIndex="14">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem Value="AF">Afganistan</asp:ListItem>
                                                            <asp:ListItem Value="AL">Albania</asp:ListItem>
                                                    </asp:DropDownList>
                                                        </nobr>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                    <asp:Label ID="Label8" runat="server" Text="Mã Đơn vị:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2">
                                                <nobr>
                                                    <asp:TextBox ID="MA_DONVI" Width="100px" runat="server" TabIndex="15"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_DONVI" Width="360px" runat="server" Height="22px" TabIndex="16"></asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                   <asp:Label ID="Label13" runat="server" Text="&nbsp;&nbsp;Đơn vị đối tác:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                   <asp:TextBox ID="TextBox12" runat="server" Width="185px" TabIndex="17"></asp:TextBox>
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
                            <table style="width:100%;">
                                <tr>
                                    <td style="width:1px;">
    <asp:Button ID="btnDatLenh" runat="server" Text="Đặt lệnh tra cứu (Alt+S)" OnClick="btnDatLenh_Click" />
                                    </td>
 <td style="width:1px;">
  <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" />
    
                                     </td>
                                    <td style="width:1px;">
                                          <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="update" DynamicLayout="true">
                        <ProgressTemplate>
                            <nobr>
                            <asp:Label ID="Label1" runat="server" BackColor="Yellow" Font-Bold="true" Font-Size="Large" Text="Đang xử lý dữ liệu, vui lòng đợi..."></asp:Label>
                            </nobr>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                                    </td>
 <td>

   <div id="divMSG">
      

                            <asp:Label ID="lblUpdate" runat="server" Text=""></asp:Label>
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblMSG" runat="server" BackColor="Yellow" Text="Thông báo:"></asp:Label>
                                </div>
                                    </td>
                                </tr>
                               
                                
                            </table>
                        
                          
                         
                            <hr />
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" EnableModelValidation="True">
                                <Columns>
                                    <asp:TemplateField HeaderText="STT">
                                    <ItemTemplate>
                                        <%# Container.DataItemIndex + 1 %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                    <asp:BoundField DataField="RP_ID" HeaderText="RP_ID" />
                                    <asp:BoundField DataField="RP_USERNAME" HeaderText="Tài khoản" />
                                    <asp:BoundField DataField="RP_CREATEDATE" HeaderText="Ngày tra cứu" />
                                    <asp:BoundField DataField="RP_EXPORTDATE" HeaderText="Ngày xuất kết quả tra cứu" />
                                     <asp:TemplateField HeaderText="Tải về KQ tra cứu">
                                        <ItemTemplate>
                                            <div style="padding: 2px; margin-right: 4px;">                                               
                                                <a  style="padding: 2px;" href='<%#Eval("RP_FILEPATH")%>' runat="server"><%#Eval("RP_FILEPATH")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="RP_DISPLAY" ItemStyle-Width="500px" HeaderText="Điều kiện tra cứu" />
                                    <asp:BoundField DataField="RP_QUERY"  HeaderText="SQL QUERY" />
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
                            <EnableAction AnimationTarget="btnDatLenh" Enabled="false" />                                                    
                        </Parallel>
                        <StyleAction Attribute="overflow" Value="hidden" />
                        
                        <%-- Do each of the selected effects --%>
                        <Parallel duration=".25" Fps="30">
                            <Condition ConditionScript="true">
                                <FadeOut AnimationTarget="divMSG" minimumOpacity=".2" />
                            </Condition>
                            <Condition ConditionScript="false">
                                <Resize Height="0" />                               
                            </Condition>
                            <Condition ConditionScript="true">
                                <Color AnimationTarget="divMSG" PropertyKey="backgroundColor"
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
                                <FadeIn AnimationTarget="divMSG" minimumOpacity=".2" />
                            </Condition>
                            <Condition ConditionScript="false">
                                <%-- Get the stored height --%>
                                <Resize HeightScript="$find('animation')._originalHeight" />
                            </Condition>
                            <Condition ConditionScript="true">
                                <Color AnimationTarget="divMSG" PropertyKey="backgroundColor"
                                    StartValue="#FF0000" EndValue="#f1f1f1" />
                            </Condition>
                        </Parallel>
                        
                        <%-- Enable all the controls --%>
                        <Parallel duration="0">                          
                            <EnableAction AnimationTarget="btnUpdate" Enabled="true" />
                            <EnableAction AnimationTarget="btnDatLenh" Enabled="true" />
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
