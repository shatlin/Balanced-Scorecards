<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="ViewIS.aspx.cs" Inherits="Setup_ViewIS" Title="Untitled Page" %>
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
                                            View Integrated Scorecard</h3>
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
                                        </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                        &nbsp;<table  	style="border-width:0px;background-color:#d3e6f5;text-align:center;font-size:9px;font-family: Calibri;">
                                            <tr class="SimpleBlueTableHeadRow">
                                                <td valign="top" class="SimpleBlueTableHeadCell" colspan=9 style="width: 1010px; text-align: left;">
                                                    Integrated Scorecard
                                                    </td>
                                               
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                </td>
                                                <td>
                                                    <a href="javascript:expandcollapse('div1', 'one');">
                                                        <img id="imgdiv1" alt="Click to show/hide" border="0" src="plus.gif" /><span style="color: #0000ff;
                                                            text-decoration: underline">Competency Scorecard</span></a></td>
                                                <td >
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td colspan="8">
                                                    <div id="div1" style="display: none; overflow: auto; width: 100%; position: relative; text-align: right;">
                                                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ScorecardDetailId" DataSourceID="ObjectDataSource1">
                                                            <Columns>
                                                                <asp:BoundField DataField="ScorecardDetailId" HeaderText="ScorecardDetailId" InsertVisible="False"
                                                                    ReadOnly="True" SortExpression="ScorecardDetailId" Visible="false" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureClusterName" HeaderText="MeasureClusterName" SortExpression="MeasureClusterName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureGroupName" HeaderText="MeasureGroupName" SortExpression="MeasureGroupName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureName" HeaderText="MeasureName" SortExpression="MeasureName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="actual" HeaderText="actual" SortExpression="actual" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="Target" HeaderText="Target" SortExpression="Target" />
                                                            </Columns>
                                                        </asp:GridView>
                                                        &nbsp;
                                                        
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                </td>
                                                <td>
                                                    <a href="javascript:expandcollapse('div2', 'two');">
                                                        <img id="imgdiv2" alt="Click to show/hide" border="0" src="plus.gif"  /><span
                                                            style="color: #0000ff; text-decoration: underline">Integerated Scoreacard </span></a>
                                                </td>
                                                <td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td colspan="100">
                                                    <div id="div2" style="display: none; overflow: auto; width: 100%; position: relative; text-align: right;">
                                                    
                                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ScorecardDetailId" DataSourceID="ObjectDataSource2">
                                                            <Columns>
                                                                <asp:BoundField DataField="ScorecardDetailId" HeaderText="ScorecardDetailId" InsertVisible="False"
                                                                    ReadOnly="True" SortExpression="ScorecardDetailId" Visible="false" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureClusterName" HeaderText="MeasureClusterName" SortExpression="MeasureClusterName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureGroupName" HeaderText="MeasureGroupName" SortExpression="MeasureGroupName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="MeasureName" HeaderText="MeasureName" SortExpression="MeasureName" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="actual" HeaderText="actual" SortExpression="actual" />
                                                                <asp:BoundField ItemStyle-Width="200px" DataField="Target" HeaderText="Target" SortExpression="Target" />
                                                            </Columns>
                                                        </asp:GridView>
                                                        &nbsp;
                                                    </div>
                                                </td>
                                            </tr>
                                            
                                           
                                        </table>
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px">
                                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCASScorecardForUser" TypeName="Business.Setup.CreateScorecardBL">
                                                            <SelectParameters>
                                                                <asp:SessionParameter DefaultValue="0" Name="iAppUserId" SessionField="UserId" Type="Int32" />
                                                            </SelectParameters>
                                                        </asp:ObjectDataSource>
                                                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetBSScorecardForUser" TypeName="Business.Setup.CreateScorecardBL">
                                                            <SelectParameters>
                                                                <asp:SessionParameter DefaultValue="0" Name="iAppUserId" SessionField="UserId" Type="Int32" />
                                                            </SelectParameters>
                                                        </asp:ObjectDataSource>
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

