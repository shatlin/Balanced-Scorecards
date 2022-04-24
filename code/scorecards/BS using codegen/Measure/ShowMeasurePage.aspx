﻿<%@ Register Tagprefix="BS" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="BS" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BS" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="ShowMeasurePage.aspx.cs" Inherits="BS.UI.ShowMeasurePage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BS" Namespace="BS.UI.Controls.ShowMeasurePage" %>

<%@ Register Tagprefix="BS" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Tagprefix="BS" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>ShowMeasurePage</title>
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
                        <BS:Menu runat="server" id="Menu" HiliteSettings="MeasureMenuItem">
		</BS:Menu>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr>
                        <td class="pContent">
                            <a name="StartOfPageContent"></a><asp:UpdateProgress runat="server" id="MeasureRecordControlUpdateProgress" AssociatedUpdatePanelID="MeasureRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="MeasureRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<BS:MeasureRecordControl runat="server" id="MeasureRecordControl">
														
<!-- Begin Record Panel.html -->

<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("SaveButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("CancelButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("OKButton$_Button")) %>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("EditButton$_Button")) %>
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
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="MeasureDialogTitle" Text="Show Measure">
														</asp:Literal></td>
    <td class="dhir"><asp:ImageButton runat="server" id="MeasureDialogEditButton" CausesValidation="False" CommandName="Redirect" Consumers="page" ImageURL="../Images/iconEdit.gif" RedirectURL="../Measure/EditMeasurePage.aspx?Measure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

														</asp:ImageButton></td>
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
        <asp:Literal runat="server" id="MeasureNameLabel" Text="Measure Name">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:Literal runat="server" id="MeasureName">
														</asp:Literal>
    
    </td>
    </tr>
    <tr>
    <td class="field_label_on_side">
        <asp:Literal runat="server" id="MeasureTypeIdLabel" Text="Measure Type">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:LinkButton runat="server" id="MeasureTypeId" CausesValidation="False" CommandName="Redirect" RedirectURL="../MeasureType/ShowMeasureTypePage.aspx?MeasureType={MeasureRecordControl:FK:FK_Measure_MeasureType}">
														</asp:LinkButton>
    
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
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("EditButton$_Button")) %>
<!-- End Record Panel.html -->

											</BS:MeasureRecordControl>
											</ContentTemplate>
										</asp:UpdatePanel>
									
