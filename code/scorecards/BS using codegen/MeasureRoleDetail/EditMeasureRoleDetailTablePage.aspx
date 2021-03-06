<%@ Register Tagprefix="BS" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="BS" Namespace="BS.UI.Controls.EditMeasureRoleDetailTablePage" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="EditMeasureRoleDetailTablePage.aspx.cs" Inherits="BS.UI.EditMeasureRoleDetailTablePage" %>
<%@ Register Tagprefix="BS" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Tagprefix="BS" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="BS" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>EditMeasureRoleDetailTablePage</title>
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
                            <asp:UpdateProgress runat="server" id="MeasureRoleDetailTableControlUpdateProgress" AssociatedUpdatePanelID="MeasureRoleDetailTableControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="MeasureRoleDetailTableControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<BS:MeasureRoleDetailTableControl runat="server" id="MeasureRoleDetailTableControl">
														
<!-- Begin Table Panel.html -->

<table class="dv" cellpadding="0" cellspacing="0" border="0">
	<tr>
	<td class="dh">
	<table cellpadding="0" cellspacing="0" width="100%" border="0">
	<tr>
	<td class="dhel"><img src="../Images/space.gif" alt=""/></td>
	<td class="dheci" valign="middle"><a onclick="toggleRegions(this);"><img id="ToggleRegionIcon" src="../Images/ToggleHideFilters.gif" border="0" alt="Hide Filters"/></a></td>
	<td class="dht" valign="middle"><asp:Literal runat="server" id="MeasureRoleDetailTableTitle" Text="Measure Role Detail">
														</asp:Literal></td>
	<td class="dhtrc">
		<table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
		<tr>
		<td class="dhtrct"><%# GetResourceValue("Txt:TotalItems", "BS") %>&nbsp;<asp:Label runat="server" id="MeasureRoleDetailTotalItems">
														</asp:Label></td>
		</tr>
	</table>
	</td>
	<td class="dher"><img src="../Images/space.gif" alt=""/></td>
	</tr>
	</table>
	</td>
	</tr>
 <tr>
    <td class="dBody">
    <table id="CollapsibleRegion" style="display:block;" cellspacing="0" cellpadding="0" border="0">
    <tr>
    <td>
    <table id="FilterRegion" cellpadding="0" cellspacing="3" border="0">
    
    <!-- Search & Filter Area -->
    <tr>
        <td class="fila"></td>
        <td>
        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("MeasureRoleDetailTableControl$MeasureRoleDetailSearchButton")) %>
        
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("MeasureRoleDetailTableControl$MeasureRoleDetailSearchButton")) %>
        </td>
        <td class="filbc"></td>
    </tr>
    
    
    <tr>
    <td></td>
    <td></td>
    <td rowspan="100" class="filbc"></td> 
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("MeasureRoleDetailTableControl$MeasureRoleDetailFilterButton")) %>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="MeasureIdLabel" Text="Measure">
															</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="MeasureIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
															</asp:DropDownList></td>
    </tr>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="OrgRoleIdLabel" Text="Organization Role">
															</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="OrgRoleIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
															</asp:DropDownList></td>
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("MeasureRoleDetailTableControl$MeasureRoleDetailFilterButton")) %>
    
    </table>
    <div class="spacer"></div>
    <!-- Category Area -->
    <table cellspacing="0" cellpadding="0" border="0" width="100%">
    <tr>
    <td>
        <table cellspacing="0" cellpadding="0" border="0" width="100%">
        <tr>
        <td>
        <table class="tv" cellpadding="0" cellspacing="0" border="0">
        <tr>
        <!-- Pagination Area -->
        <td class="pr" colspan="100">
        <table id="PaginationRegion" cellspacing="0" cellpadding="0" border="0">
        <tr>
        <td><img src="../Images/paginationRowEdgeL.gif" alt=""/></td>
        
        <td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif"></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif"></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailAddButton" CausesValidation="False" CommandName="AddRecord" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailEditButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" RedirectURL="../MeasureRoleDetail/EditMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailSaveButton" CausesValidation="True" CommandName="UpdateData" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarSave.gif" onmouseout="this.src='../Images/ButtonBarSave.gif'" onmouseover="this.src='../Images/ButtonBarSaveOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailRefreshButton" CausesValidation="False" CommandName="ResetData" Consumers="Page" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailResetButton" CausesValidation="False" CommandName="ResetFilters" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;BS&quot;) %>" AlternateText="">

															</asp:ImageButton></td>
                <td class="prbbc"><img src="../Images/ButtonBarDividerR.gif"></td>
                <td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif"></td>
            
            <td class="pra">
            <BS:Pagination runat="server" id="MeasureRoleDetailPagination">
														</BS:Pagination>
            </td>
        <td><img src="../Images/paginationRowEdgeR.gif" alt=""/></td>
        </tr>
        </table>
        </td>
        </tr>
        <!--Table View Area -->
        <tr>
        <td class="tre">
            <table cellspacing="0" cellpadding="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)">
            <!-- This is the table's header row -->
            
            <div id="AJAXUpdateHeaderRow">
            <tr class="tch">
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th>
            <th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="MeasureRoleDetailToggleAll" onclick="toggleAllCheckboxes(this);">

															</asp:CheckBox></th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="MeasureIdLabel1" Text="Measure" CausesValidation="False">
															</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OrgRoleIdLabel1" Text="Organization Role" CausesValidation="False">
															</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="ActualLabel" Text="Actual" CausesValidation="False">
															</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="TargetLabel" Text="Target" CausesValidation="False">
															</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="MonthIdLabel" Text="Month" CausesValidation="False">
															</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="YearIdLabel" Text="Year" CausesValidation="False">
															</asp:LinkButton>
                </th>
            </tr>
            </div>
            
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="MeasureRoleDetailTableControlRepeater">
																<ITEMTEMPLATE>
																		<BS:MeasureRoleDetailTableControlRow runat="server" id="MeasureRoleDetailTableControlRow">
																				
            <div id="AJAXUpdateRecordRow">
            <tr><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRoleDetailRecordRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../MeasureRoleDetail/ShowMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRoleDetailRecordRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../MeasureRoleDetail/EditMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRoleDetailRecordRowDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureRoleDetailTableControlRow" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton></td>
                <td class="tic" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="MeasureRoleDetailRecordRowSelection">

																				</asp:CheckBox></td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="MeasureId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																				</asp:DropDownList>
																				<Selectors:FvLlsHyperLink runat="server" id="MeasureIdFvLlsHyperLink" ControlToUpdate="MeasureId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Measure" Field="Measure_.MeasureId" DisplayField="Measure_.MeasureName">																				</Selectors:FvLlsHyperLink>&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="MeasureIdRequiredFieldValidator" ControlToValidate="MeasureId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>
            <asp:ImageButton runat="server" id="MeasureIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="MeasureRoleDetailTableControl" ControlToUpdate="MeasureId" FieldValue="MeasureId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Measure/AddMeasurePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton>
            </td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="OrgRoleId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																				</asp:DropDownList>
																				<Selectors:FvLlsHyperLink runat="server" id="OrgRoleIdFvLlsHyperLink" ControlToUpdate="OrgRoleId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="OrgRole" Field="OrgRole_.OrgRoleId" DisplayField="OrgRole_.OrgRoleName">																				</Selectors:FvLlsHyperLink>&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="OrgRoleIdRequiredFieldValidator" ControlToValidate="OrgRoleId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Organization Role&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>
            
            </td>
            <td class="ttc" style="white-space:nowrap;"><table border="0" cellpadding="0" cellspacing="0">
																				<tr>
																				<td style="padding-right: 5px; vertical-align:top">
																				<asp:TextBox runat="server" id="Actual" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" CssClass="field_input" EnableIncrementDecrementButtons="True">
																				</asp:TextBox></td>
																				<td style="padding-right: 5px; white-space:nowrap;">
																				<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("Actual"),"NumberTextBox","","","") %>
																				&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="ActualRequiredFieldValidator" ControlToValidate="Actual" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Actual&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>&nbsp;
																				<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ActualTextBoxMaxLengthValidator" ControlToValidate="Actual" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Actual&quot;) %>">																				</BaseClasses:TextBoxMaxLengthValidator></td>
																				</tr>
																				</table>
																				
            </td>
            <td class="ttc" style="white-space:nowrap;"><table border="0" cellpadding="0" cellspacing="0">
																				<tr>
																				<td style="padding-right: 5px; vertical-align:top">
																				<asp:TextBox runat="server" id="Target" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" CssClass="field_input" EnableIncrementDecrementButtons="True">
																				</asp:TextBox></td>
																				<td style="padding-right: 5px; white-space:nowrap;">
																				<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("Target"),"NumberTextBox","","","") %>
																				&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="TargetRequiredFieldValidator" ControlToValidate="Target" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Target&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>&nbsp;
																				<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TargetTextBoxMaxLengthValidator" ControlToValidate="Target" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Target&quot;) %>">																				</BaseClasses:TextBoxMaxLengthValidator></td>
																				</tr>
																				</table>
																				
            </td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="MonthId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																				</asp:DropDownList>
																				<Selectors:FvLlsHyperLink runat="server" id="MonthIdFvLlsHyperLink" ControlToUpdate="MonthId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Month" Field="Month_.MonthId" DisplayField="Month_.MonthName">																				</Selectors:FvLlsHyperLink>&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="MonthIdRequiredFieldValidator" ControlToValidate="MonthId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Month&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>
            <asp:ImageButton runat="server" id="MonthIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="MeasureRoleDetailTableControl" ControlToUpdate="MonthId" FieldValue="MonthId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Month/AddMonthPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton>
            </td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="YearId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																				</asp:DropDownList>
																				<Selectors:FvLlsHyperLink runat="server" id="YearIdFvLlsHyperLink" ControlToUpdate="YearId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Year" Field="Year_.YearId" DisplayField="Year_.YearValue">																				</Selectors:FvLlsHyperLink>&nbsp;
																				<asp:RequiredFieldValidator runat="server" id="YearIdRequiredFieldValidator" ControlToValidate="YearId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Year&quot;) %>" Enabled="True" Text="*">																				</asp:RequiredFieldValidator>
            <asp:ImageButton runat="server" id="YearIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="MeasureRoleDetailTableControl" ControlToUpdate="YearId" FieldValue="YearId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Year/AddYearPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

																				</asp:ImageButton>
            </td>
            </tr>
            </div>
            
																		</BS:MeasureRoleDetailTableControlRow>
																</ITEMTEMPLATE>
														</asp:Repeater>
            <!-- Totals Area -->
                        
            </table>
        </td>
        </tr>
        </table>
        </td>
        </tr>
        </table>
    </td>
    </tr>
    </table>
    </td>
    </tr>
    </table>
    </td>
 </tr>
</table>
<!-- End Table Panel.html -->

											</BS:MeasureRoleDetailTableControl>

										</ContentTemplate>
									</asp:UpdatePanel>
								
<br/>

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
