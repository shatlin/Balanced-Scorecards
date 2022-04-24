<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Setup_Login" Title="Login" %>
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
                                    <td class="PageInfoTableBod" valign="top">
                                        <h3>
                                            Login</h3>
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
                                      
             
             
             
                   
                   <table border="0" cellpadding="0" cellspacing="0" class="SimpleBlueTable" style="width: 510px">
                       <tr class="SimpleBlueTableHeadRow">
                           <td colspan="5">
                               </td>
                       </tr>
                       <tr>
                           <td colspan="5" style="height: 10px">
                               &nbsp;
                           </td>
                       </tr>
                       <tr >
                           <td colspan="5" style="height: 10px">
                               &nbsp;
                           </td>
                       </tr>
                       <tr>
                           <td style="width: 50px; height: 24px;" align="left">
                           </td>
                           <td style="width: 100px; text-align: right; height: 24px;" align="left">
                               &nbsp;<asp:Label ID="label1" runat="server" ForeColor="#2271A0">User Name</asp:Label></td>
                           <td style="width: 100px; text-align: center; height: 24px;" align="left" valign="top">
                               <asp:TextBox ID="txtUserId" runat="server">shatlin</asp:TextBox></td>
                           <td style="width: 100px; text-align: left; height: 24px;" align="left">
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserId"
                                   ErrorMessage="* Required"></asp:RequiredFieldValidator></td>
                       </tr>
                       <tr>
                           <td style="width: 50px">
                           </td>
                           <td style="width: 100px; text-align: right;">
                               &nbsp;<asp:Label ID="label2" runat="server" ForeColor="#2271A0">Password</asp:Label></td>
                           <td style="width: 100px; text-align: center;" valign="top">
                               <asp:TextBox ID="txtPassword" runat="server" Text="password" Width="156px"></asp:TextBox></td>
                           <td style="width: 100px; text-align: left;">
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword"
                                   ErrorMessage="* Required"></asp:RequiredFieldValidator></td>
                       </tr>
                       <tr>
                           <td style="width: 50px">
                           </td>
                           <td style="width: 100px; text-align: right;">
                            </td>
                           <td style="width: 100px; text-align: center;">
                           </td>
                           <td style="width: 100px">
                           </td>
                       </tr>
                       <tr>
                           <td style="width: 50px; height: 13px;">
                           </td>
                           <td style="width: 100px; text-align: right; height: 13px;">
                           </td>
                           <td style="width: 100px; height: 13px;">
                               &nbsp;</td>
                           <td style="width: 100px; height: 13px;">
                           </td>
                       </tr>
                       <tr>
                           <td style="width: 50px">
                           </td>
                           <td style="width: 100px; text-align: right">
                           </td>
                           <td style="width: 100px">
                           </td>
                           <td style="width: 100px">
                           </td>
                       </tr>
                       <tr>
                           <td style="width: 50px">
                           </td>
                           <td style="width: 100px; text-align: right">
                           </td>
                           <td style="width: 100px">
                           </td>
                           <td style="width: 100px">
                           </td>
                       </tr>
                       <tr>
                           <td style="width: 50px; height: 20px;">
                           </td>
                           <td style="width: 100px; text-align: right; height: 20px;">
                           </td>
                           <td style="width: 100px; text-align: center; height: 20px;" valign="top">
                               &nbsp;<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="ButtonStyle" BorderStyle="None" /></td>
                           <td style="width: 100px; height: 20px;">
                           </td>
                       </tr>
                       <tr>
                           <td colspan="4">
                               &nbsp;&nbsp;
                           </td>
                       </tr>
                       <tr>
                           <td colspan="5" style="height: 13px">
                               &nbsp;</td>
                       </tr>
                       <tr>
                           <td colspan="5" style="height: 13px">
                               &nbsp;<asp:Label ID="Label3" runat="server" ForeColor="Red"></asp:Label></td>
                       </tr>
                   </table>
                   
                    
                                       
                                       </h1>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px">
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
                            </p>
                        </td>
                    </tr>
                </table>
            </td>
            <td width="250" rowspan="2"  align=center valign=middle>
                </td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
                   
                   
                   
                   
                   
                   
                   
             
  
</asp:Content>