<br/>
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
        <td class="fila"><asp:Literal runat="server" id="OrgRoleIdLabel" Text="Organization Role">
																						</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="OrgRoleIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
																						</asp:DropDownList></td>
    </tr>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="MonthIdLabel" Text="Month">
																						</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="MonthIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
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
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailNewButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../MeasureRoleDetail/AddMeasureRoleDetailPage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailEditButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" RedirectURL="../MeasureRoleDetail/EditMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailCopyButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarCopy.gif" onmouseout="this.src='../Images/ButtonBarCopy.gif'" onmouseover="this.src='../Images/ButtonBarCopyOver.gif'" RedirectURL="../MeasureRoleDetail/AddMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Copy&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRoleDetailRefreshButton" CausesValidation="False" CommandName="ResetData" Consumers="MeasureRoleDetailTableControl" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;BS&quot;) %>" AlternateText="">

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
            <th class="thc" colspan="4"><img src="../Images/space.gif" height="1" width="1" alt=""/></th>
            <th class="thc" style="padding:0px;vertical-align:middle;">
                    <asp:CheckBox runat="server" id="MeasureRoleDetailToggleAll" onclick="toggleAllCheckboxes(this);">

																						</asp:CheckBox></th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="OrgRoleIdLabel1" Text="Organization Role">
																						</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="ActualLabel" Text="Actual">
																						</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="TargetLabel" Text="Target">
																						</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="MonthIdLabel1" Text="Month">
																						</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="YearIdLabel" Text="Year">
																						</asp:Literal>
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

																											</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRoleDetailRecordRowCopyButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_copy.gif" RedirectURL="../MeasureRoleDetail/AddMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:CopyRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRoleDetailRecordRowDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureRoleDetailTableControlRow" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td><td class="tic" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="MeasureRoleDetailRecordRowSelection">

																											</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="OrgRoleId">
																											</asp:Literal>
            </td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="Actual">
																											</asp:Literal>
            </td>
            <td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="Target">
																											</asp:Literal>
            </td>
            <td class="ttc" ><asp:LinkButton runat="server" id="MonthId" CausesValidation="False" CommandName="Redirect" RedirectURL="../Month/ShowMonthPage.aspx?Month={MeasureRoleDetailTableControlRow:FK:FK_MeasureAppUserDetail_Month}">
																											</asp:LinkButton>
            </td>
            <td class="ttc" ><asp:LinkButton runat="server" id="YearId" CausesValidation="False" CommandName="Redirect" RedirectURL="../Year/ShowYearPage.aspx?Year={MeasureRoleDetailTableControlRow:FK:FK_MeasureAppUserDetail_Year1}">
																											</asp:LinkButton>
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

                            <asp:UpdateProgress runat="server" id="RoleMeasureTableControlUpdateProgress" AssociatedUpdatePanelID="RoleMeasureTableControlUpdatePanel">
																							<ProgressTemplate>
																								<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
																								</div>
																								<div style=" position:absolute; padding:30px;">
																									<img src="../Images/updating.gif">
																								</div>
																							</ProgressTemplate>
																						</asp:UpdateProgress>
																						<asp:UpdatePanel runat="server" id="RoleMeasureTableControlUpdatePanel" UpdateMode="Conditional">

																							<ContentTemplate>
																								<BS:RoleMeasureTableControl runat="server" id="RoleMeasureTableControl">
																											
<!-- Begin Table Panel.html -->

