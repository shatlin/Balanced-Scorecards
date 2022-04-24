<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="OrgHierarchy.aspx.cs" Inherits="Setup_OrgHierarchy" Title="iScore-Manage Organization Roles" %>
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
                                            Manage organization Hierarchy</h3>
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
                                       <asp:GridView ID="grdOrgHierarchy" runat="server" AutoGenerateColumns="False" AllowPaging="True" ShowFooter="True" AllowSorting="True" DataSourceID="OrgHierarchyData" DataKeyNames="OrgHierarchyId" OnRowCommand="grdOrgHierarchy_RowCommand">
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
                             <FooterTemplate>
                             <asp:Button ID="btnAddOrgHierachy" runat="server" Text="Add Hierarchy"  CommandName="Insert" ValidationGroup="GrdAddValGrup" />
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="OrgHierarchyId" InsertVisible="False"  Visible="False" SortExpression="OrgHierarchyId">
                             <EditItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("OrgHierarchyId") %>'></asp:Label>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Bind("OrgHierarchyId") %>'></asp:Label>
                             </ItemTemplate>

                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="OrgHierarchyName" SortExpression="OrgHierarchyName">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("OrgHierarchyName") %>'></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2"
                                     ErrorMessage="*" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("OrgHierarchyName") %>'></asp:Label>
                             </ItemTemplate>
                             <FooterTemplate>
                                 <asp:TextBox ID="txtOrgHierarchyName" runat="server" CausesValidation="True" ValidationGroup="GrdAddValGrup"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtOrgHierarchyName"
                                     ErrorMessage="*" ValidationGroup="GrdAddValGrup"></asp:RequiredFieldValidator>
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="LocationId" SortExpression="LocationId">
                             <EditItemTemplate>
                                 <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LocationNameData"  
                                     DataTextField="LocationName" DataValueField="LocationId" SelectedValue='<%# Bind("LocationId") %>' >
                                     
                                 </asp:DropDownList><asp:ObjectDataSource ID="LocationNameData" runat="server"  OldValuesParameterFormatString="original_{0}"
                                     SelectMethod="GetLocation" TypeName="Business.Setup.LocationBL"></asp:ObjectDataSource>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label4" runat="server" Text='<%# GetLocationName((object)Eval("LocationId"))%>'></asp:Label>
                             </ItemTemplate>
                             <FooterTemplate>
                                 <asp:DropDownList ID="drpFooterLocation" runat="server" DataSourceID="FooterLocationNameData" DataTextField="LocationName" DataValueField="LocationId">
                                 </asp:DropDownList>
                                 <asp:ObjectDataSource ID="FooterLocationNameData" runat="server"  OldValuesParameterFormatString="original_{0}"
                                     SelectMethod="GetLocation" TypeName="Business.Setup.LocationBL"></asp:ObjectDataSource>
                             </FooterTemplate>
                         </asp:TemplateField>
                         
                         <asp:TemplateField HeaderText="ParentOrgHierarchyId" SortExpression="ParentOrgHierarchyId">
                             <EditItemTemplate>
                                 <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="OrgHierarchyData"
                                     DataTextField="OrgHierarchyName" DataValueField="OrgHierarchyId"  AppendDataBoundItems="True" SelectedValue='<%# Bind("ParentOrgHierarchyId") %>'>
                                     <asp:ListItem Value="">(None)</asp:ListItem>
                                 </asp:DropDownList>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label6" runat="server" Text='<%# GetParentOrganizationName((object)Eval("ParentOrgHierarchyId")) %>'></asp:Label>
                             </ItemTemplate>
                             <FooterTemplate>
                                 <asp:DropDownList ID="drpParentOrg" runat="server" DataSourceID="OrgHierarchyData" DataTextField="OrgHierarchyName" DataValueField="OrgHierarchyId" >
                                 </asp:DropDownList>
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="OrgHierarchySequence"  Visible="False" SortExpression="OrgHierarchySequence">
                             <EditItemTemplate>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Eval("OrgHierarchySequence") %>'></asp:Label>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label7" runat="server" Text='<%# Bind("OrgHierarchySequence") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                         
                         <asp:TemplateField HeaderImageUrl="~/images/del1.gif" >
                                            <ItemTemplate>
                                                     <asp:ImageButton ID="ImageButton1" ToolTip="Delete" runat="server" CausesValidation="true" CommandName="Delete"
                                                     ImageUrl="~/images/del1.gif" ValidationGroup="GrdEditValGroup" />
                                                     </ItemTemplate>
                                                     </asp:TemplateField>
                     </Columns>
                 </asp:GridView>
                 <asp:ObjectDataSource ID="OrgHierarchyData" runat="server" SelectMethod="GetOrganizationHierarchy" TypeName="Business.Setup.OrgHierarchyBL" UpdateMethod="UpdateOrganizationHierarchy" DeleteMethod="DeleteOrgHierarchy" OnInserting="OrgHierarchyData_Inserting" InsertMethod="AddOrganizationHierarchy">
                     <UpdateParameters>
                         <asp:Parameter Name="OrgHierarchyId" Type="Int32" />
                         <asp:Parameter Name="OrgHierarchyName" Type="String" />
                         <asp:Parameter Name="LocationId" Type="Int32" />
                         <asp:Parameter Name="ParentOrgHierarchyId" Type="Int32" />
                         <asp:Parameter Name="OrgHierarchySequence" Type="Int32" />
                     </UpdateParameters>
                     <DeleteParameters>
                         <asp:Parameter Name="OrgHierarchyId" Type="Int32" />
                     </DeleteParameters>
                     <InsertParameters>
                         <asp:Parameter Name="OrgHierarchyName" Type="String" />
                         <asp:Parameter Name="LocationId" Type="Int32" />
                         <asp:Parameter Name="ParentOrgHierarchyId" Type="Int32" />
                         <asp:Parameter Name="OrgHierarchySequence" Type="Int32" />
                     </InsertParameters>
                 </asp:ObjectDataSource>
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
                                       &nbsp;</h1>
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

