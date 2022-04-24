<%@ Register Tagprefix="Selectors" Namespace="BS" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu_Item_HighlightedVertical.ascx.cs" Inherits="BS.UI.Menu_Item_HighlightedVertical" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="moTL"><img src="../Images/space.gif" height="8" width="6" alt=""/></td>
	<td class="moT"><img src="../Images/space.gif" height="8" width="4" alt=""/></td>
	<td class="moTR"><img src="../Images/space.gif" height="8" width="6" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="moL"><img src="../Images/space.gif" height="15" width="6" alt=""/></td>
	<td class="moC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" CssClass="menu">

</asp:LinkButton></td>
	<td class="moR"><img src="../Images/space.gif" height="15" width="6" alt=""/></td>
 </tr>
 <tr onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);">
	<td class="moBL"><img src="../Images/space.gif" height="8" width="6" alt=""/></td>
	<td class="moB"><img src="../Images/space.gif" height="8" width="4" alt=""/></td>
	<td class="moBR"><img src="../Images/space.gif" height="8" width="6" alt=""/></td>
 </tr>
