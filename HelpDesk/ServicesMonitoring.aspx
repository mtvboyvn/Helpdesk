<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ServicesMonitoring.aspx.vb" Inherits="HelpDesk.ServicesMonitoring" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></cc1:ToolkitScriptManager>
        <asp:Timer ID="timer1" runat="server" Interval="10000" OnTick="btnUpdate_Click"></asp:Timer>
    <div style="width:100%;background-color:green;text-align:center;">
        <span style="font-family:'Segoe UI';font-size:x-large;color:white;"><b>WIN/WEB SERVICES MONITORING</b></span>
    </div>
       
         <div style="border: dashed 0px #222222;">
                <div id="up_container" style="background-color: #f1f1f1;height:90%;">
                    <asp:UpdatePanel ID="update" runat="server">
                        <ContentTemplate>
                            <div id="background" style="text-align:left; vertical-align: top; padding: 5px; color: black;">
                                     <asp:Button ID="btnUpdate" runat="server" Text="Refesh" OnClick="btnUpdate_Click" />
                                 <asp:Label ID="lblUpdate" runat="server" Text=""></asp:Label>
                                <hr />
                                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
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
