<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BS" TagName="Menu_Item_Highlighted" Src="../Shared/Menu_Item_Highlighted.ascx" %>

<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu.ascx.cs" Inherits="BS.UI.Menu" %>
<%@ Register Tagprefix="BS" TagName="Menu_Item" Src="../Shared/Menu_Item.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>

<table cellspacing="0" cellpadding="0" border="0" width="100%">
 <tr>
	<td class="menus">
	<table cellpadding="0" cellspacing="0" border="0">
	<tr>
	<td><img src="../Images/menuEdgeL.gif" alt=""/></td>
	
	<td>
	<BS:Menu_Item runat="server" id="_MeasureMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Measure/ShowMeasureTablePage.aspx" Button-Text="Measure">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_MeasureMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Measure/ShowMeasureTablePage.aspx" Button-Text="Measure" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_MeasureRoleDetailMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../MeasureRoleDetail/ShowMeasureRoleDetailTablePage.aspx" Button-Text="Measure Role Detail">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_MeasureRoleDetailMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../MeasureRoleDetail/ShowMeasureRoleDetailTablePage.aspx" Button-Text="Measure Role Detail" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_MeasureTypeMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../MeasureType/ShowMeasureTypeTablePage.aspx" Button-Text="Measure Type">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_MeasureTypeMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../MeasureType/ShowMeasureTypeTablePage.aspx" Button-Text="Measure Type" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_MonthMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Month/ShowMonthTablePage.aspx" Button-Text="Month">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_MonthMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Month/ShowMonthTablePage.aspx" Button-Text="Month" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_ObjectiveMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Objective/ShowObjectiveTablePage.aspx" Button-Text="Objective">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_ObjectiveMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Objective/ShowObjectiveTablePage.aspx" Button-Text="Objective" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_PerspectiveMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Perspective/ShowPerspectiveTablePage.aspx" Button-Text="Perspective">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_PerspectiveMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Perspective/ShowPerspectiveTablePage.aspx" Button-Text="Perspective" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_RoleMeasureMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../RoleMeasure/ShowRoleMeasureTablePage.aspx" Button-Text="Role Measure">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_RoleMeasureMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../RoleMeasure/ShowRoleMeasureTablePage.aspx" Button-Text="Role Measure" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td>
	<BS:Menu_Item runat="server" id="_YearMenuItem" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Year/ShowYearTablePage.aspx" Button-Text="Year">
</BS:Menu_Item>
	<BS:Menu_Item_Highlighted runat="server" id="_YearMenuItemHilited" Button-CausesValidation="False" Button-CommandName="Redirect" Button-RedirectURL="../Year/ShowYearTablePage.aspx" Button-Text="Year" Visible="False">
</BS:Menu_Item_Highlighted>
	</td>
	
	<td><img src="../Images/menuEdgeR.gif" alt=""/></td>
	</tr>
	</table>
	</td>
 </tr>
 <tr>
	<td class="mbbg"><img src="../Images/space.gif" height="1" width="1" alt=""/></td>
 </tr>
</table>
