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
    <style type="text/css">
        .auto-style1 {
            width: 1px;
            height: 28px;
        }
        .auto-style2 {
            height: 28px;
        }
        .auto-style3 {
            width: 100%;
            height: 28px;
        }
        .tTextBox {
            border:solid 1px #a9a9a9;
        }
    </style>
</head>
<body onload="AddRequestHandler()">
    <form id="form1" defaultfocus="SOTK" runat="server">
       
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
        <asp:Timer ID="timer1" runat="server" Interval="55000" Enabled="false" OnTick="btnUpdate_Click"></asp:Timer>
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
                                            <td style="text-align: right; border: solid 0px red;" runat="server" class="auto-style1">
                                                <nobr>
                                                    <asp:Label ID="Label2" runat="server" Text="Số TK:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="text-align: left; border: solid 0px red;" runat="server" class="auto-style1">
                                                <asp:TextBox ID="SOTK" runat="server" Width="100px" TabIndex="1" ForeColor="Blue" CssClass="tTextBox">999999999999</asp:TextBox>
                                            </td>
                                            <td style=" text-align: left; border: solid 0px red;" runat="server" class="auto-style2">
                                                <nobr>
                                                    <asp:Label ID="Label3" runat="server" Text="&nbsp;&nbsp;&nbsp;Ngày ĐK:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_FROM" runat="server" Width="80px" TabIndex="2" ForeColor="Blue" CssClass="tTextBox">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_FROM_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_FROM">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_FROM_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" ClearTextOnInvalid="True" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_FROM">
                                                    </cc1:MaskedEditExtender>
                                                        <asp:Label ID="Label6" runat="server" Text="đến:"></asp:Label>
                                                        <asp:TextBox ID="NGAYDK_TO" runat="server" Width="80px" TabIndex="3" ForeColor="Blue" CssClass="tTextBox">31/12/2014</asp:TextBox>
                                                        <cc1:CalendarExtender ID="NGAYDK_TO_CalendarExtender" runat="server" Enabled="True" Format="dd/MM/yyyy" TargetControlID="NGAYDK_TO">
                                                    </cc1:CalendarExtender>
                                                    <cc1:MaskedEditExtender ID="NGAYDK_TO_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="NGAYDK_TO">
                                                    </cc1:MaskedEditExtender>
                                                        </nobr>
                                            </td>

                                            <td style="text-align: right; border-left: solid 1px red;" runat="server" class="auto-style1">
                                                </td>
                                            <td style="text-align: left; border: solid 0px red;" runat="server" class="auto-style3">
                                                <asp:Label ID="Label14" runat="server" Text="Thông tin hàng:"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label4" runat="server" Text="Mã LH:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_LH" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_LH_TextChanged" TabIndex="4" ForeColor="Blue" CssClass="tTextBox"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_LH" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_LH_SelectedIndexChanged" TabIndex="5" ForeColor="Blue" CssClass="tTextBox">
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
                                                <asp:Label ID="Label9" runat="server" Text="&nbsp;&nbsp;Mã HS:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                <asp:TextBox ID="MA_HS" runat="server" ForeColor="Blue" TabIndex="15" Width="185px" CssClass="tTextBox"></asp:TextBox>
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
                                                    <asp:TextBox ID="MA_CUCHQ" Width="50px" runat="server" AutoPostBack="True" OnTextChanged="MA_CUCHQ_TextChanged" TabIndex="6" ForeColor="Blue" CssClass="tTextBox"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CUCHQ" Width="410px" runat="server" Height="22px" AutoPostBack="True" OnSelectedIndexChanged="TEN_CUCHQ_SelectedIndexChanged" TabIndex="7" ForeColor="Blue" CssClass="tTextBox">
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
                                                <asp:Label ID="Label10" runat="server" Text="&nbsp;&nbsp;Tên hàng:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                <nobr>
                                                <asp:TextBox ID="TEN_HANG" runat="server" ForeColor="Blue" TabIndex="16" Width="400px" CssClass="tTextBox"></asp:TextBox>
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
                                                    <asp:TextBox ID="MA_CC" Width="50px" runat="server" TabIndex="8" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_CC_TextChanged" CssClass="tTextBox"></asp:TextBox>
                                                    <asp:DropDownList ID="TEN_CC" Width="410px" runat="server" Height="22px" TabIndex="9" AutoPostBack="True" ForeColor="Blue" OnSelectedIndexChanged="TEN_CC_SelectedIndexChanged" CssClass="tTextBox">
                                                        <asp:ListItem></asp:ListItem>
                                                        <asp:ListItem Value="01AB">CC HQ CK Sân bay QT Nội Bài</asp:ListItem>
                                                        <asp:ListItem Value="01AC">CC HQ Gia Lâm Hà Nội</asp:ListItem>
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
                                                <asp:TextBox ID="MA_NUOCXX" runat="server" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_NUOCXX_TextChanged" TabIndex="17" Width="30px" CssClass="tTextBox"></asp:TextBox>
                                                <asp:DropDownList ID="TEN_NUOCXX" runat="server" AutoPostBack="True" ForeColor="Blue" Height="22px" OnSelectedIndexChanged="TEN_NUOCXX_SelectedIndexChanged" TabIndex="18" Width="150px" CssClass="tTextBox">
                                                    <asp:ListItem></asp:ListItem>
                                                   <asp:ListItem Value="AF">Afganistan</asp:ListItem>
