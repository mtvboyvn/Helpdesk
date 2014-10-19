﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TraCuuToKhai.aspx.cs" Inherits="t.TraCuuToKhai" %>

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
    <form id="form1" defaultfocus="SOTK" runat="server">
       
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
                                    <table id="tblDieuKien" runat="server" style="width: 100%; border: solid 0px black; border-collapse: collapse;">
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label2" runat="server" Text="Số TK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" runat="server">
                                                <asp:TextBox ID="SOTK" runat="server" Width="100px" TabIndex="1" ForeColor="Blue">999999999999</asp:TextBox>
                                            </td>
                                            <td style=" text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;Ngày ĐK:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_FROM" runat="server" Width="80px" TabIndex="2" ForeColor="Blue">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_FROM_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_FROM">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_FROM_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_FROM">
                                                    </cc1:MaskedEditExtender>
                                                        <asp:Label ID="Label6" runat="server" Text="đến:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_TO" runat="server" Width="80px" TabIndex="3" ForeColor="Blue">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_TO_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_TO">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_TO_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_TO">
                                                    </cc1:MaskedEditExtender>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                &nbsp;</td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                &nbsp;</td>
                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label4" runat="server" Text="Mã LH:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_LH" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_LH_TextChanged" TabIndex="4" ForeColor="Blue"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_LH" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_LH_SelectedIndexChanged" TabIndex="5" ForeColor="Blue">
                                                        <asp:ListItem Selected="True"></asp:ListItem>
                                                       <asp:ListItem Value="A11">Nhập kinh doanh tiêu dùng</asp:ListItem>
