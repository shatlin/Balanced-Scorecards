<%@ Register Tagprefix="BS" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="BS" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BS" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Tagprefix="BS" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="AddMeasureRoleDetailPage.aspx.cs" Inherits="BS.UI.AddMeasureRoleDetailPage" %>
<%@ Register Tagprefix="BS" Namespace="BS.UI.Controls.AddMeasureRoleDetailPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>AddMeasureRoleDetailPage</title>
    <link rel="stylesheet" rev="stylesheet" type="text/css" href="../Styles/Style.css"/>
    </head>
    <body id="Body1" runat="server" class="pBack">
    <form id="Form1" method="post" runat="server">
        <BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
        <BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
        <script language="JavaScript" type="text/javascript">clearRTL()</script>
		<asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" />
		
        <table cellspacing="0" cellpadding="0" border="0" height="100%" width="100%">
        <tr>
        <td class="pAlign">
        <table cellspacing="0" cellpadding="0" border="0" class="pbTable">
            <tr>
            <td class="pbTL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbT"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbTR"><img src="../Images/space.gif" alt=""/></td>
            </tr>
            <tr>
            <td class="pbL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbC">
            <table cellspacing="0" cellpadding="0" border="0" class="pcTable">
            <tr>
                <td class="pcT" colspan="2">
                <table cellspacing="0" cellpadding="0" border="0" width="100%">
                <tr>
                <td>
                    <BS:Header runat="server" id="PageHeader">
		</BS:Header>
                </td>
                </tr>
                </table></td>
                <td class="pcTR"></td>
            </tr>
            <tr>
                <td class="pcL">
                    
                </td>
                <td class="pcC">			
                    <table cellspacing="0" cellpadding="0" border="0" width="100%" height="100%">
                    <tr>
                    <td>
                        <BS:Menu runat="server" id="Menu" HiliteSettings="MeasureRoleDetailMenuItem">
		</BS:Menu>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr>
                        <td class="pContent">
                            <a name="StartOfPageContent"></a>
                <asp:UpdateProgress runat="server" id="MeasureRoleDetailRecordControlUpdateProgress" AssociatedUpdatePanelID="MeasureRoleDetailRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="MeasureRoleDetailRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<BS:MeasureRoleDetailRecordControl runat="server" id="MeasureRoleDetailRecordControl">
														
<!-- Begin Record Panel.html -->