<asp:ListItem Value="AL">Albania</asp:ListItem>
<asp:ListItem Value="DZ">Algeria</asp:ListItem>
<asp:ListItem Value="AS">American Samoa</asp:ListItem>
<asp:ListItem Value="AD">Andorra</asp:ListItem>
<asp:ListItem Value="AO">Angola</asp:ListItem>
<asp:ListItem Value="AI">Anguilla</asp:ListItem>
<asp:ListItem Value="AG">Antigua and Barbuda</asp:ListItem>
<asp:ListItem Value="AR">Argentina</asp:ListItem>
<asp:ListItem Value="AM">Armenia</asp:ListItem>
<asp:ListItem Value="NC">New Caledonia</asp:ListItem>
<asp:ListItem Value="NZ">New Zealand</asp:ListItem>
<asp:ListItem Value="NI">Nicaragua</asp:ListItem>
<asp:ListItem Value="NE">Niger</asp:ListItem>
<asp:ListItem Value="NG">Nigeria</asp:ListItem>
<asp:ListItem Value="NU">Niue</asp:ListItem>
<asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
<asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
<asp:ListItem Value="NO">Norway</asp:ListItem>
<asp:ListItem Value="OM">Oman</asp:ListItem>
<asp:ListItem Value="PK">Pakistan</asp:ListItem>
<asp:ListItem Value="PW">Palau</asp:ListItem>
<asp:ListItem Value="PS">Palestine</asp:ListItem>
<asp:ListItem Value="PA">Panama</asp:ListItem>
<asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
<asp:ListItem Value="PY">Paraguay</asp:ListItem>
<asp:ListItem Value="PE">Peru</asp:ListItem>
<asp:ListItem Value="PH">Philippines</asp:ListItem>
<asp:ListItem Value="PN">Pitcairn</asp:ListItem>
<asp:ListItem Value="PL">Poland</asp:ListItem>
<asp:ListItem Value="PT">Portugal</asp:ListItem>
<asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
<asp:ListItem Value="QA">Qatar</asp:ListItem>
<asp:ListItem Value="RE">Reunion</asp:ListItem>
<asp:ListItem Value="RO">Romania</asp:ListItem>
<asp:ListItem Value="RU">Russian Federation</asp:ListItem>
<asp:ListItem Value="RW">Rwanda</asp:ListItem>
<asp:ListItem Value="SH">Saint Helena</asp:ListItem>
<asp:ListItem Value="KN">Saint Kitts & Nevis</asp:ListItem>
<asp:ListItem Value="LC">Saint Lucia</asp:ListItem>
<asp:ListItem Value="PM">Saint Pierre & Miquelon</asp:ListItem>
<asp:ListItem Value="VC">Saint Vincent & Grenadines</asp:ListItem>
<asp:ListItem Value="WS">Samoa</asp:ListItem>
<asp:ListItem Value="SM">San Marino</asp:ListItem>
<asp:ListItem Value="ST">Sao Tome & Principe</asp:ListItem>
<asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
<asp:ListItem Value="SN">Senegal</asp:ListItem>
<asp:ListItem Value="RS">Serbia</asp:ListItem>
<asp:ListItem Value="SC">Seychelles</asp:ListItem>
<asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
<asp:ListItem Value="SG">Singapore</asp:ListItem>
<asp:ListItem Value="SK">Slovakia (Slovak Rep.)</asp:ListItem>
<asp:ListItem Value="SI">Slovenia</asp:ListItem>
<asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
<asp:ListItem Value="SO">Somalia</asp:ListItem>
<asp:ListItem Value="ZA">South Africa</asp:ListItem>
<asp:ListItem Value="GS">South Georgia & the South Sandwich Islan</asp:ListItem>
<asp:ListItem Value="ES">Spain</asp:ListItem>
<asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
<asp:ListItem Value="SS">Sudan</asp:ListItem>
<asp:ListItem Value="SD">Sudan</asp:ListItem>
<asp:ListItem Value="SR">Suriname</asp:ListItem>
<asp:ListItem Value="SJ">Svalbard & Jan Mayen Islands</asp:ListItem>
<asp:ListItem Value="SZ">Swaziland</asp:ListItem>
<asp:ListItem Value="SE">Sweden</asp:ListItem>
<asp:ListItem Value="CH">Switzerland</asp:ListItem>
<asp:ListItem Value="SY">Syrian Arab (Rep.)</asp:ListItem>
<asp:ListItem Value="TW">Taiwan</asp:ListItem>
<asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
<asp:ListItem Value="TZ">Tanzania (United Rep.)</asp:ListItem>
<asp:ListItem Value="TH">Thailand</asp:ListItem>
<asp:ListItem Value="TG">Togo</asp:ListItem>
<asp:ListItem Value="TK">Tokelau</asp:ListItem>
<asp:ListItem Value="TO">Tonga</asp:ListItem>
<asp:ListItem Value="TT">Trinidad & Tobago</asp:ListItem>
<asp:ListItem Value="TN">Tunisia</asp:ListItem>
<asp:ListItem Value="TR">Turkey</asp:ListItem>
<asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
<asp:ListItem Value="TC">Turks & Caicos Islands</asp:ListItem>
<asp:ListItem Value="TV">Tuvalu</asp:ListItem>
<asp:ListItem Value="UG">Uganda</asp:ListItem>
<asp:ListItem Value="UA">Ukraine</asp:ListItem>
<asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
<asp:ListItem Value="GB">United Kingdom</asp:ListItem>
<asp:ListItem Value="UM">United States Minor Outlying Islands</asp:ListItem>
<asp:ListItem Value="US">United States of America</asp:ListItem>
<asp:ListItem Value="UY">UruGuay</asp:ListItem>
<asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
<asp:ListItem Value="VU">Vanuatu</asp:ListItem>
<asp:ListItem Value="VA">Vatican City</asp:ListItem>
<asp:ListItem Value="VE">Venezuela</asp:ListItem>
<asp:ListItem Value="VN">Viet Nam</asp:ListItem>
<asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>
<asp:ListItem Value="WF">Wallis & Futuna Islands</asp:ListItem>
<asp:ListItem Value="EH">Western Sahara</asp:ListItem>
<asp:ListItem Value="YE">Yemen</asp:ListItem>
<asp:ListItem Value="ZM">Zambia</asp:ListItem>
<asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
<asp:ListItem Value="BQ">z</asp:ListItem>
<asp:ListItem Value="ZZ">Chưa xác định</asp:ListItem>
<asp:ListItem Value="AW">Aruba</asp:ListItem>
<asp:ListItem Value="AU">Australia</asp:ListItem>
<asp:ListItem Value="AT">Austria</asp:ListItem>
<asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
<asp:ListItem Value="BS">Bahamas</asp:ListItem>
<asp:ListItem Value="BH">Bahrain</asp:ListItem>
<asp:ListItem Value="BD">Bangladesh</asp:ListItem>
<asp:ListItem Value="BB">Barbados</asp:ListItem>
<asp:ListItem Value="BY">Belarus</asp:ListItem>
<asp:ListItem Value="BE">Belgium</asp:ListItem>
<asp:ListItem Value="BZ">Belize</asp:ListItem>
<asp:ListItem Value="BJ">Benin</asp:ListItem>
<asp:ListItem Value="BM">Bermuda</asp:ListItem>
<asp:ListItem Value="BT">Bhutan</asp:ListItem>
<asp:ListItem Value="BO">Bolivia</asp:ListItem>
<asp:ListItem Value="BA">Bosnia and Herzegowina</asp:ListItem>
<asp:ListItem Value="BW">Botswana</asp:ListItem>
<asp:ListItem Value="BR">Brazil</asp:ListItem>
<asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
<asp:ListItem Value="VG">British Virgin Islands</asp:ListItem>
<asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>
<asp:ListItem Value="BG">Bulgaria</asp:ListItem>
<asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
<asp:ListItem Value="BI">Burundi</asp:ListItem>
<asp:ListItem Value="KH">Cambodia</asp:ListItem>
<asp:ListItem Value="CM">Cameroon</asp:ListItem>
<asp:ListItem Value="CA">Canada</asp:ListItem>
<asp:ListItem Value="CV">Cape Verde Islands</asp:ListItem>
<asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
<asp:ListItem Value="CF">Central African Republic</asp:ListItem>
<asp:ListItem Value="TD">Chad</asp:ListItem>
<asp:ListItem Value="CL">Chile</asp:ListItem>
<asp:ListItem Value="CN">China</asp:ListItem>
<asp:ListItem Value="CX">Christmas Islands</asp:ListItem>
<asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
<asp:ListItem Value="CO">Colombia</asp:ListItem>
<asp:ListItem Value="KM">Comoros</asp:ListItem>
<asp:ListItem Value="CG">Congo</asp:ListItem>
<asp:ListItem Value="CD">Congo (Democratic Rep.)</asp:ListItem>
<asp:ListItem Value="CK">Cook Islands</asp:ListItem>
<asp:ListItem Value="CR">Costa Rica</asp:ListItem>
<asp:ListItem Value="CI">Cote DIvoire (Ivory Coast)</asp:ListItem>
<asp:ListItem Value="HR">Croatia (Hrvatska)</asp:ListItem>
<asp:ListItem Value="CU">Cuba</asp:ListItem>
<asp:ListItem Value="CY">Cyprus</asp:ListItem>
<asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
<asp:ListItem Value="DK">Denmark</asp:ListItem>
<asp:ListItem Value="DJ">Djibouti</asp:ListItem>
<asp:ListItem Value="DM">Dominica</asp:ListItem>
<asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
<asp:ListItem Value="TL">East Timor</asp:ListItem>
<asp:ListItem Value="EC">Ecuador</asp:ListItem>
<asp:ListItem Value="EG">Egypt</asp:ListItem>
<asp:ListItem Value="SV">El Salvador</asp:ListItem>
<asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
<asp:ListItem Value="ER">Eritrea</asp:ListItem>
<asp:ListItem Value="EE">Estonia</asp:ListItem>
<asp:ListItem Value="ET">Ethiopia</asp:ListItem>
<asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>
<asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
<asp:ListItem Value="FJ">Fiji</asp:ListItem>
<asp:ListItem Value="FI">Finland</asp:ListItem>
<asp:ListItem Value="FR">France</asp:ListItem>
<asp:ListItem Value="GF">French Guiana</asp:ListItem>
<asp:ListItem Value="PF">French Polinesia</asp:ListItem>
<asp:ListItem Value="GA">Gabon</asp:ListItem>
<asp:ListItem Value="GM">Gambia</asp:ListItem>
<asp:ListItem Value="GE">Georgia</asp:ListItem>
<asp:ListItem Value="DE">Germany</asp:ListItem>
<asp:ListItem Value="GH">Ghana</asp:ListItem>
<asp:ListItem Value="GI">Gibraltar</asp:ListItem>
<asp:ListItem Value="GR">Greece</asp:ListItem>
<asp:ListItem Value="GL">Greenland</asp:ListItem>
<asp:ListItem Value="GD">Grenada</asp:ListItem>
<asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
<asp:ListItem Value="GU">Guam</asp:ListItem>
<asp:ListItem Value="GT">Guatemala</asp:ListItem>
<asp:ListItem Value="GN">Guinea</asp:ListItem>
<asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
<asp:ListItem Value="GY">Guyana</asp:ListItem>
<asp:ListItem Value="HT">Haiti</asp:ListItem>
<asp:ListItem Value="HN">Honduras</asp:ListItem>
<asp:ListItem Value="HK">HongKong</asp:ListItem>
<asp:ListItem Value="HU">Hungary</asp:ListItem>
<asp:ListItem Value="IS">Iceland</asp:ListItem>
<asp:ListItem Value="IN">India</asp:ListItem>
<asp:ListItem Value="ID">Indonesia</asp:ListItem>
<asp:ListItem Value="IR">Iran (Islamic Rep.)</asp:ListItem>
<asp:ListItem Value="IQ">Iraq</asp:ListItem>
<asp:ListItem Value="IE">Ireland</asp:ListItem>
<asp:ListItem Value="IL">Israel</asp:ListItem>
<asp:ListItem Value="IT">Italy</asp:ListItem>
<asp:ListItem Value="JM">Jamaica</asp:ListItem>
<asp:ListItem Value="JP">Japan</asp:ListItem>
<asp:ListItem Value="JO">Jordan</asp:ListItem>
<asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
<asp:ListItem Value="KE">Kenya</asp:ListItem>
<asp:ListItem Value="KI">Kiribati</asp:ListItem>
<asp:ListItem Value="KP">Korea (Democratic Peoples Rep.)</asp:ListItem>
<asp:ListItem Value="KR">Korea (Republic)</asp:ListItem>
<asp:ListItem Value="KW">Kuwait</asp:ListItem>
<asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
<asp:ListItem Value="LA">Laos</asp:ListItem>
<asp:ListItem Value="LV">Latvia</asp:ListItem>
<asp:ListItem Value="LB">Lebanon</asp:ListItem>
<asp:ListItem Value="LS">Lesotho</asp:ListItem>
<asp:ListItem Value="LR">Liberia</asp:ListItem>
<asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>
<asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
<asp:ListItem Value="LT">Lithuania</asp:ListItem>
<asp:ListItem Value="LU">Luxembourg</asp:ListItem>
<asp:ListItem Value="MO">Macau</asp:ListItem>
<asp:ListItem Value="MK">Macedonia</asp:ListItem>
<asp:ListItem Value="MG">Madagascar</asp:ListItem>
<asp:ListItem Value="MW">Malawi</asp:ListItem>
<asp:ListItem Value="MY">Malaysia</asp:ListItem>
<asp:ListItem Value="MV">Maldives</asp:ListItem>
<asp:ListItem Value="ML">Mali</asp:ListItem>
<asp:ListItem Value="MT">Malta</asp:ListItem>
<asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
<asp:ListItem Value="MQ">Martinique</asp:ListItem>
<asp:ListItem Value="MR">Mauritania</asp:ListItem>
<asp:ListItem Value="MU">Mauritius</asp:ListItem>
<asp:ListItem Value="YT">Mayotte</asp:ListItem>
<asp:ListItem Value="MX">Mexico</asp:ListItem>
<asp:ListItem Value="FM">Micronesia (Federated State)</asp:ListItem>
<asp:ListItem Value="MD">Moldova (Rep.)</asp:ListItem>
<asp:ListItem Value="MC">Monaco</asp:ListItem>
<asp:ListItem Value="MN">Mongolia</asp:ListItem>
<asp:ListItem Value="ME">Montenegro</asp:ListItem>
<asp:ListItem Value="MS">Montserrat</asp:ListItem>
<asp:ListItem Value="MA">Morocco</asp:ListItem>
<asp:ListItem Value="MZ">Mozambique</asp:ListItem>
<asp:ListItem Value="MM">Myanmar (Burma)</asp:ListItem>
<asp:ListItem Value="NA">Namibia</asp:ListItem>
<asp:ListItem Value="NR">Nauru</asp:ListItem>
<asp:ListItem Value="NP">Nepal</asp:ListItem>
<asp:ListItem Value="NL">Netherlands</asp:ListItem>
                                                </asp:DropDownList>
                                                </nobr>
                                            </td>
                                        </tr>
                                        <tr runat="server">
                                            <td style="text-align: right; width: 1px; border: solid 0px red;" runat="server">
                                                <nobr>
                                                    <asp:Label ID="Label8" runat="server" Text="Mã Đơn vị:"></asp:Label>
                                                        </nobr>
                                            </td>
                                            <td style="width: 1px; text-align: left; border: solid 0px red;" colspan="2" runat="server">
                                                <nobr>
                                                    <asp:TextBox ID="MA_DONVI" Width="100px" runat="server" TabIndex="10" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_DONVI_TextChanged" CssClass="tTextBox"></asp:TextBox>
                                                    <asp:TextBox ID="TEN_DONVI" runat="server" ForeColor="Blue" OnTextChanged="MA_DONVI_TextChanged" ReadOnly="True" TabIndex="11" Width="355px" CssClass="tTextBox"></asp:TextBox>
                                                        </nobr>
                                            </td>

                                            <td style="width: 1px; text-align: right; border-left: solid 1px red;" runat="server">
                                                &nbsp;</td>
                                            <td style="width: 100%; text-align: left; border: solid 0px red;" runat="server">
                                                &nbsp;</td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                <asp:Label ID="Label13" runat="server" Text="Tên đối tác:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td runat="server" colspan="2" style="width: 1px; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                <asp:TextBox ID="TEN_DOITAC" runat="server" ForeColor="Blue" TabIndex="12" Width="465px" AutoPostBack="True" OnTextChanged="TEN_DOITAC_TextChanged" CssClass="tTextBox"></asp:TextBox>
                                                </nobr>
                                            </td>
                                            <td runat="server" style="width: 1px; text-align: right; border-left: solid 1px red;">
                                                &nbsp;</td>
                                            <td runat="server" style="width: 100%; text-align: left; border: solid 0px red;">
                                                &nbsp;</td>
                                        </tr>
                                        <tr runat="server">
                                            <td runat="server" style="text-align: right; width: 1px; border: solid 0px red;">
                                                <nobr>
                                                <asp:Label ID="Label11" runat="server" Text="&nbsp;&nbsp;Nước XK, NK:"></asp:Label>
                                                </nobr>
                                            </td>
                                            <td runat="server" colspan="2" style="width: 1px; text-align: left; border: solid 0px red;">
                                                <nobr>
                                                <asp:TextBox ID="MA_NUOCXK" runat="server" AutoPostBack="True" ForeColor="Blue" OnTextChanged="MA_NUOCXK_TextChanged" TabIndex="13" Width="30px" CssClass="tTextBox"></asp:TextBox>
                                                <asp:DropDownList ID="TEN_NUOCXK" runat="server" AutoPostBack="True" ForeColor="Blue" Height="22px" OnSelectedIndexChanged="TEN_NUOCXK_SelectedIndexChanged" TabIndex="14" Width="150px" CssClass="tTextBox">
                                                    <asp:ListItem></asp:ListItem>
                                                    <asp:ListItem Value="AF">Afganistan</asp:ListItem>