<table class="dv" cellpadding="0" cellspacing="0" border="0">
	<tr>
	<td class="dh">
	<table cellpadding="0" cellspacing="0" width="100%" border="0">
	<tr>
	<td class="dhel"><img src="../Images/space.gif" alt=""/></td>
	<td class="dheci" valign="middle"><a onclick="toggleRegions(this);"><img id="ToggleRegionIcon" src="../Images/ToggleHideFilters.gif" border="0" alt="Hide Filters"/></a></td>
	<td class="dht" valign="middle"><asp:Literal runat="server" id="RoleMeasureTableTitle" Text="Role Measure">
																											</asp:Literal></td>
	<td class="dhtrc">
		<table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
		<tr>
		<td class="dhtrct"><%# GetResourceValue("Txt:TotalItems", "BS") %>&nbsp;<asp:Label runat="server" id="RoleMeasureTotalItems">
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
        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("RoleMeasureTableControl$RoleMeasureSearchButton")) %>
        
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("RoleMeasureTableControl$RoleMeasureSearchButton")) %>
        </td>
        <td class="filbc"></td>
    </tr>
    
    
    <tr>
    <td></td>
    <td></td>
    <td rowspan="100" class="filbc"></td> 
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("RoleMeasureTableControl$RoleMeasureFilterButton")) %>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="OrgRoleIdLabel2" Text="Organization Role">
																												</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="OrgRoleIdFilter1" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
																												</asp:DropDownList></td>
    </tr>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="ObjectiveIdLabel" Text="Objective">
																												</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="ObjectiveIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
																												</asp:DropDownList></td>
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("RoleMeasureTableControl$RoleMeasureFilterButton")) %>
    
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
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureNewButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" RedirectURL="../RoleMeasure/AddRoleMeasurePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureEditButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" RedirectURL="../RoleMeasure/EditRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureCopyButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarCopy.gif" onmouseout="this.src='../Images/ButtonBarCopy.gif'" onmouseover="this.src='../Images/ButtonBarCopyOver.gif'" RedirectURL="../RoleMeasure/AddRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Copy&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;BS&quot;) %>" Consumers="RoleMeasureTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureRefreshButton" CausesValidation="False" CommandName="ResetData" Consumers="RoleMeasureTableControl" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureResetButton" CausesValidation="False" CommandName="ResetFilters" Consumers="RoleMeasureTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;BS&quot;) %>" AlternateText="">

																												</asp:ImageButton></td>
                <td class="prbbc"><img src="../Images/ButtonBarDividerR.gif"></td>
                <td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif"></td>
            
            <td class="pra">
            <BS:Pagination runat="server" id="RoleMeasurePagination">
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
            <th class="thc" colspan="4"><img src="../Images/space.gif" height="1" width="1" alt=""/></th>
            <th class="thc" style="padding:0px;vertical-align:middle;">
                    <asp:CheckBox runat="server" id="RoleMeasureToggleAll" onclick="toggleAllCheckboxes(this);">

																												</asp:CheckBox></th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="OrgRoleIdLabel3" Text="Organization Role">
																												</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="ObjectiveIdLabel1" Text="Objective">
																												</asp:Literal>
                </th>
            
            <th class="thc" scope="col"><asp:Literal runat="server" id="PerspectiveidLabel" Text="Perspectiveid">
																												</asp:Literal>
                </th>
            </tr>
            </div>
            
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="RoleMeasureTableControlRepeater">
																													<ITEMTEMPLATE>
																															<BS:RoleMeasureTableControlRow runat="server" id="RoleMeasureTableControlRow">
																																	
            <div id="AJAXUpdateRecordRow">
            <tr><td class="tic" scope="row"><asp:ImageButton runat="server" id="RoleMeasureRecordRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../RoleMeasure/ShowRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																																	</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="RoleMeasureRecordRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../RoleMeasure/EditRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																																	</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="RoleMeasureRecordRowCopyButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_copy.gif" RedirectURL="../RoleMeasure/AddRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:CopyRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																																	</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="RoleMeasureRecordRowDeleteButton" CausesValidation="False" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;BS&quot;) %>" Consumers="RoleMeasureTableControlRow" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																																	</asp:ImageButton></td><td class="tic" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="RoleMeasureRecordRowSelection">

																																	</asp:CheckBox></td>
            <td class="ttc" ><asp:Literal runat="server" id="OrgRoleId1">
																																	</asp:Literal>
            </td>
            <td class="ttc" ><asp:LinkButton runat="server" id="ObjectiveId" CausesValidation="False" CommandName="Redirect" RedirectURL="../Objective/ShowObjectivePage.aspx?Objective={RoleMeasureTableControlRow:FK:FK_RoleMeasure_Objective}">
																																	</asp:LinkButton>
            </td>
            <td class="ttc" ><asp:LinkButton runat="server" id="Perspectiveid" CausesValidation="False" CommandName="Redirect" RedirectURL="../Perspective/ShowPerspectivePage.aspx?Perspective={RoleMeasureTableControlRow:FK:FK_RoleMeasure_Perspective}">
																																	</asp:LinkButton>
            </td>
            </tr>
            </div>
            
																															</BS:RoleMeasureTableControlRow>
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

																								</BS:RoleMeasureTableControl>

																							</ContentTemplate>
																						</asp:UpdatePanel>
																					
<br/>

    <table cellpadding="0" cellspacing="0" border="0" id="Table1">
    <tr>
    <td class="recordPanelButtonsAlignment">
    <table cellpadding="0" cellspacing="0" border="0">
    <tr>
    <td><BS:ThemeButton runat="server" id="OKButton" Button-CausesValidation="False" Button-RedirectURL="Back" Button-Text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;BS&quot;) %>">
																						</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td><BS:ThemeButton runat="server" id="EditButton" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Measure/EditMeasurePage.aspx?Measure={PK}" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>">
																						</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
	<td></td>
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
