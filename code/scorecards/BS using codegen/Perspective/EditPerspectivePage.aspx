<%@ Register Tagprefix="BS" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="BS" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BS" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Tagprefix="BS" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="BS" Namespace="BS.UI.Controls.EditPerspectivePage" %>

<%@ Register Tagprefix="BS" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="EditPerspectivePage.aspx.cs" Inherits="BS.UI.EditPerspectivePage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>EditPerspectivePage</title>
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
                        <BS:Menu runat="server" id="Menu" HiliteSettings="PerspectiveMenuItem">
		</BS:Menu>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr>
                        <td class="pContent">
                            <a name="StartOfPageContent"></a>
                <asp:UpdateProgress runat="server" id="PerspectiveRecordControlUpdateProgress" AssociatedUpdatePanelID="PerspectiveRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="PerspectiveRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<BS:PerspectiveRecordControl runat="server" id="PerspectiveRecordControl">
														
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
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="PerspectiveDialogTitle" Text="Edit Perspective">
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
        <asp:Literal runat="server" id="PerspectiveNameLabel" Text="Perspective Name">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:TextBox runat="server" id="PerspectiveName" Columns="50" MaxLength="50" CssClass="field_input" EnableIncrementDecrementButtons="True">
														</asp:TextBox>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="PerspectiveNameRequiredFieldValidator" ControlToValidate="PerspectiveName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Perspective Name&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>&nbsp;
														<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PerspectiveNameTextBoxMaxLengthValidator" ControlToValidate="PerspectiveName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Perspective Name&quot;) %>">														</BaseClasses:TextBoxMaxLengthValidator>
    
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

											</BS:PerspectiveRecordControl>
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
        <td class="fila"><asp:Literal runat="server" id="OrgRoleIdLabel" Text="Organization Role">
																						</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="OrgRoleIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
																						</asp:DropDownList></td>
    </tr>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="MeasureIdLabel" Text="Measure">
																						</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="MeasureIdFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
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
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureAddButton" CausesValidation="False" CommandName="AddRecord" Consumers="RoleMeasureTableControl" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureEditButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" RedirectURL="../RoleMeasure/EditRoleMeasurePage.aspx?RoleMeasure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;BS&quot;) %>" Consumers="RoleMeasureTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="RoleMeasureRefreshButton" CausesValidation="False" CommandName="ResetData" Consumers="Page" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;BS&quot;) %>" AlternateText="">

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
            <th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt=""/></th>
            <th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="RoleMeasureToggleAll" onclick="toggleAllCheckboxes(this);">

																						</asp:CheckBox></th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="OrgRoleIdLabel1" Text="Organization Role" CausesValidation="False">
																						</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="MeasureIdLabel1" Text="Measure" CausesValidation="False">
																						</asp:LinkButton>
                </th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="ObjectiveIdLabel" Text="Objective" CausesValidation="False">
																						</asp:LinkButton>
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

																											</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="RoleMeasureRecordRowDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;BS&quot;) %>" Consumers="RoleMeasureTableControlRow" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td>
                <td class="tic" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="RoleMeasureRecordRowSelection">

																											</asp:CheckBox></td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="OrgRoleId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																											</asp:DropDownList>
																											<Selectors:FvLlsHyperLink runat="server" id="OrgRoleIdFvLlsHyperLink" ControlToUpdate="OrgRoleId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="OrgRole" Field="OrgRole_.OrgRoleId" DisplayField="OrgRole_.OrgRoleName">																											</Selectors:FvLlsHyperLink>&nbsp;
																											<asp:RequiredFieldValidator runat="server" id="OrgRoleIdRequiredFieldValidator" ControlToValidate="OrgRoleId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Organization Role&quot;) %>" Enabled="True" Text="*">																											</asp:RequiredFieldValidator>
            
            </td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="MeasureId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																											</asp:DropDownList>
																											<Selectors:FvLlsHyperLink runat="server" id="MeasureIdFvLlsHyperLink" ControlToUpdate="MeasureId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Measure" Field="Measure_.MeasureId" DisplayField="Measure_.MeasureName">																											</Selectors:FvLlsHyperLink>&nbsp;
																											<asp:RequiredFieldValidator runat="server" id="MeasureIdRequiredFieldValidator" ControlToValidate="MeasureId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure&quot;) %>" Enabled="True" Text="*">																											</asp:RequiredFieldValidator>
            <asp:ImageButton runat="server" id="MeasureIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="RoleMeasureTableControl" ControlToUpdate="MeasureId" FieldValue="MeasureId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Measure/AddMeasurePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton>
            </td>
            <td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="ObjectiveId" CssClass="field_input" EnableIncrementDecrementButtons="True" onkeypress="dropDownListTypeAhead(this,false)">
																											</asp:DropDownList>
																											<Selectors:FvLlsHyperLink runat="server" id="ObjectiveIdFvLlsHyperLink" ControlToUpdate="ObjectiveId" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;BS&quot;) %>" MinListItems="100" Table="Objective" Field="Objective_.ObjectiveId" DisplayField="Objective_.ObjectiveName">																											</Selectors:FvLlsHyperLink>&nbsp;
																											<asp:RequiredFieldValidator runat="server" id="ObjectiveIdRequiredFieldValidator" ControlToValidate="ObjectiveId" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Objective&quot;) %>" Enabled="True" Text="*">																											</asp:RequiredFieldValidator>
            <asp:ImageButton runat="server" id="ObjectiveIdAddRecordLink" CausesValidation="False" CommandName="Redirect" Consumers="RoleMeasureTableControl" ControlToUpdate="ObjectiveId" FieldValue="ObjectiveId" ImageURL="../Images/iconNewFlat.gif" RedirectURL="../Objective/AddObjectivePage.aspx" ToolTip="&lt;%# GetResourceValue(&quot;Btn:New&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton>
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
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td><BS:ThemeButton runat="server" id="SaveButton" Button-CausesValidation="True" Button-CommandName="UpdateData" Button-RedirectURL="Back" Button-Text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;BS&quot;) %>">
																</BS:ThemeButton></td>
    <td><img src="../Images/space.gif" height="6" width="3" alt=""/></td>
    <td></td>
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
