<%@ Register Tagprefix="BS" TagName="Footer" Src="../Header and Footer/Footer.ascx" %>

<%@ Register Tagprefix="BS" TagName="Menu" Src="../Menu Panels/Menu.ascx" %>

<%@ Register Tagprefix="BS" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" CodeFile="EditMeasureTypePage.aspx.cs" Inherits="BS.UI.EditMeasureTypePage" %>
<%@ Register Tagprefix="BS" TagName="Header" Src="../Header and Footer/Header.ascx" %>

<%@ Register Tagprefix="BS" Namespace="BS.UI.Controls.EditMeasureTypePage" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Tagprefix="BS" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>EditMeasureTypePage</title>
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
                        <BS:Menu runat="server" id="Menu" HiliteSettings="MeasureTypeMenuItem">
		</BS:Menu>
                    </td>
                    </tr>
                    <tr>
                    <td>
                        <table cellspacing="0" cellpadding="0" border="0" width="100%">
                        <tr>
                        <td class="pContent">
                            <a name="StartOfPageContent"></a>
                <asp:UpdateProgress runat="server" id="MeasureTypeRecordControlUpdateProgress" AssociatedUpdatePanelID="MeasureTypeRecordControlUpdatePanel">
										<ProgressTemplate>
											<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
											</div>
											<div style=" position:absolute; padding:30px;">
												<img src="../Images/updating.gif">
											</div>
										</ProgressTemplate>
									</asp:UpdateProgress>
									<asp:UpdatePanel runat="server" id="MeasureTypeRecordControlUpdatePanel" UpdateMode="Conditional">

										<ContentTemplate>
											<BS:MeasureTypeRecordControl runat="server" id="MeasureTypeRecordControl">
														
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
    <td class="dhtr" valign="middle"><asp:Literal runat="server" id="MeasureTypeDialogTitle" Text="Edit Measure Type">
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
        <asp:Literal runat="server" id="MeasureTypenameLabel" Text="Measure Typename">
														</asp:Literal>
    </td>
    <td class="dialog_field_value">
        <asp:TextBox runat="server" id="MeasureTypename" Columns="50" MaxLength="50" CssClass="field_input" EnableIncrementDecrementButtons="True">
														</asp:TextBox>&nbsp;
														<asp:RequiredFieldValidator runat="server" id="MeasureTypenameRequiredFieldValidator" ControlToValidate="MeasureTypename" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure Typename&quot;) %>" Enabled="True" Text="*">														</asp:RequiredFieldValidator>&nbsp;
														<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MeasureTypenameTextBoxMaxLengthValidator" ControlToValidate="MeasureTypename" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure Typename&quot;) %>">														</BaseClasses:TextBoxMaxLengthValidator>
    
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

											</BS:MeasureTypeRecordControl>
											</ContentTemplate>
										</asp:UpdatePanel>
									
<br/>
                            <asp:UpdateProgress runat="server" id="MeasureTableControlUpdateProgress" AssociatedUpdatePanelID="MeasureTableControlUpdatePanel">
																	<ProgressTemplate>
																		<div style="position:absolute;   width:100%;height:1000px;background-color:#000000;filter:alpha(opacity=10);opacity:0.20;-moz-opacity:0.20;padding:20px;">
																		</div>
																		<div style=" position:absolute; padding:30px;">
																			<img src="../Images/updating.gif">
																		</div>
																	</ProgressTemplate>
																</asp:UpdateProgress>
																<asp:UpdatePanel runat="server" id="MeasureTableControlUpdatePanel" UpdateMode="Conditional">

																	<ContentTemplate>
																		<BS:MeasureTableControl runat="server" id="MeasureTableControl">
																					
<!-- Begin Table Panel.html -->