<asp:ListItem Value="A12">Nhập kinh doanh sản xuất</asp:ListItem>
<asp:ListItem Value="A21">Chuyển tiêu thụ nội địa từ nguồn tạm nhập</asp:ListItem>
<asp:ListItem Value="A31">Nhập hàng xuất khẩu bị trả lại</asp:ListItem>
<asp:ListItem Value="A41">Nhập kinh doanh của DNCX</asp:ListItem>
<asp:ListItem Value="A42">Chuyển tiêu thụ nội địa khác</asp:ListItem>
<asp:ListItem Value="A43">Dự phòng</asp:ListItem>
<asp:ListItem Value="A44">Dự phòng</asp:ListItem>
<asp:ListItem Value="E11">Nhập nguyên liệu của DNCX từ nước ngoài</asp:ListItem>
<asp:ListItem Value="E13">Nhập tạo tài sản cố định của DNCX</asp:ListItem>
<asp:ListItem Value="E15">Nhập nguyên liệu của DNCX từ nội địa</asp:ListItem>
<asp:ListItem Value="E21">Nhập nguyên liệu để gia công </asp:ListItem>
<asp:ListItem Value="E23">Nhập nguyên liệu từ hợp đồng gia công khác chuyển sang</asp:ListItem>
<asp:ListItem Value="E25">Dự phòng</asp:ListItem>
<asp:ListItem Value="E31">Nhập nguyên liệu SXXK</asp:ListItem>
<asp:ListItem Value="E33">Dự phòng</asp:ListItem>
<asp:ListItem Value="E41">Nhập sản phẩm thuê gia công ở nước ngoài</asp:ListItem>
<asp:ListItem Value="G11">Tạm nhập hàng kinh doanh TNTX</asp:ListItem>
<asp:ListItem Value="G12">Tạm nhập máy móc, thiết bị phục vụ thực hiện các dự án có thời hạn …</asp:ListItem>
<asp:ListItem Value="G13">Tạm nhập hàng miễn thuế</asp:ListItem>
<asp:ListItem Value="G14">Tạm nhập khác</asp:ListItem>
<asp:ListItem Value="G51">Tái nhập hàng đã tạm xuất</asp:ListItem>
<asp:ListItem Value="C11">Hàng gửi kho ngoại quan</asp:ListItem>
<asp:ListItem Value="C21">Hàng đưa vào khu phi thuế quan</asp:ListItem>
<asp:ListItem Value="AEO">Doanh nghiệp AEO</asp:ListItem>
<asp:ListItem Value="H11">Loại khác</asp:ListItem>
<asp:ListItem Value="B11">Xuất kinh doanh</asp:ListItem>
<asp:ListItem Value="B12">Xuất sau khi đã tạm xuất</asp:ListItem>
<asp:ListItem Value="B13">Xuất trả hàng nhập khẩu</asp:ListItem>
<asp:ListItem Value="E42">Xuất sản phẩm của DNCX</asp:ListItem>
<asp:ListItem Value="E44">Dự phòng</asp:ListItem>
<asp:ListItem Value="E46">Hàng của DNCX vào nội địa để GC</asp:ListItem>
<asp:ListItem Value="E52">Xuất sản phẩm GC cho thương nhân nước ngoài</asp:ListItem>
<asp:ListItem Value="E54">Xuất nguyên liệu từ HĐGC này sang HĐGC khác</asp:ListItem>
<asp:ListItem Value="E56">Xuất sản phẩm GC vào nội địa</asp:ListItem>
<asp:ListItem Value="E62">Xuất sản phẩm SXXK</asp:ListItem>
<asp:ListItem Value="E64">Xuất kinh doanh của doanh nghiệp đầu tư (DNCX)</asp:ListItem>
<asp:ListItem Value="E82">Xuất nguyên liệu thuê GC ở nước  ngoài</asp:ListItem>
<asp:ListItem Value="G21">Tái xuất hàng kinh doanh TNTX</asp:ListItem>
<asp:ListItem Value="G22">Tái xuất thiết bị, máy móc thuê phục vụ dự án có thời hạn</asp:ListItem>
<asp:ListItem Value="G23">Tái xuất hàng miễn thuế tạm nhập</asp:ListItem>
<asp:ListItem Value="G24">Tái xuất khác</asp:ListItem>
<asp:ListItem Value="G61">Tạm xuất hàng hóa</asp:ListItem>
<asp:ListItem Value="C12">Hàng xuất kho ngoại quan</asp:ListItem>
<asp:ListItem Value="C22">Hàng đưa ra khỏi khu phi thuế quan</asp:ListItem>
<asp:ListItem Value="AEO">Doanh nghiệp ưu tiên AEO</asp:ListItem>
<asp:ListItem Value="H21">Loại hình khác</asp:ListItem>
                                                </asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                <nobr>
                                                <asp:Label ID="Label11" runat="server" Text="&nbsp;&nbsp;Nước XK, NK:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                <asp:TextBox ID="MA_NUOCXK" runat="server" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_NUOCXK_TextChanged" TabIndex="15" Width="30px"></asp:TextBox>
                                                <asp:DropDownList ID="TEN_NUOCXK" runat="server" AutoPostBack="True" ForeColor="Blue" Height="22px" OnSelectedIndexChanged="TEN_NUOCXK_SelectedIndexChanged" TabIndex="16" Width="150px">
                                                    <asp:ListItem></asp:ListItem>
                                                    <asp:ListItem Value="AF">Afganistan</asp:ListItem>
                                                    <asp:ListItem Value="AL">Albania</asp:ListItem>
                                                </asp:DropDownList>
                                                </nobr>
                                            </td>

                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label5" runat="server" Text="Mã Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_CUCHQ" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_CUCHQ_TextChanged" TabIndex="6" ForeColor="Blue"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CUCHQ" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_CUCHQ_SelectedIndexChanged" TabIndex="7" ForeColor="Blue">
                                                        <asp:ListItem></asp:ListItem>
                                                        <asp:ListItem Value="01">Thành phố Hà Nội</asp:ListItem>