<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SaveButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("CancelButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("OKButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SaveNNewButton$_Button")) %>

 <table class="dialog_view" cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td class="dh">
    <table cellpadding="0" cellspacing="0" width="100%" border="0">
    <tr>
    <td class="dhel"><img src="../Images/space.gif" alt=""/></td>
    <td class="dheci" valign="middle"><a onclick="toggleExpandCollapse(this);"><img id="ExpandCollapseIcon" src="../Images/DialogHeaderIconCollapse.gif" border="0" alt="Collapse panel"/></a></td>
    <td class="dhb">
    <table cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="MeasureRoleDetailDialogTitle" Text="Add Measure Role Detail">
														</asp:Literal></td>
    </tr>
    </table>
    </td>	
    <td class="dher"><img src="../Images/space.gif" alt=""/></td>
    </tr>
    </table>
    </td>
    </tr>
                <tr>
    <td>
    <table id="CollapsibleRegion" style="display:block;" cellpadding="0" cellspacing="0" border="0" width="100%">
    <tr>
    <td class="dialog_body">
    <table cellpadding="0" cellspacing="3" border="0">
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="MeasureIdLabel" Text="Measure">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:DropDownList runat="server" id="MeasureId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
														</asp:DropDownList>
														<Selectors:FvLlsHyperLink runat="server" id="MeasureIdFvLlsHyperLink" ControlToUpdate="MeasureId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Measure" Field="Measure_.MeasureId" DisplayField="Measure_.MeasureName">														</Selectors:FvLlsHyperLink>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="MeasureIdRequiredFieldValidator" ControlToValidate="MeasureId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>
    
    <asp:ImageButton runat="server" id="MeasureIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="page" ControlToUpdate="MeasureId" FieldValue="MeasureId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Measure/AddMeasurePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

														</asp:ImageButton>
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="OrgRoleIdLabel" Text="Organization Role">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:DropDownList runat="server" id="OrgRoleId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
														</asp:DropDownList>
														<Selectors:FvLlsHyperLink runat="server" id="OrgRoleIdFvLlsHyperLink" ControlToUpdate="OrgRoleId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="OrgRole" Field="OrgRole_.OrgRoleId" DisplayField="OrgRole_.OrgRoleName">														</Selectors:FvLlsHyperLink>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="OrgRoleIdRequiredFieldValidator" ControlToValidate="OrgRoleId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Organization Role&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>
    
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="ActualLabel" Text="Actual">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <table border="0" cellpadding="0" cellspacing="0">
														<tr>
														<td style="padding-right: 5px; vertical-align:top">
														<asp:TextBox runat="server" id="Actual" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" CssClass="field_input" EnableIncrementDecrementButtons="True">
														</asp:TextBox></td>
														<td style="padding-right: 5px; white-space:nowrap;">
														<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("Actual"),"NumberTextBox","","","") %>
														&nbsp;
														<asp:RequiredFieldValidator runat="server" id="ActualRequiredFieldValidator" ControlToValidate="Actual" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Actual&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>&nbsp;
														<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ActualTextBoxMaxLengthValidator" ControlToValidate="Actual" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Actual&quot;) %>">														</BaseClasses:TextBoxMaxLengthValidator></td>
														</tr>
														</table>
														
    
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="TargetLabel" Text="Target">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <table border="0" cellpadding="0" cellspacing="0">
														<tr>
														<td style="padding-right: 5px; vertical-align:top">
														<asp:TextBox runat="server" id="Target" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" CssClass="field_input" EnableIncrementDecrementButtons="True">
														</asp:TextBox></td>
														<td style="padding-right: 5px; white-space:nowrap;">
														<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("Target"),"NumberTextBox","","","") %>
														&nbsp;
														<asp:RequiredFieldValidator runat="server" id="TargetRequiredFieldValidator" ControlToValidate="Target" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Target&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>&nbsp;
														<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TargetTextBoxMaxLengthValidator" ControlToValidate="Target" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Target&quot;) %>">														</BaseClasses:TextBoxMaxLengthValidator></td>
														</tr>
														</table>
														
    
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="MonthIdLabel" Text="Month">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:DropDownList runat="server" id="MonthId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
														</asp:DropDownList>
														<Selectors:FvLlsHyperLink runat="server" id="MonthIdFvLlsHyperLink" ControlToUpdate="MonthId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Month" Field="Month_.MonthId" DisplayField="Month_.MonthName">														</Selectors:FvLlsHyperLink>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="MonthIdRequiredFieldValidator" ControlToValidate="MonthId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Month&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>
    
    <asp:ImageButton runat="server" id="MonthIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="page" ControlToUpdate="MonthId" FieldValue="MonthId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Month/AddMonthPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

														</asp:ImageButton>
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="YearIdLabel" Text="Year">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:DropDownList runat="server" id="YearId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
														</asp:DropDownList>
														<Selectors:FvLlsHyperLink runat="server" id="YearIdFvLlsHyperLink" ControlToUpdate="YearId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Year" Field="Year_.YearId" DisplayField="Year_.YearValue">														</Selectors:FvLlsHyperLink>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="YearIdRequiredFieldValidator" ControlToValidate="YearId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Year&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>
    
    <asp:ImageButton runat="server" id="YearIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="page" ControlToUpdate="YearId" FieldValue="YearId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Year/AddYearPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

														</asp:ImageButton>
    </td>
    </tr>
                </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
 </table>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("OKButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("CancelButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SaveButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("SaveNNewButton$_Button")) %>
<!-- End Record Panel.html -->

											</BS:MeasureRoleDetailRecordControl>
											</ContentTemplate>
										</asp:UpdatePanel>
									
<br/>
                        
    <table cellpadding="0" cellspacing="0" border="0" id="Table1">
    <tr>
    <td class="recordPanelButtonsAlignment">
    <table cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td><BS:ThemeButton runat="server" id="SaveButton" Button-CausesValidation="True" Button-CommandName="UpdateData" Button-RedirectURL="Back" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;BS&quot;) %>">
										</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td><BS:ThemeButton runat="server" id="SaveAndNewButton" Button-CausesValidation="True" Button-CommandName="UpdateData" Button-Text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;BS&quot;) %>">
										</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
	<td><BS:ThemeButton runat="server" id="CancelButton" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="Back" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;BS&quot;) %>">
										</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    </tr>
    </table>
    </td>
    </tr>
</table>

                            <div id="detailPopup" style="z-index:2; visibility:visible; position:absolute;"></div>
                            <div id="detailPopupDropShadow" class="detailPopupDropShadow" style="z-index:1; visibility:visible; position:absolute;"></div>
                        </td>
                        </tr>
                        </table>
                    </td>
                    </tr>
                    </table>
                </td>
                <td class="pcR"></td>
            </tr>
            <tr>
                <td class="pcBL"></td>
                <td class="pcB">
                <BS:Footer runat="server" id="PageFooter">
									</BS:Footer>
                </td>
                <td class="pcBR"></td>
            </tr>
            </table>
            </td>
            <td class="pbR"><img src="../Images/space.gif" alt=""/></td>
        </tr>
        <tr>
            <td class="pbBL"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbB"><img src="../Images/space.gif" alt=""/></td>
            <td class="pbBR"><img src="../Images/space.gif" alt=""/></td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
    </form>
    </body>
</html>
