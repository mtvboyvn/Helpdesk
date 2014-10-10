<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="tDateTime.ascx.vb" Inherits="HelpDesk.tDateTime" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:TextBox ID="txtDateTimeInput" runat="server" Width="160px"></asp:TextBox>
<cc1:MaskedEditExtender ID="txtDateTimeInput_MaskedEditExtender" runat="server" ClearMaskOnLostFocus="False" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" Mask="99/99/9999" TargetControlID="txtDateTimeInput">
</cc1:MaskedEditExtender>
<cc1:CalendarExtender ID="txtDateTimeInput_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtDateTimeInput" Format="dd/MM/yyyy"></cc1:CalendarExtender>

