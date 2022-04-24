<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="CreateScorecard.aspx.cs" Inherits="Setup_CreateScorecard" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <script language="javascript" type="text/javascript">
    function expandcollapse(obj,row)
    {
        var div = document.getElementById(obj);
        var img = document.getElementById('img' + obj);
        
        if (div.style.display == "none")
        {
            div.style.display = "block";
            if (row == 'alt')
            {
                img.src = "minus.gif";
            }
            else
            {
                img.src = "minus.gif";
            }
            img.alt = "Close";
        }
        else
        {
            div.style.display = "none";
            if (row == 'alt')
            {
                img.src = "plus.gif";
            }
            else
            {
                img.src = "plus.gif";
            }
            img.alt = "Expand to view Details";
        }
    } 
    </script>

<table width="100%" height="100%" style="vertical-align: top" border="0" cellpadding="0"
        cellspacing="0" background="../images/topnavbg.jpg">
        <tr>
            <td colspan="2" background="../images/basebg2.jpg" style="height: 9px">
                <img src="../images/basebg2.jpg" width="1" height="9"></td>
        </tr>
        <tr>
            <td valign="top" bgcolor="#FFFFFF" style="width: 1307px">
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
                                    <td class="PageInfoTableBod" valign="top">
                                        <h3>
                                            Create Integrated Scorecard</h3>
                                        <h4>
                                            <asp:Label ID="lblPageInfo" runat="server"></asp:Label>
                                            </h4>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                    </td>
                                    <td valign="top" align="center">
                                        <asp:Button ID="btnCreateSC" runat="server" Text="Create integrated Scorecard for all Users"
                                            Width="306px" OnClick="btnCreateSC_Click" /></td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                        &nbsp;</td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px">
                                        &nbsp;
                                       </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                        </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                            </table>
                            <p>
                                &nbsp;&nbsp;
                            </p>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="250" rowspan="2"  align=center valign=middle>
                <span style="color: #ffffff"></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1307px; height: 13px;">
                </td>
        </tr>
    </table>
</asp:Content>