<asp:ListItem Value="AL">Albania</asp:ListItem>
<asp:ListItem Value="DZ">Algeria</asp:ListItem>
<asp:ListItem Value="AS">American Samoa</asp:ListItem>
<asp:ListItem Value="AD">Andorra</asp:ListItem>
<asp:ListItem Value="AO">Angola</asp:ListItem>
<asp:ListItem Value="AI">Anguilla</asp:ListItem>
<asp:ListItem Value="AG">Antigua and Barbuda</asp:ListItem>
<asp:ListItem Value="AR">Argentina</asp:ListItem>
<asp:ListItem Value="AM">Armenia</asp:ListItem>
<asp:ListItem Value="NC">New Caledonia</asp:ListItem>
<asp:ListItem Value="NZ">New Zealand</asp:ListItem>
<asp:ListItem Value="NI">Nicaragua</asp:ListItem>
<asp:ListItem Value="NE">Niger</asp:ListItem>
<asp:ListItem Value="NG">Nigeria</asp:ListItem>
<asp:ListItem Value="NU">Niue</asp:ListItem>
<asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
<asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
<asp:ListItem Value="NO">Norway</asp:ListItem>
<asp:ListItem Value="OM">Oman</asp:ListItem>
<asp:ListItem Value="PK">Pakistan</asp:ListItem>
<asp:ListItem Value="PW">Palau</asp:ListItem>
<asp:ListItem Value="PS">Palestine</asp:ListItem>
<asp:ListItem Value="PA">Panama</asp:ListItem>
<asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
<asp:ListItem Value="PY">Paraguay</asp:ListItem>
<asp:ListItem Value="PE">Peru</asp:ListItem>
<asp:ListItem Value="PH">Philippines</asp:ListItem>
<asp:ListItem Value="PN">Pitcairn</asp:ListItem>
<asp:ListItem Value="PL">Poland</asp:ListItem>
<asp:ListItem Value="PT">Portugal</asp:ListItem>
<asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
<asp:ListItem Value="QA">Qatar</asp:ListItem>
<asp:ListItem Value="RE">Reunion</asp:ListItem>
<asp:ListItem Value="RO">Romania</asp:ListItem>
<asp:ListItem Value="RU">Russian Federation</asp:ListItem>
<asp:ListItem Value="RW">Rwanda</asp:ListItem>
<asp:ListItem Value="SH">Saint Helena</asp:ListItem>
<asp:ListItem Value="KN">Saint Kitts & Nevis</asp:ListItem>
<asp:ListItem Value="LC">Saint Lucia</asp:ListItem>
<asp:ListItem Value="PM">Saint Pierre & Miquelon</asp:ListItem>
<asp:ListItem Value="VC">Saint Vincent & Grenadines</asp:ListItem>
<asp:ListItem Value="WS">Samoa</asp:ListItem>
<asp:ListItem Value="SM">San Marino</asp:ListItem>
<asp:ListItem Value="ST">Sao Tome & Principe</asp:ListItem>
<asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
<asp:ListItem Value="SN">Senegal</asp:ListItem>
<asp:ListItem Value="RS">Serbia</asp:ListItem>
<asp:ListItem Value="SC">Seychelles</asp:ListItem>
<asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
<asp:ListItem Value="SG">Singapore</asp:ListItem>
<asp:ListItem Value="SK">Slovakia (Slovak Rep.)</asp:ListItem>
<asp:ListItem Value="SI">Slovenia</asp:ListItem>
<asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
<asp:ListItem Value="SO">Somalia</asp:ListItem>
<asp:ListItem Value="ZA">South Africa</asp:ListItem>
<asp:ListItem Value="GS">South Georgia & the South Sandwich Islan</asp:ListItem>
<asp:ListItem Value="ES">Spain</asp:ListItem>
<asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
<asp:ListItem Value="SS">Sudan</asp:ListItem>
<asp:ListItem Value="SD">Sudan</asp:ListItem>
<asp:ListItem Value="SR">Suriname</asp:ListItem>
<asp:ListItem Value="SJ">Svalbard & Jan Mayen Islands</asp:ListItem>
<asp:ListItem Value="SZ">Swaziland</asp:ListItem>
<asp:ListItem Value="SE">Sweden</asp:ListItem>
<asp:ListItem Value="CH">Switzerland</asp:ListItem>
<asp:ListItem Value="SY">Syrian Arab (Rep.)</asp:ListItem>
<asp:ListItem Value="TW">Taiwan</asp:ListItem>
<asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
<asp:ListItem Value="TZ">Tanzania (United Rep.)</asp:ListItem>
<asp:ListItem Value="TH">Thailand</asp:ListItem>
<asp:ListItem Value="TG">Togo</asp:ListItem>
<asp:ListItem Value="TK">Tokelau</asp:ListItem>
<asp:ListItem Value="TO">Tonga</asp:ListItem>
<asp:ListItem Value="TT">Trinidad & Tobago</asp:ListItem>
<asp:ListItem Value="TN">Tunisia</asp:ListItem>
<asp:ListItem Value="TR">Turkey</asp:ListItem>
<asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
<asp:ListItem Value="TC">Turks & Caicos Islands</asp:ListItem>
<asp:ListItem Value="TV">Tuvalu</asp:ListItem>
<asp:ListItem Value="UG">Uganda</asp:ListItem>
<asp:ListItem Value="UA">Ukraine</asp:ListItem>
<asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
<asp:ListItem Value="GB">United Kingdom</asp:ListItem>
<asp:ListItem Value="UM">United States Minor Outlying Islands</asp:ListItem>
<asp:ListItem Value="US">United States of America</asp:ListItem>
<asp:ListItem Value="UY">UruGuay</asp:ListItem>
<asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
<asp:ListItem Value="VU">Vanuatu</asp:ListItem>
<asp:ListItem Value="VA">Vatican City</asp:ListItem>
<asp:ListItem Value="VE">Venezuela</asp:ListItem>
<asp:ListItem Value="VN">Viet Nam</asp:ListItem>
<asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>
<asp:ListItem Value="WF">Wallis & Futuna Islands</asp:ListItem>
<asp:ListItem Value="EH">Western Sahara</asp:ListItem>
<asp:ListItem Value="YE">Yemen</asp:ListItem>
<asp:ListItem Value="ZM">Zambia</asp:ListItem>
<asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
<asp:ListItem Value="BQ">z</asp:ListItem>
<asp:ListItem Value="ZZ">Chưa xác định</asp:ListItem>
<asp:ListItem Value="AW">Aruba</asp:ListItem>
<asp:ListItem Value="AU">Australia</asp:ListItem>
<asp:ListItem Value="AT">Austria</asp:ListItem>
<asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
<asp:ListItem Value="BS">Bahamas</asp:ListItem>
<asp:ListItem Value="BH">Bahrain</asp:ListItem>
<asp:ListItem Value="BD">Bangladesh</asp:ListItem>
<asp:ListItem Value="BB">Barbados</asp:ListItem>
<asp:ListItem Value="BY">Belarus</asp:ListItem>
<asp:ListItem Value="BE">Belgium</asp:ListItem>
<asp:ListItem Value="BZ">Belize</asp:ListItem>
<asp:ListItem Value="BJ">Benin</asp:ListItem>
<asp:ListItem Value="BM">Bermuda</asp:ListItem>
<asp:ListItem Value="BT">Bhutan</asp:ListItem>
<asp:ListItem Value="BO">Bolivia</asp:ListItem>
<asp:ListItem Value="BA">Bosnia and Herzegowina</asp:ListItem>
<asp:ListItem Value="BW">Botswana</asp:ListItem>
<asp:ListItem Value="BR">Brazil</asp:ListItem>
<asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
<asp:ListItem Value="VG">British Virgin Islands</asp:ListItem>
<asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>
<asp:ListItem Value="BG">Bulgaria</asp:ListItem>
<asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
<asp:ListItem Value="BI">Burundi</asp:ListItem>
<asp:ListItem Value="KH">Cambodia</asp:ListItem>
<asp:ListItem Value="CM">Cameroon</asp:ListItem>
<asp:ListItem Value="CA">Canada</asp:ListItem>
<asp:ListItem Value="CV">Cape Verde Islands</asp:ListItem>
<asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
<asp:ListItem Value="CF">Central African Republic</asp:ListItem>
<asp:ListItem Value="TD">Chad</asp:ListItem>
<asp:ListItem Value="CL">Chile</asp:ListItem>
<asp:ListItem Value="CN">China</asp:ListItem>
<asp:ListItem Value="CX">Christmas Islands</asp:ListItem>
<asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
<asp:ListItem Value="CO">Colombia</asp:ListItem>
<asp:ListItem Value="KM">Comoros</asp:ListItem>
<asp:ListItem Value="CG">Congo</asp:ListItem>
<asp:ListItem Value="CD">Congo (Democratic Rep.)</asp:ListItem>
<asp:ListItem Value="CK">Cook Islands</asp:ListItem>
<asp:ListItem Value="CR">Costa Rica</asp:ListItem>
<asp:ListItem Value="CI">Cote DIvoire (Ivory Coast)</asp:ListItem>
<asp:ListItem Value="HR">Croatia (Hrvatska)</asp:ListItem>
<asp:ListItem Value="CU">Cuba</asp:ListItem>
<asp:ListItem Value="CY">Cyprus</asp:ListItem>
<asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
<asp:ListItem Value="DK">Denmark</asp:ListItem>
<asp:ListItem Value="DJ">Djibouti</asp:ListItem>
<asp:ListItem Value="DM">Dominica</asp:ListItem>
<asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
<asp:ListItem Value="TL">East Timor</asp:ListItem>
<asp:ListItem Value="EC">Ecuador</asp:ListItem>
<asp:ListItem Value="EG">Egypt</asp:ListItem>
<asp:ListItem Value="SV">El Salvador</asp:ListItem>
<asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
<asp:ListItem Value="ER">Eritrea</asp:ListItem>
<asp:ListItem Value="EE">Estonia</asp:ListItem>
<asp:ListItem Value="ET">Ethiopia</asp:ListItem>
<asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>
<asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
<asp:ListItem Value="FJ">Fiji</asp:ListItem>
<asp:ListItem Value="FI">Finland</asp:ListItem>
<asp:ListItem Value="FR">France</asp:ListItem>
<asp:ListItem Value="GF">French Guiana</asp:ListItem>
<asp:ListItem Value="PF">French Polinesia</asp:ListItem>
<asp:ListItem Value="GA">Gabon</asp:ListItem>
<asp:ListItem Value="GM">Gambia</asp:ListItem>
<asp:ListItem Value="GE">Georgia</asp:ListItem>
<asp:ListItem Value="DE">Germany</asp:ListItem>
<asp:ListItem Value="GH">Ghana</asp:ListItem>
<asp:ListItem Value="GI">Gibraltar</asp:ListItem>
<asp:ListItem Value="GR">Greece</asp:ListItem>
<asp:ListItem Value="GL">Greenland</asp:ListItem>
<asp:ListItem Value="GD">Grenada</asp:ListItem>
<asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
<asp:ListItem Value="GU">Guam</asp:ListItem>
<asp:ListItem Value="GT">Guatemala</asp:ListItem>
<asp:ListItem Value="GN">Guinea</asp:ListItem>
<asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
<asp:ListItem Value="GY">Guyana</asp:ListItem>
<asp:ListItem Value="HT">Haiti</asp:ListItem>
<asp:ListItem Value="HN">Honduras</asp:ListItem>
<asp:ListItem Value="HK">HongKong</asp:ListItem>
<asp:ListItem Value="HU">Hungary</asp:ListItem>
<asp:ListItem Value="IS">Iceland</asp:ListItem>
<asp:ListItem Value="IN">India</asp:ListItem>
<asp:ListItem Value="ID">Indonesia</asp:ListItem>
<asp:ListItem Value="IR">Iran (Islamic Rep.)</asp:ListItem>
<asp:ListItem Value="IQ">Iraq</asp:ListItem>
<asp:ListItem Value="IE">Ireland</asp:ListItem>
<asp:ListItem Value="IL">Israel</asp:ListItem>
<asp:ListItem Value="IT">Italy</asp:ListItem>
<asp:ListItem Value="JM">Jamaica</asp:ListItem>
<asp:ListItem Value="JP">Japan</asp:ListItem>
<asp:ListItem Value="JO">Jordan</asp:ListItem>
<asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
<asp:ListItem Value="KE">Kenya</asp:ListItem>
<asp:ListItem Value="KI">Kiribati</asp:ListItem>
<asp:ListItem Value="KP">Korea (Democratic Peoples Rep.)</asp:ListItem>
<asp:ListItem Value="KR">Korea (Republic)</asp:ListItem>
<asp:ListItem Value="KW">Kuwait</asp:ListItem>
<asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
<asp:ListItem Value="LA">Laos</asp:ListItem>
<asp:ListItem Value="LV">Latvia</asp:ListItem>
<asp:ListItem Value="LB">Lebanon</asp:ListItem>
<asp:ListItem Value="LS">Lesotho</asp:ListItem>
<asp:ListItem Value="LR">Liberia</asp:ListItem>
<asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>
<asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
<asp:ListItem Value="LT">Lithuania</asp:ListItem>
<asp:ListItem Value="LU">Luxembourg</asp:ListItem>
<asp:ListItem Value="MO">Macau</asp:ListItem>
<asp:ListItem Value="MK">Macedonia</asp:ListItem>
<asp:ListItem Value="MG">Madagascar</asp:ListItem>
<asp:ListItem Value="MW">Malawi</asp:ListItem>
<asp:ListItem Value="MY">Malaysia</asp:ListItem>
<asp:ListItem Value="MV">Maldives</asp:ListItem>
<asp:ListItem Value="ML">Mali</asp:ListItem>
<asp:ListItem Value="MT">Malta</asp:ListItem>
<asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
<asp:ListItem Value="MQ">Martinique</asp:ListItem>
<asp:ListItem Value="MR">Mauritania</asp:ListItem>
<asp:ListItem Value="MU">Mauritius</asp:ListItem>
<asp:ListItem Value="YT">Mayotte</asp:ListItem>
<asp:ListItem Value="MX">Mexico</asp:ListItem>
<asp:ListItem Value="FM">Micronesia (Federated State)</asp:ListItem>
<asp:ListItem Value="MD">Moldova (Rep.)</asp:ListItem>
<asp:ListItem Value="MC">Monaco</asp:ListItem>
<asp:ListItem Value="MN">Mongolia</asp:ListItem>
<asp:ListItem Value="ME">Montenegro</asp:ListItem>
<asp:ListItem Value="MS">Montserrat</asp:ListItem>
<asp:ListItem Value="MA">Morocco</asp:ListItem>
<asp:ListItem Value="MZ">Mozambique</asp:ListItem>
<asp:ListItem Value="MM">Myanmar (Burma)</asp:ListItem>
<asp:ListItem Value="NA">Namibia</asp:ListItem>
<asp:ListItem Value="NR">Nauru</asp:ListItem>
<asp:ListItem Value="NP">Nepal</asp:ListItem>
<asp:ListItem Value="NL">Netherlands</asp:ListItem>
                                                </asp:DropDownList>
                                                </nobr>
                                            </td>
                                            <td runat="server" style="width: 1px; text-align: right; border-left: solid 1px red;">&nbsp;</td>
                                            <td runat="server" style="width: 100%; text-align: left; border: solid 0px red;">&nbsp;</td>
                                        </tr>
                                    </table>
                                </ContentTemplate>
                            </cc1:TabPanel>
                            <cc1:TabPanel ID="TabPanel2" Visible="true" runat="server" HeaderText="Chỉ tiêu thông tin kết xuất">
                                <ContentTemplate>
                                  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnChonTat" runat="server"  Text="Chọn toàn bộ" OnClick="btnChonTat_Click" />
        <asp:Button ID="btnBoHet" runat="server" Text="Bỏ chọn toàn bộ" OnClick="btnBoHet_Click" />
        <hr />
                                    
                                   <table style="border:solid 1px gray;">
                                       <tr >
                                           <td id="tdFieldTK1" style="border:solid 0px gray;vertical-align:top;" runat="server"> 
                                               <asp:Label ID="labeltokhai1" Text="THÔNG TIN TỜ KHAI" BackColor="Yellow" runat="server"></asp:Label>
                                               <br />
                                               <br />
                                              <asp:CheckBox ID="SIKNO"  Text="SỐ TK" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="SINKD"  Text="NGÀY ĐK" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="SINKS"  Text="MÃ LH" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="SHIKS"  Text="MÃ HQ" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YUNYC"  Text="MÃ ĐƠN VỊ" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YUSYK"  Text="NƯỚC XNK" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YUNN2"  Text="ĐỐI TÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="CYUK1"  Text="ĐƠN VỊ ỦY THÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TRANS"  Text="MÃ PTVT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TYBNA"  Text="TÊN PTVT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TYNEP"  Text="NGÀY ĐẾN PTVT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="AWBNB_1"  Text="SỐ VẬN ĐƠN 1" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="AWBNB_2"  Text="SỐ VẬN ĐƠN 2" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="AWBNB_3"  Text="SỐ VẬN ĐƠN 3" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="AWBNB_4"  Text="SỐ VẬN ĐƠN 4" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="AWBNB_5"  Text="SỐ VẬN ĐƠN 5" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TRORC"  Text="MÃ CỬA KHẨU" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TRORN"  Text="TÊN CỬA KHẨU" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TMDSI"  Text="CẢNG NƯỚC NGOÀI" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TMDSM"  Text="TÊN CẢNG NƯỚC NGOÀI" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YSYOS_1"  Text="SỐ GiẤY PHÉP 1" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YSYOS_2"  Text="SỐ GiẤY PHÉP 2" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YSYOS_3"  Text="SỐ GiẤY PHÉP 3" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YSYOS_4"  Text="SỐ GiẤY PHÉP 4" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YSYOS_5"  Text="SỐ GiẤY PHÉP 5" Enabled="true" runat="server" Checked="true" />
                                           </td>
                                           <td id="tdFieldTK2" style="padding-left:30px;border:solid 0px gray;vertical-align:top;" runat="server" >
                                               <asp:Label ID="label15" Text="THÔNG TIN TỜ KHAI" BackColor="Yellow" runat="server"></asp:Label>
                                                <br />
                                               <br />
                                              <asp:CheckBox ID="KIJIT"  Text="SỐ HỢP ĐỒNG #& NGÀY HỢP ĐỒNG (nếu là tờ khai gia công) hoặc GHI CHÚ KHÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="INVKJ"  Text="MÃ GIAO HÀNG" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="RPEAT"  Text="SỐ DÒNG HÀNG" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="PAYCD"  Text="MÃ PTTT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TUKCD_1"  Text="MÃ NT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TUKRT_1"  Text="TỶ GIÁ VNĐ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="UDATE"  Text="NGÀY KB" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="UTIME"  Text="GiỜ KB" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="HOKEN"  Text="PHÍ BẢO HiỂM" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="UNTIN"  Text="PHÍ VẬN CHUYỂN" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="INVKA"  Text="TỔNG TRỊ GIÁ KB" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="HKANZ"  Text="TỔNG TRỊ GIÁ TÍNH THUẾ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="WAIGW"  Text="TRỌNG LƯỢNG" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KOSUK"  Text="SỐ KIỆN" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="GSIRT"  Text="PHÂN LUỒNG" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="INVNO"  Text="SỐ HÓA ĐƠN TM" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="INDAY"  Text="NGÀY HÓA ĐƠN TM" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KIJIT_DEXUAT"  Text="ĐỀ XUẤT KHÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YUSYC"  Text="TÊN ĐỐI TÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="YUNN1"  Text="TÊN ĐƠN VỊ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="CYUK2"  Text="ĐƠN VỊ ỦY THÁC" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KONTA"  Text="SỐ CONT" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KYOKD"  Text="NGÀY HOÀN THÀNH" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KYOKT"  Text="GIỜ HOÀN THÀNH" Enabled="true" runat="server" Checked="true" /><br/>
                                           </td>
                                            <td id="tdFieldHANG" style="padding-left:30px;border-left:solid 1px gray;vertical-align:top;" runat="server" >
                                                <asp:Label ID="label16" Text="THÔNG TIN HÀNG HÓA" BackColor="Yellow" runat="server"></asp:Label>
                                                <br /><br />
                                                <asp:CheckBox ID="SIKNO_HANG"  Text="SỐ TK" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="RANNB"  Text="STT HÀNG" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="HINMC_MA"  Text="MÃ HÀNG" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="HINME_TEN"  Text="TÊN HÀNG" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="MATCD_LOAI"  Text="LOẠI HÀNG" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="ORGLC"  Text="NƯỚC XX" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TANI1"  Text="MÃ ĐVT" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="SURY1"  Text="SỐ LƯỢNG" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="TANKA"  Text="ĐƠN GIÁ KB" Enabled="false" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KAZTK"  Text="ĐƠN GIÁ TÍNH THUẾ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="BPRIC"  Text="TRỊ GIÁ KB" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KANKG"  Text="TRỊ GIÁ TÍNH THUẾ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KAZEI"  Text="TRỊ GIÁ KB VNĐ" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KANRT"  Text="TS XNK" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="KANGK"  Text="THUẾ XNK" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="ORGNK"  Text="MÃ BIỂU THUẾ XNK" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIBC_1"  Text="LOẠI THUẾ 1" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIRT_1"  Text="TS LOẠI THUẾ 1" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIGK_1"  Text="TiỀN THUẾ LOẠI THUẾ 1" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIBC_2"  Text="LOẠI THUẾ 2" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIRT_2"  Text="TS LOẠI THUẾ 2" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIGK_2"  Text="TiỀN THUẾ LOẠI THUẾ 2" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIBC_3"  Text="LOẠI THUẾ 3" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIRT_3"  Text="TS LOẠI THUẾ 3" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIGK_3"  Text="TiỀN THUẾ LOẠI THUẾ 3" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIBC_4"  Text="LOẠI THUẾ 4" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIRT_4"  Text="TS LOẠI THUẾ 4" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIGK_4"  Text="TiỀN THUẾ LOẠI THUẾ 4" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIBC_5"  Text="LOẠI THUẾ 5" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIRT_5"  Text="TS LOẠI THUẾ 5" Enabled="true" runat="server" Checked="true" /><br/>
