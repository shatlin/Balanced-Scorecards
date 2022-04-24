<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu_Item_Highlighted.ascx.cs" Inherits="BS.UI.Menu_Item_Highlighted" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<table cellpadding="0" cellspacing="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
 <tr>
	<td class="moTL"><img src="../Images/space.gif" height="8" width="1" alt=""/></td>
	<td class="moT"><img src="../Images/space.gif" height="8" width="4" alt=""/></td>
	<td class="moTR"><img src="../Images/space.gif" height="8" width="23" alt=""/></td>
 </tr>
 <tr>
	<td class="moL"><img src="../Images/space.gif" height="15" width="1" alt=""/></td>
	<td class="moC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" CssClass="menu">

</asp:LinkButton></td>
	<td class="moR"><img src="../Images/space.gif" height="15" width="23" alt=""/></td>
 </tr>
 <tr>
	<td class="moBL"><img src="../Images/space.gif" height="8" width="1" alt=""/></td>
	<td class="moB"><img src="../Images/space.gif" height="8" width="4" alt=""/></td>
	<td class="moBR"><img src="../Images/space.gif" height="8" width="23" alt=""/></td>
 </tr>
</table>
