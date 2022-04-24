<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="GlobalParameters.aspx.cs" Inherits="Setup_GlobalParameters" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager id="Scm" runat="server">
</asp:ScriptManager>


           <table width="100%" height="100%" style="vertical-align: top" border="0" cellpadding="0"
        cellspacing="0" background="../images/topnavbg.jpg">

        <tr>
            <td valign="top" bgcolor="#FFFFFF" style="width: 1034px">
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>


      <td background="../images/navbasebg.jpg" height="29">
                                       
                        </td>
           
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
                                            Manage Global Parameters</h3>
                                        <h4>
                                            <asp:Label ID="lblPageInfo" runat="server"></asp:Label></h4>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                    </td>
                                    <td valign="top" align="center">
                                       <h1>
                                       
                 <asp:GridView id="grdVwGlobalParemeter" runat="server" Width="835px" OnSelectedIndexChanged="grdVwGlobalParemeter_SelectedIndexChanged" AutoGenerateColumns="false" DataKeyNames="GlobalParameterId">
                <HeaderStyle   CssClass="SimpleBlueTableHeadRow" />
                <SelectedRowStyle CssClass="SimpleBlueTableRow" />
                 
                 <Columns>
                
                 <asp:BoundField DataField="GlobalParameterId" Visible="False" />
                 <asp:BoundField DataField="GlobalParameterName" HeaderText=" Parameter Name" />
             <asp:CommandField ButtonType="Button" ShowSelectButton="True"  HeaderText="Select Parameter"  SelectText="View Values" /> 
                 </Columns>
                  </asp:GridView> 
                  </h1>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                   <h1 style="text-align: center">
                                   
                 <asp:GridView id="grdVwGlobalParemeterDetails" runat="server" Width="845px" OnSelectedIndexChanged="grdVwGlobalParemeterDetails_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="GlobalParameterDetailId">
                                 <HeaderStyle CssClass="SimpleBlueTableHeadRow" />
                 <SelectedRowStyle CssClass="SimpleBlueTableRow" />
                    <Columns>
                    
                            <asp:BoundField DataField="GlobalParameterValue" HeaderText=" Parameter Value" >
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Example" HeaderText=" Example" >
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="IsSelected" HeaderText=" Default Value?" >
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:CommandField ButtonType="Button" ShowSelectButton="True"  HeaderText="Select Default Parameter"  SelectText="Set as Default" >
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:CommandField> 
                 </Columns>
    </asp:GridView> 
</h1>
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr><td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px">
                                       <h1 style="text-align: center"></h1></td>
                                    <td>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                        <h1 style="text-align: center"></h1></td>
                                    <td valign="top">
                                    </td>
                                </tr>
                            </table>
                            <p>
                            </p>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="250" rowspan="2"  align=center valign=middle>
                <span style="color: #ffffff"><h1></h1></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
    
    
</asp:Content>