<asp:ListItem Value="02">Thành phố Hồ Chí Minh</asp:ListItem>
<asp:ListItem Value="03">Thành phố Hải Phòng</asp:ListItem>
<asp:ListItem Value="10">Tỉnh Hà Giang</asp:ListItem>
<asp:ListItem Value="11">Tỉnh Cao Bằng</asp:ListItem>
<asp:ListItem Value="12">Tỉnh Lai Châu</asp:ListItem>
<asp:ListItem Value="13">Tỉnh Lao Cai</asp:ListItem>
<asp:ListItem Value="14">Tỉnh Tuyên Quang</asp:ListItem>
<asp:ListItem Value="15">Tỉnh Lạng Sơn</asp:ListItem>
<asp:ListItem Value="16">Tỉnh Bắc Thái</asp:ListItem>
<asp:ListItem Value="17">Tỉnh Yên Bái</asp:ListItem>
<asp:ListItem Value="18">Tỉnh Sơn La</asp:ListItem>
<asp:ListItem Value="19">Tỉnh Vĩnh Phú</asp:ListItem>
<asp:ListItem Value="20">Tỉnh Quảng Ninh</asp:ListItem>
<asp:ListItem Value="21">Tỉnh Hà Bắc</asp:ListItem>
<asp:ListItem Value="22">Tỉnh Hà Tây</asp:ListItem>
<asp:ListItem Value="23">Tỉnh Hải Hưng</asp:ListItem>
<asp:ListItem Value="24">Tỉnh Hoà Bình</asp:ListItem>
<asp:ListItem Value="25">Tỉnh Nam Hà</asp:ListItem>
<asp:ListItem Value="26">Tỉnh Thái Bình</asp:ListItem>
<asp:ListItem Value="27">Tỉnh Thanh Hoá</asp:ListItem>
<asp:ListItem Value="28">Tỉnh Ninh Bình</asp:ListItem>
<asp:ListItem Value="29">Tỉnh Nghệ An</asp:ListItem>
<asp:ListItem Value="30">Tỉnh Hà Tĩnh</asp:ListItem>
<asp:ListItem Value="31">Tỉnh Quảng Bình</asp:ListItem>
<asp:ListItem Value="32">Tỉnh Quảng Trị</asp:ListItem>
<asp:ListItem Value="33">Tỉnh Thừa thiên - Huế</asp:ListItem>
<asp:ListItem Value="34">Tỉnh Quảng Nam - Đà Nẵng</asp:ListItem>
<asp:ListItem Value="35">Tỉnh Quảng Ngãi</asp:ListItem>
<asp:ListItem Value="36">Tỉnh Kon Tum</asp:ListItem>
<asp:ListItem Value="37">Tỉnh Bình Định</asp:ListItem>
<asp:ListItem Value="38">Tỉnh Gia Lai</asp:ListItem>
<asp:ListItem Value="39">Tỉnh Phú Yên</asp:ListItem>
<asp:ListItem Value="40">Tỉnh Đắc Lắc</asp:ListItem>
<asp:ListItem Value="41">Tỉnh Khánh Hoà</asp:ListItem>
<asp:ListItem Value="42">Tỉnh Lâm Đồng</asp:ListItem>
<asp:ListItem Value="43">Tỉnh Bình Dương</asp:ListItem>
<asp:ListItem Value="44">Tỉnh Ninh Thuận</asp:ListItem>
<asp:ListItem Value="45">Tỉnh Tây Ninh</asp:ListItem>
<asp:ListItem Value="46">Tỉnh Bình Thuận</asp:ListItem>
<asp:ListItem Value="47">Tỉnh Đồng Nai</asp:ListItem>
<asp:ListItem Value="48">Tỉnh Long An</asp:ListItem>
<asp:ListItem Value="49">Tỉnh Đồng Tháp</asp:ListItem>
<asp:ListItem Value="50">Tỉnh An Giang</asp:ListItem>
<asp:ListItem Value="51">Tỉnh Bà Rịa - Vũng Tàu</asp:ListItem>
<asp:ListItem Value="52">Tỉnh Kiên Giang</asp:ListItem>
<asp:ListItem Value="53">Tỉnh Tiền Giang</asp:ListItem>
<asp:ListItem Value="54">Tỉnh Cần Thơ</asp:ListItem>
<asp:ListItem Value="55">Tỉnh Bến Tre</asp:ListItem>
<asp:ListItem Value="56">Tỉnh Vĩnh Long</asp:ListItem>
<asp:ListItem Value="57">Tỉnh Trà Vinh</asp:ListItem>
<asp:ListItem Value="58">Tỉnh Sóc Trăng</asp:ListItem>
<asp:ListItem Value="59">Tỉnh Minh Hải </asp:ListItem>

                                                </asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                <nobr>
                                                <asp:Label ID="Label12" runat="server" Text="&nbsp;&nbsp;Nước xuất xứ:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                <asp:TextBox ID="MA_NUOCXX" runat="server" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_NUOCXX_TextChanged" TabIndex="17" Width="30px"></asp:TextBox>
                                                <asp:DropDownList ID="TEN_NUOCXX" runat="server" AutoPostBack="True" ForeColor="Blue" Height="22px" OnSelectedIndexChanged="TEN_NUOCXX_SelectedIndexChanged" TabIndex="18" Width="150px">
                                                    <asp:ListItem></asp:ListItem>
                                                    <asp:ListItem Value="AF">Afganistan</asp:ListItem>
                                                    <asp:ListItem Value="AL">Albania</asp:ListItem>
                                                </asp:DropDownList>
                                                </nobr>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label7" runat="server" Text="Mã Chi Cục:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_CC" Width="50px" runat="server" TabIndex="8" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_CC_TextChanged"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CC" Width="410px" runat="server" Height="22px" TabIndex="9" AutoPostBack="True" ForeColor="Blue" OnSelectedIndexChanged="TEN_CC_SelectedIndexChanged">
                                                        <asp:ListItem></asp:ListItem>
                                                        <asp:ListItem Value="01AB">CC HQ CK Sân bay QT Nội Bài</asp:ListItem>
                                                        <asp:ListItem Value="01AC">CC HQ Gia Lâm Hà Nội</asp:ListItem>
                                                </asp:DropDownList>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                &nbsp;</td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                &nbsp;</td>
                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label8" runat="server" Text="Mã Đơn vị:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_DONVI" Width="100px" runat="server" TabIndex="10" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_DONVI_TextChanged"></asp:TextBox>
                                                    <asp:TextBox ID="TEN_DONVI" runat="server" ForeColor="Blue" OnTextChanged="MA_DONVI_TextChanged" ReadOnly="True" TabIndex="11" Width="355px"></asp:TextBox>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                <nobr>
                                                <asp:Label ID="Label9" runat="server" Text="&nbsp;&nbsp;Mã HS:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                <asp:TextBox ID="MA_HS" runat="server" ForeColor="Blue" TabIndex="19" Width="185px"></asp:TextBox>
                                                </nobr>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                <asp:Label ID="Label13" runat="server" Text="Tên đối tác:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td runat="server" colspan="2" style="width: 1px; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                <asp:TextBox ID="TEN_DOITAC" runat="server" ForeColor="Blue" TabIndex="12" Width="465px" AutoPostBack="True" OnTextChanged="TEN_DOITAC_TextChanged"></asp:TextBox>
                                                </nobr>
                                            </td>
                                            <td runat="server" style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                <nobr>
                                                <asp:Label ID="Label10" runat="server" Text="&nbsp;&nbsp;Tên hàng:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td runat="server" style="width: 100%; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                <asp:TextBox ID="TEN_HANG" runat="server" ForeColor="Blue" TabIndex="20" Width="400px"></asp:TextBox>
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
    <asp:Button ID="btnDatLenh" runat="server" Text="Đặt lệnh tra cứu (Alt+S)" OnClick="btnDatLenh_Click" TabIndex="21" AccessKey="s" />
                                    </td>
 <td style="width:1px;">
  <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" TabIndex="22" />
    
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
                                    <asp:BoundField DataField="RP_STATUS" HeaderText="Trạng thái" />
                                    <asp:BoundField DataField="RP_EXPORTDATE" HeaderText="Ngày xuất kết quả tra cứu" />
                                     <asp:TemplateField HeaderText="Tải về KQ tra cứu">
                                        <ItemTemplate>
                                            <div style="padding: 2px; margin-right: 4px;">                                               
                                                <a  style="padding: 2px;" href='<%#Eval("RP_FILEPATH")%>' runat="server"><%#Eval("RP_FILENAME")%></a>
                                            </div>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="RP_DISPLAY" ItemStyle-Width="500px" HeaderText="Điều kiện tra cứu" >
                                    <ItemStyle Width="500px" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="RP_QUERY"  HeaderText="SQL QUERY" Visible="false" />
                                     <asp:TemplateField HeaderText="SQL QUERY">
                                        <ItemTemplate>
                                            <div style="padding: 2px; margin-right: 4px;">                                               
                                                <a  style="padding: 2px;" href='<%#Eval("RP_ID","~/XemSQL.aspx?RP_ID={0}")%>' runat="server">SQL</a>
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
                    <p>&copy; 2014- Trung tâm quản lý và vận hành hệ thống CNTT - Tổng Cục Hải Quan        </div>
            </div>
        </footer>
       
    </form>
</body>
</html>
