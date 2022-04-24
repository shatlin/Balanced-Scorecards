<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="RoleCompetency.aspx.cs" Inherits="CAS_RoleCompetency" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="100%" height="100%" style="vertical-align: top" border="0" cellpadding="0"
        cellspacing="0" background="../images/topnavbg.jpg">
        <tr>
            <td colspan="2" background="../images/basebg2.jpg" style="height: 9px">
                <img src="../images/basebg2.jpg" width="1" height="9"></td>
        </tr>
        <tr>
            <td valign="top" bgcolor="#FFFFFF" style="width: 1034px">
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td height="29" colspan="1" background="../images/navbasebg.jpg">
                            <img src="../images/navbasebg.jpg" width="1" height="29"></td>
                    </tr>
                    <tr>
                        <td>
                            <table style="width: 100%;">
                                <tr>
                                    <td>
                                        <p>
                                        </p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                </tr>
                            </table>
                            <table width="100%" border="0" cellspacing="0" cellpadding="5">
                                <tr>
                                    <td valign="top">
                                    </td>
                                    <td class="PageInfoTableBod" valign="top" colspan="3">
                                        <h3>
                                            Page Header</h3>
                                        <h4>
                                            <asp:Label ID="lblPageInfo" runat="server"></asp:Label></h4>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                    </td>
                                    <td valign="top" align="left" style="width: 11px" rowspan="4">
                                        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" >
                                            <ParentNodeStyle Font-Bold="False" />
                                            
                                            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px"
                                                VerticalPadding="0px" />
                                            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px"
                                                NodeSpacing="0px" VerticalPadding="0px" />
                                            <RootNodeStyle Font-Bold="True" />
                                        </asp:TreeView>
                                    </td>
                                    <td align="center" valign="top">
                                    </td>
                                    <td align="left" rowspan="4" valign="top">
                                        <asp:TreeView ID="TreeView2"  runat="server" ImageSet="Arrows" >
                                            <ParentNodeStyle Font-Bold="False" />
                                            
                                            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px"
                                                VerticalPadding="0px" />
                                            <RootNodeStyle Font-Bold="True" />
                                            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px"
                                                NodeSpacing="0px" VerticalPadding="0px" />
                                        </asp:TreeView>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td style="width: 1010px; text-align: center;" valign="top">
                                        <asp:Button ID="Button1" runat="server" Text="<< Add Competency To Role" Width="262px" Enabled="False"  /></td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px; text-align: center;">
                                        <asp:Button ID="Button2" runat="server" Text="Remove Competency From Role   >>" Enabled="False" /></td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td style="width: 1010px" valign="top">
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                            </table>
                            <p>
                                &nbsp;</p>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="250" rowspan="2"  align=center valign=middle>
                <span style="color: #ffffff"><h1>
                    &nbsp;</h1></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
</asp:Content>

