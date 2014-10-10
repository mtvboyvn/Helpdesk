<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ThemCauHoi.aspx.vb" Inherits="HelpDesk.ThemCauHoi"%>



<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
            <nobr>
<h2>
        Thêm câu hỏi</h2>
                </nobr>
            <hr />
 

        <table border="0" id="tblCauHoi"  style="width: 100%;border:0px solid black;" runat="server" >
            <tr>
                <td></td>
                <td>
                     <asp:Button ID="RadButton1" OnClick="RadButton1_Click" runat="server"  Text="Ghi dữ liệu (Alt+S)" Skin="Metro" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                    <br />
                </td>
                <td>
                    <asp:Button ID="btnNhapMoi" runat="server"  Text="Nhập mới" Skin="Metro" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                </td>
                <td>
                      <nobr>
                &nbsp;<asp:Button ID="RadButton4" runat="server"  Text="Quay lại" Skin="Metro" PostBackUrl="~/Default.aspx" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                          &nbsp;&nbsp;&nbsp;
                      <asp:Label ID="lblMSG2" runat="server" BackColor="#FFFF66" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Font-Size="1.2em" ForeColor="Black" Height="30px" Text="&nbsp;Thông báo tại đây&nbsp;"></asp:Label>
                      <asp:HiddenField ID="CH_ID" runat="server" />
        </nobr>
                </td>
            </tr>
            <tr >
                <td style="width:1px;text-align:right;" >
                    <nobr> 
                    <asp:Label ID="Label1" runat="server" 
                        Text="Phân loại đối tượng:"></asp:Label>
                        </nobr>
                </td>
                <td style="text-align:left;">
                <nobr>    <asp:RadioButton ID="CH_DOITUONGHOI1" GroupName="ABC" Text="Doanh nghiệp" runat="server" Checked="True" Font-Bold="True" ForeColor="Red" />
                    &nbsp;&nbsp;&nbsp;
                     <asp:RadioButton ID="CH_DOITUONGHOI2"  GroupName="ABC" Text="Hải quan" runat="server" ForeColor="Blue" />
                </nobr>
                </td>
                <td>&nbsp;</td>
                <td>
          
                </td>
            </tr>
              <tr>
                <td style="width:1px;text-align:right;" >
                    <nobr>
                    <asp:Label ID="Label2" runat="server" 
                        Text="Mã số thuế:"></asp:Label>
                        </nobr>
                </td>
                <td style="width:1px;text-align:left;">&nbsp;<asp:TextBox ID="CH_DONVI_MST" Runat="server" Font-Bold="True" Font-Size="1.2em" ForeColor="Red" Width="200px"></asp:TextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label3" runat="server" 
                        Text="Tên doanh nghiệp:"></asp:Label>
                        </nobr>
                </td>
                <td>
                    &nbsp;<asp:TextBox ID="CH_DONVI_TEN" Runat="server" Font-Bold="False" Width="350px" Font-Size="1.2em" ForeColor="Red"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label11" runat="server" 
                        Text="Mã Hải quan:"></asp:Label>
                        </nobr>
                </td>
                <td >&nbsp;<asp:TextBox ID="CH_NGUOIHOI_MAHQLIENQUAN" Runat="server" Font-Bold="True" Font-Size="1.2em" ForeColor="Blue" Width="200px"></asp:TextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label12" runat="server" 
                        Text="Tên Hải quan:"></asp:Label>
                        </nobr>
                </td>
                <td>&nbsp;<asp:TextBox ID="CH_NGUOIHOI_TENHQLIENQUAN" Runat="server" Font-Bold="False" Text="Hải quan Hà nội" Width="350px" Font-Size="1.2em" ForeColor="Blue">
                        
                    </asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label4" runat="server" 
                        Text="Tên người hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td>&nbsp;<asp:TextBox ID="CH_NGUOIHOI_TEN" Runat="server" Font-Bold="False" Font-Size="1.2em" Width="200px"></asp:TextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label5" runat="server" 
                        Text="Số điện thoại người hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td>
                    &nbsp;<asp:TextBox ID="CH_NGUOIHOI_DIENTHOAI" Runat="server" Font-Bold="False" Font-Size="1.2em" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label6" runat="server"  Text="Email người hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td >&nbsp;<asp:TextBox ID="CH_NGUOIHOI_EMAIL" Runat="server" Font-Bold="False" Width="200px" Font-Size="1.2em"></asp:TextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label13" runat="server" 
                        Text="Người trả lời:" Font-Bold="True"></asp:Label>
                        </nobr>
                </td>
                <td>
                    &nbsp;<asp:TextBox ID="CH_NGUOITRALOI_TAIKHOAN" Runat="server" Font-Bold="True" Font-Size="1.2em" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
              <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label10" runat="server"  Text="Phân loại câu hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td colspan="3">
                <nobr>    
                    &nbsp;&nbsp;&nbsp;
                     <asp:RadioButton ID="CH_CAUHOI_PHANLOAI1"  GroupName="PhanLoai" Text="VNACCS" Checked="true" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI2"  GroupName="PhanLoai" Text="VCIS" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI3"  GroupName="PhanLoai" Text="Nghiệp vụ Hải quan" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI4"  GroupName="PhanLoai" Text="E-Manifest" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI5"  GroupName="PhanLoai" Text="E-Customs" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI6"  GroupName="PhanLoai" Text="Kế toán thuế" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="CH_CAUHOI_PHANLOAI7"  GroupName="PhanLoai" Text="Đăng ký người sử dụng" runat="server"  />
                </nobr>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td style="width:1px;text-align:right;vertical-align:top;">
                    <nobr>
                    <asp:Label ID="Label14" runat="server"  Text="Ngày hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td >
                    &nbsp;<asp:TextBox ID="RadDateInput1" Runat="server" Width="100px"></asp:TextBox>
                    <cc1:CalendarExtender ID="CalendarExtender1" runat="server"
        TargetControlID="RadDateInput1" PopupButtonID="ImageButton1"/>
