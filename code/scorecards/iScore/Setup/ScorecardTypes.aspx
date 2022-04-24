<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="ScorecardTypes.aspx.cs" Inherits="Setup_ScorecardTypes" Title="iScore-Manage ScorecardTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:ScriptManager id="Scm" runat="server">
</asp:ScriptManager>

  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
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
                                            Manage Scorecard Tpes</h3>
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
                                       
                                       
                                       
             
                 <asp:GridView ID="grdScorecardTypes" runat="server" AutoGenerateColumns="False" DataKeyNames="ScorecardId" 
                  
                     DataSourceID="ScorecardTypeData" AllowPaging="True" >
                     
                     <Columns>
                         <asp:TemplateField HeaderImageUrl="~/images/ico_1x0.gif" ShowHeader="False">
                             <EditItemTemplate>
                                                                                   <asp:ImageButton ID="imgbtn1" runat="server" ToolTip="Update" CausesValidation="true" CommandName="Update"
                                                     ImageUrl="~/images/rec3.gif" ValidationGroup="GrdEditValGroup" />
                                          
                                                            
                                                      <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Cancel" CausesValidation="true" CommandName="Cancel"
                                                     ImageUrl="~/images/dl1.gif" ValidationGroup="GrdEditValGroup" />
                             </EditItemTemplate>
                             <ItemTemplate>
                                                      <asp:ImageButton ID="imgbtn1" runat="server" ToolTip="Edit" CausesValidation="true" CommandName="Edit"
                                                     ImageUrl="~/images/ico_1x0.gif" ValidationGroup="GrdEditValGroup" />
                                                     
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:BoundField DataField="ScorecardId" HeaderText="ScorecardId" InsertVisible="False"
                             ReadOnly="True" SortExpression="ScorecardId" Visible="False" />
                         <asp:TemplateField HeaderText="Scorecard Name" SortExpression="ScorecardName">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ScorecardName") %>' CausesValidation="True"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                     ErrorMessage="*"></asp:RequiredFieldValidator>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Bind("ScorecardName") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="Scorecard Description" SortExpression="ScorecardDetail">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox2"  Width="75%" runat="server" Text='<%# Bind("ScorecardDetail") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Bind("ScorecardDetail") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                         
                                             </Columns>
                 </asp:GridView>
                 <asp:ObjectDataSource ID="ScorecardTypeData" runat="server" SelectMethod="GetScorecardTypes" TypeName="Business.Setup.ScorecardTypeBL"
                     UpdateMethod="UpdateScorecardTypes">
                     <UpdateParameters>
                         <asp:Parameter Name="ScorecardId" Type="Int32" />
                         <asp:Parameter Name="ScorecardName" Type="String" />
                         <asp:Parameter Name="ScorecardDetail" Type="String" />
                     </UpdateParameters>
                 </asp:ObjectDataSource>
                                       
                                       </h1>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top" style="height: 46px">
                                    </td>
                                    <td valign="top" style="width: 1010px; height: 46px;">
                                   <h1 style="text-align: center">
                                       &nbsp;</h1>
                                    </td>
                                    <td valign="top" style="height: 46px">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    <td style="width: 1010px">
                                       <h1 style="text-align: center">
                                           &nbsp;</h1></td>
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
                <span style="color: #ffffff"><h1>
                    &nbsp;</h1></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
 
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>


