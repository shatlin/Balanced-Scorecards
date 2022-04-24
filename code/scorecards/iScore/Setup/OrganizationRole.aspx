<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="OrganizationRole.aspx.cs" Inherits="Setup_OrgRole" Title="iScore-Manage Organization Roles" %>
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
                                            Manage Organization Roles</h3>
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
                                        <asp:GridView CssClass="gvHeaderRow" ID="grdOrgRole" runat="server" AutoGenerateColumns="False" DataKeyNames="OrgRoleId" 
                  
                     DataSourceID="OrgRoleData" AllowPaging="True" OnRowCommand="grdOrgRole_RowCommand" ShowFooter="True" AllowSorting="True">
                    
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
                             
                             <asp:Button ID="txtAddOrgRole" runat="server" CommandName="Insert" Text="Add Role" ValidationGroup="GrdAddValGrup"  />
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField   HeaderText="OrgRoleId" InsertVisible="False" SortExpression="OrgRoleId" Visible="False">
                             <EditItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("OrgRoleId") %>'></asp:Label>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Bind("OrgRoleId") %>'></asp:Label>
                             </ItemTemplate>
                             <FooterTemplate>
                                 
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="Role Name" SortExpression="OrgRoleName">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("OrgRoleName") %>' CausesValidation="True"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                                     ErrorMessage="*" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                             </EditItemTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Bind("OrgRoleName") %>'></asp:Label>
                             </ItemTemplate>
                             
                              <FooterTemplate>
                                 <asp:TextBox ID="txtOrgRoleName" runat="server" MaxLength="50" CausesValidation="True" ValidationGroup="GrdAddValGrup"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="valorgRole" runat="server" ControlToValidate="txtOrgRoleName"
                                     ErrorMessage="*" ValidationGroup="GrdAddValGrup"></asp:RequiredFieldValidator>
                             </FooterTemplate>
                             
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="Role Description" SortExpression="OrgRoleDetail">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("OrgRoleDetail") %>'></asp:TextBox>
                             </EditItemTemplate>
                             
                              <FooterTemplate>
                                 <asp:TextBox ID="txtRoleDescription" runat="server" MaxLength="1000" TextMode="MultiLine"></asp:TextBox>
                             </FooterTemplate>
                                                         
                             <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("OrgRoleDetail") %>'></asp:Label>
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
                 <asp:ObjectDataSource ID="OrgRoleData" runat="server" DeleteMethod="DeleteOrgRole"
                     InsertMethod="AddOrgRole" SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL"
                     UpdateMethod="UpdateOrgRole" OnInserting="OrgRoleData_Inserting">
                     <DeleteParameters>
                         <asp:Parameter Name="OrgRoleId" Type="Int32" />
                     </DeleteParameters>
                     <UpdateParameters>
                         <asp:Parameter Name="OrgRoleId" Type="Int32" />
                         <asp:Parameter Name="OrgRoleName" Type="String" />
                         <asp:Parameter Name="OrgRoleDetail" Type="String" />
                     </UpdateParameters>
                     <InsertParameters>
                         <asp:Parameter Name="OrgRoleName" Type="String" />
                         <asp:Parameter Name="OrgRoleDetail" Type="String" />
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
                <span style="color: #ffffff"></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>

</ContentTemplate>
</asp:UpdatePanel>  

          
</asp:Content>