<table class="dv" cellpadding="0" cellspacing="0" border="0">
	<tr>
	<td class="dh">
	<table cellpadding="0" cellspacing="0" width="100%" border="0">
	<tr>
	<td class="dhel"><img src="../Images/space.gif" alt=""/></td>
	<td class="dheci" valign="middle"><a onclick="toggleRegions(this);"><img id="ToggleRegionIcon" src="../Images/ToggleHideFilters.gif" border="0" alt="Hide Filters"/></a></td>
	<td class="dht" valign="middle"><asp:Literal runat="server" id="MeasureTableTitle" Text="Measure">
																					</asp:Literal></td>
	<td class="dhtrc">
		<table id="CollapsibleRegionTotalRecords" style="display:none;" cellspacing="0" cellpadding="0" border="0">
		<tr>
		<td class="dhtrct"><%# GetResourceValue("Txt:TotalItems", "BS") %>&nbsp;<asp:Label runat="server" id="MeasureTotalItems">
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
        <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("MeasureTableControl$MeasureSearchButton")) %>
        
        <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("MeasureTableControl$MeasureSearchButton")) %>
        </td>
        <td class="filbc"></td>
    </tr>
    
    
    <tr>
    <td></td>
    <td></td>
    <td rowspan="100" class="filbc"></td> 
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControl("MeasureTableControl$MeasureFilterButton")) %>
    <tr>
        <td class="fila"><asp:Literal runat="server" id="MeasureNameLabel" Text="Measure Name">
																						</asp:Literal></td>
        <td><asp:DropDownList runat="server" id="MeasureNameFilter" CssClass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" AutoPostBack="True">
																						</asp:DropDownList></td>
    </tr>
    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControl("MeasureTableControl$MeasureFilterButton")) %>
    
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
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureAddButton" CausesValidation="False" CommandName="AddRecord" Consumers="MeasureTableControl" ImageURL="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureEditButton" CausesValidation="False" CommandName="Redirect" Consumers="Page" ImageURL="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" RedirectURL="../Measure/EditMeasurePage.aspx?Measure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureTableControl" ImageURL="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureRefreshButton" CausesValidation="False" CommandName="ResetData" Consumers="Page" ImageURL="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
            <td class="prbbc"><asp:ImageButton runat="server" id="MeasureResetButton" CausesValidation="False" CommandName="ResetFilters" Consumers="MeasureTableControl" ImageURL="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" ToolTip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;BS&quot;) %>" AlternateText="">

																						</asp:ImageButton></td>
                <td class="prbbc"><img src="../Images/ButtonBarDividerR.gif"></td>
                <td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif"></td>
            
            <td class="pra">
            <BS:Pagination runat="server" id="MeasurePagination">
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
            <th class="thc" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="MeasureToggleAll" onclick="toggleAllCheckboxes(this);">

																						</asp:CheckBox></th>
            
            <th class="thc" scope="col"><asp:LinkButton runat="server" id="MeasureNameLabel1" Text="Measure Name" CausesValidation="False">
																						</asp:LinkButton>
                </th>
            </tr>
            </div>
            
            <!-- Table Rows -->
            <asp:Repeater runat="server" id="MeasureTableControlRepeater">
																							<ITEMTEMPLATE>
																									<BS:MeasureTableControlRow runat="server" id="MeasureTableControlRow">
																											
            <div id="AJAXUpdateRecordRow">
            <tr><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRecordRowViewButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_view.gif" RedirectURL="../Measure/ShowMeasurePage.aspx?Measure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRecordRowEditButton" CausesValidation="False" CommandName="Redirect" CssClass="button_link" ImageURL="../Images/icon_edit.gif" RedirectURL="../Measure/EditMeasurePage.aspx?Measure={PK}" ToolTip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td><td class="tic" scope="row"><asp:ImageButton runat="server" id="MeasureRecordRowDeleteButton" CausesValidation="False" CommandArgument="DeleteOnUpdate" CommandName="DeleteRecord" ConfirmMessage="&lt;%# GetResourceValue(&quot;DeleteRecordConfirm&quot;, &quot;BS&quot;) %>" Consumers="MeasureTableControlRow" ImageURL="../Images/icon_delete.gif" ToolTip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;BS&quot;) %>" AlternateText="">

																											</asp:ImageButton></td>
                <td class="tic" onclick="moveToThisTableRow(this);"><asp:CheckBox runat="server" id="MeasureRecordRowSelection">

																											</asp:CheckBox></td>
            <td class="ttc" style="white-space:nowrap;"><asp:TextBox runat="server" id="MeasureName" MaxLength="50" Columns="60" CssClass="field_input" EnableIncrementDecrementButtons="True" Rows="6" TextMode="MultiLine">
																											</asp:TextBox>&nbsp;
																											<asp:RequiredFieldValidator runat="server" id="MeasureNameRequiredFieldValidator" ControlToValidate="MeasureName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure Name&quot;) %>" Enabled="True" Text="*">																											</asp:RequiredFieldValidator>&nbsp;
																											<BaseClasses:TextBoxMaxLengthValidator runat="server" id="MeasureNameTextBoxMaxLengthValidator" ControlToValidate="MeasureName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;BS&quot;).Replace(&quot;{FieldName}&quot;, &quot;Measure Name&quot;) %>">																											</BaseClasses:TextBoxMaxLengthValidator>
            </td>
            </tr>
            </div>
            
																									</BS:MeasureTableControlRow>
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

																		</BS:MeasureTableControl>

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