<asp:CheckBox ID="NAIGK_5"  Text="TiỀN THUẾ LOẠI THUẾ 5" Enabled="true" runat="server" Checked="true" /><br/>

                                                </td>
                                       </tr>
                                   </table>
                              



                                    </ContentTemplate>
                            </cc1:TabPanel>
                        </cc1:TabContainer>
                        <div id="background" style="text-align: left; vertical-align: top; padding: 5px; color: black;">
                            <table style="width:100%;">
                                <tr>
                                    <td style="width:1px;">
    <asp:Button ID="btnDatLenh" runat="server" Text="Đặt lệnh tra cứu (Alt+S)" OnClick="btnDatLenh_Click" TabIndex="19" AccessKey="s" />
                                    </td>
 <td style="width:1px;">
  <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật" OnClick="btnUpdate_Click" TabIndex="20" />
    
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
                                   
                                     <asp:TemplateField HeaderText="Điều kiện tra cứu">
                                         <ItemStyle Width="500px" />
                                        <ItemTemplate>
                                            <div>                                               
                                                <span  style="padding: 2px;"  runat="server"><%#Eval("RP_DISPLAY")%></span>
                                            </div>
                                        </ItemTemplate>
                                    </asp:TemplateField>
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
                    <p>&copy; 2014- Trung tâm quản lý và vận hành hệ thống CNTT - Cục CNTT và Thống kê Hải quan - Tổng Cục Hải quan        </div>
            </div>
        </footer>
       
    </form>
</body>
</html>
