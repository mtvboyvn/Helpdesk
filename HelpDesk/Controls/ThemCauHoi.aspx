<%@ Page Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="ThemCauHoi.aspx.vb" Inherits="HelpDesk.ThemCauHoi"%>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
<h2>
        Thêm câu hỏi</h2>
            <hr />
 

        <table border="0" id="tblCauHoi"  style="width: 100%;border:0px solid black;" runat="server" >
            <tr >
                <td style="width:1px;text-align:right;" >
                    <nobr> 
                    <asp:Label ID="Label1" runat="server" 
                        Text="Phân loại đối tượng:"></asp:Label>
                        </nobr>
                </td>
                <td style="text-align:left;">
                <nobr>    <asp:RadioButton ID="RadioButton1" GroupName="ABC" Text="Doanh nghiệp" runat="server" Checked="True" Font-Bold="True" ForeColor="Red" />
                    &nbsp;&nbsp;&nbsp;
                     <asp:RadioButton ID="RadioButton2"  GroupName="ABC" Text="Hải quan" runat="server" ForeColor="Blue" />
                </nobr>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
              <tr>
                <td style="width:1px;text-align:right;" >
                    <nobr>
                    <asp:Label ID="Label2" runat="server" 
                        Text="Mã số thuế:"></asp:Label>
                        </nobr>
                </td>
                <td style="width:1px;text-align:left;">                   
                    &nbsp;<telerik:RadTextBox ID="CH_DONVI_MST" Runat="server" Font-Bold="True" Text="0100101308" Font-Size="1.2em">
                        <focusedstyle backcolor="#FFFF66" />
                    </telerik:RadTextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label3" runat="server" 
                        Text="Tên doanh nghiệp:"></asp:Label>
                        </nobr>
                </td>
                <td>
                    &nbsp;<telerik:RadTextBox ID="RadTextBox2" Runat="server" Font-Bold="False" Text="Công ty THHH May 10" Width="350px" Font-Size="1.2em">
                        <focusedstyle backcolor="#FFFF66" />
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label4" runat="server" 
                        Text="Tên người hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td >
                    &nbsp;<telerik:RadTextBox ID="RadTextBox3" Runat="server" Font-Bold="False" Text="Hứa Mạnh Tuyển" Font-Size="1.2em">
                        <focusedstyle backcolor="#FFFF66" />
                    </telerik:RadTextBox>
                </td>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label5" runat="server" 
                        Text="Số điện thoại:"></asp:Label>
                        </nobr>
                </td>
                <td>
                    &nbsp;<telerik:RadTextBox ID="RadTextBox4" Runat="server" Font-Bold="False" Text="0936394405" Font-Size="1.2em">
                        <focusedstyle backcolor="#FFFF66" />
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td style="width:1px;text-align:right;">
                    <nobr>
                    <asp:Label ID="Label6" runat="server"  Text="Email:"></asp:Label>
                        </nobr>
                </td>
                <td colspan="3">
                    &nbsp;<telerik:RadTextBox ID="RadTextBox5" Runat="server" Font-Bold="False" Text="huamanhtuyen@gmail.com" Width="160px" Font-Size="1.2em">
                        <focusedstyle backcolor="#FFFF66" />
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;</td>
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
                     <asp:RadioButton ID="RadioButton3"  GroupName="PhanLoai" Text="VNACCS" Checked="true" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton4"  GroupName="PhanLoai" Text="VCIS" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton5"  GroupName="PhanLoai" Text="Nghiệp vụ Hải quan" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton6"  GroupName="PhanLoai" Text="E-Manifest" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton7"  GroupName="PhanLoai" Text="E-Customs" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton8"  GroupName="PhanLoai" Text="Kế toán thuế" runat="server"  />
                    &nbsp;&nbsp;
                    <asp:RadioButton ID="RadioButton9"  GroupName="PhanLoai" Text="Đăng ký người sử dụng" runat="server"  />
                </nobr>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
             <tr>
                <td style="width:1px;text-align:right;vertical-align:top;">
                    <nobr>
                    <asp:Label ID="Label8" runat="server" 
                        Text="Nội dung câu hỏi:"></asp:Label>
                        </nobr>
                </td>
                <td colspan="4">
                    <telerik:RadEditor ID="RadEditor1" Runat="server" Skin="Office2010Blue" Width="800px">
                    </telerik:RadEditor>
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
                    <telerik:RadEditor ID="RadEditor2" Runat="server" Width="800px" Skin="Office2010Blue">
                    </telerik:RadEditor>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td style="width: 199px">
                    &nbsp;</td>
                <td>
                    
                    <telerik:RadButton ID="btnGhiDuLieu" runat="server"  Text="Ghi dữ liệu (Alt+S)" Skin="Metro" AccessKey="s" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </telerik:RadButton>
                </td>
                <td>
                    
                    <telerik:RadButton ID="RadButton2" runat="server"  Text="Quay lại" Skin="Metro" PostBackUrl="~/Default.aspx" BackColor="#4484F1" CssClass="nutBam" ForeColor="White" Height="30px">
        </telerik:RadButton>
                </td>
                <td>
                    <nobr>
                    <asp:Label ID="lblMSG1" runat="server" BackColor="#FFFF66" BorderColor="#0066FF" BorderStyle="Solid" BorderWidth="1px" Font-Size="1.2em" ForeColor="Black" Height="30px" Text="&nbsp;Thông báo tại đây&nbsp;"></asp:Label>
                        </nobr>
                </td>
            </tr>
        </table>

        
       
        <br />
     
    
        
    
    </div>
</asp:Content>