<asp:ImageButton ID="ImageButton1" runat="server" />
                 </td>
                <td style="width:1px;text-align:right;vertical-align:top;">
                    <nobr>
                    <asp:Label ID="Label15" runat="server"  Text="Ngày trả lời:"></asp:Label>
                        </nobr>
                 </td>
                <td>
                    &nbsp;<asp:TextBox ID="RadDateInput2" Runat="server" DateFormat="dd/MM/yyyy" DisplayDateFormat="dd/MM/yyyy" Width="200px"></asp:TextBox>
                 </td>
            </tr>
             <tr>
                <td style="width:1px;text-align:right;vertical-align:top;">
                    <nobr>
                    <asp:Label ID="Label8" runat="server" 
                        Text="Nội dung câu hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="CH_CAUHOI_NOIDUNGCAUHOI" Runat="server" Skin="Metro" Width="800px" EditModes="Design" ToolbarMode="RibbonBarFloating" BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="250px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                 <td style="width:1px;text-align:right;vertical-align:top;">
                     <nobr>
                    <asp:Label ID="Label9" runat="server" 
                        Text="Nội dung câu trả lời:"></asp:Label>
                         </nobr>
                </td>
                <td colspan="4">
                    <asp:TextBox ID="CH_CAUHOI_NOIDUNGTRALOI" Runat="server" Skin="Metro" Width="800px" EditModes="Design" ToolbarMode="RibbonBarFloating" BorderColor="Gray" BorderStyle="Solid" BorderWidth="1px" Height="250px" TextMode="MultiLine"></asp:TextBox>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 199px">
                    &nbsp;</td>
                <td>
                    
                    <asp:Button ID="btnGhiDuLieu" runat="server"  Text="Ghi dữ liệu (Alt+S)" Skin="Metro" AccessKey="s" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                </td>
                <td>
                    
                    <asp:Button ID="RadButton2" runat="server"  Text="Nhập mới" Skin="Metro"  BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                </td>
                <td>
                    <nobr>
                        <asp:Button ID="RadButton5" runat="server"  Text="Quay lại" Skin="Metro" PostBackUrl="~/Default.aspx" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </asp:Button>
                         &nbsp; &nbsp; &nbsp;
                    <asp:Label ID="lblMSG1" runat="server" BackColor="#FFFF66" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Font-Size="1.2em" ForeColor="Black" Height="30px" Text="&nbsp;Thông báo tại đây&nbsp;"></asp:Label>
                        </nobr>
                </td>
            </tr>
        </table>

        
       
        <br />
     
    
        
    
    </div>
</asp:Content>



