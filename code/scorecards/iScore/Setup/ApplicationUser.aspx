<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="ApplicationUser.aspx.cs" Inherits="Setup_ApplicationUser" Title="iScore-Manage Users" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<table width="100%" height="100%" style="vertical-align: top" border="0" cellpadding="0"
        cellspacing="0" background="../images/topnavbg.jpg">
        <tr>
            <td colspan="2" background="../images/basebg2.jpg" style="height: 9px">
                <img src="../images/basebg2.jpg" width="1" height="9"/></td>
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
                                            Manage Users</h3>
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
                                        &nbsp;<asp:GridView ID="GrdAppUsers" runat="server" AllowPaging="True" AllowSorting="True"
                                            AutoGenerateColumns="False" DataKeyNames="AppUserId" DataSourceID="AppUserDataSource"
                                            EmptyDataText="No Records Found" OnRowCommand="GrdAppUsers_RowCommand" ShowFooter="True" OnRowDeleted="GrdAppUsers_RowDeleted">
                                            <Columns>
                      
                                                <asp:TemplateField HeaderImageUrl="~/images/ico_1x0.gif" ShowHeader="False">
                                                    <EditItemTemplate>
                                                    <asp:ImageButton ID="imgbtn1" runat="server" ToolTip="Update" CausesValidation="true" CommandName="Update"
                                                     ImageUrl="~/images/rec3.gif" ValidationGroup="GrdEditValGroup" />
                                          
                                                            
                                                      <asp:ImageButton ID="ImageButton2" runat="server" ToolTip="Cancel" CausesValidation="true" CommandName="Cancel"
                                                     ImageUrl="~/images/dl1.gif" ValidationGroup="GrdEditValGroup" />
                                                 
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                                           
                                                                           <asp:ImageButton ID="imgbtn11" runat="server" ToolTip="Edit" CausesValidation="true" CommandName="Edit"
                                                     ImageUrl="~/images/ico_1x0.gif" ValidationGroup="GrdEditValGroup" />

                                                        
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="AppUserId" InsertVisible="False" SortExpression="AppUserId"
                                                    Visible="False">
                                                    <EditItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("AppUserId") %>'></asp:Label>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("AppUserId") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="User ID" SortExpression="AppUserOrgId">
                                                    <EditItemTemplate>
                                                    <table>
                                                    <tr>
                                                    <td>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("AppUserOrgId") %>' CausesValidation="True" MaxLength="50" ValidationGroup="GrdEditValGroup"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox1"
                                                            ErrorMessage="*" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                                                    </td>
                                                    </tr>
                                                    </table>
                                                        
                                                       
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("AppUserOrgId") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                    <table>
                                                    <tr>
                                                    <td><asp:TextBox ID="txtAppUserOrgId" runat="server" CausesValidation="True" MaxLength="50" ValidationGroup="GrdFooterAdd"></asp:TextBox></td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAppUserOrgId"
                                                            ErrorMessage="*" ValidationGroup="GrdFooterAdd"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                        
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Name" SortExpression="AppUserName">
                                                    <EditItemTemplate>
                                                    <table>
                                                    <tr>
                                                    <td>
                                                     <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("AppUserName") %>' CausesValidation="True" MaxLength="100" ValidationGroup="GrdEditValGroup"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox2"
                                                            ErrorMessage="*" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                                                    </td>
                                                    </tr>
                                                    </table>
                                                       
                                                      
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("AppUserName") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                    <table>
                                                    <tr>
                                                    <td><asp:TextBox ID="txtAppUserName" runat="server" CausesValidation="True" MaxLength="100" ValidationGroup="GrdFooterAdd"></asp:TextBox></td>
                                                    <td style="width: 3px">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*" ControlToValidate="txtAppUserName" ValidationGroup="GrdFooterAdd"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                        
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Email" SortExpression="AppUserEmail">
                                                    <EditItemTemplate>
                                                    <table>
                                                    <tr>
                                                    <td><asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("AppUserEmail") %>' CausesValidation="True" MaxLength="50" ValidationGroup="GrdEditValGroup"></asp:TextBox></td>
                                                    <td><asp:RequiredFieldValidator  ControlToValidate="TextBox3" ID="RequiredFieldValidator7" runat="server" ErrorMessage="*"
                                                            ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                    
                                                        
                                                        
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("AppUserEmail") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                    <table>
                                                    <tr>
                                                    <td style="width: 158px"> <asp:TextBox ID="txtAppUserEmail" runat="server" CausesValidation="True" MaxLength="50" ValidationGroup="GrdFooterAdd"></asp:TextBox></td>
                                                    <td style="width: 3px">
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtAppUserEmail"
                                                            ErrorMessage="*" ValidationGroup="GrdFooterAdd"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                       
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="User Type" SortExpression="SystemRoldId">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="DrpSystemRole" runat="server" DataSourceID="objSystemRoleData"
                                                            DataTextField="SystemRoleName" DataValueField="SystemRoleid" SelectedValue='<%# Bind("SystemRoldId") %>'>
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objSystemRoleData" runat="server" OldValuesParameterFormatString="original_{0}"
                                                            SelectMethod="GetSystemRoles" TypeName="Business.Setup.SystemRoleBL"></asp:ObjectDataSource>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label5" runat="server" Text='<%# GetSystemRoleName((object)Eval("SystemRoldid")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="DrpSystemRoldId" runat="server" DataSourceID="objFooterSystemRoleData"
                                                            DataTextField="SystemRoleName" DataValueField="SystemRoleid">
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objFooterSystemRoleData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetSystemRoles" TypeName="Business.Setup.SystemRoleBL">
                                                        </asp:ObjectDataSource>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Division" SortExpression="OrgHierarchyId" >
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="DrpOrgHierarchy" runat="server" DataSourceID="objOrgHierarchyData"
                                                            DataTextField="OrgHierarchyName" DataValueField="OrgHierarchyId" SelectedValue='<%# Bind("OrgHierarchyId") %>'>
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objOrgHierarchyData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrganizationHierarchy"
                                                            TypeName="Business.Setup.OrgHierarchyBL"></asp:ObjectDataSource>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label6" runat="server" Text='<%# GetOrganizationName((object)Eval("OrgHierarchyId")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="DrpOrgHierarchyId" runat="server" DataSourceID="objFooterOrgHierarchyData"
                                                            DataTextField="OrgHierarchyName" DataValueField="OrgHierarchyId">
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objFooterOrgHierarchyData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrganizationHierarchy"
                                                            TypeName="Business.Setup.OrgHierarchyBL"></asp:ObjectDataSource>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Role" SortExpression="OrgRoleId">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="objOrgRoleData"
                                                            DataTextField="OrgRoleName" DataValueField="OrgRoleId" SelectedValue='<%# Bind("OrgRoleId") %>'>
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objOrgRoleData" runat="server" OldValuesParameterFormatString="original_{0}"
                                                            SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL"></asp:ObjectDataSource>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label7" runat="server" Text='<%# GetOrgRoleName((object)Eval("OrgRoleId")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="DrpOrgRoleId" runat="server" DataSourceID="objFooterOrgRoleData"
                                                            DataTextField="OrgRoleName" DataValueField="OrgRoleId">
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objFooterOrgRoleData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL">
                                                        </asp:ObjectDataSource>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Reports To" SortExpression="OrdinateAppUserId">
                                                    <EditItemTemplate>
                                                        <asp:DropDownList ID="DrpOrdinateUser" runat="server" AppendDataBoundItems="True"
                                                            DataSourceID="AppUserDataSource" DataTextField="AppUserName" DataValueField="AppUserId"
                                                            SelectedValue='<%# Bind("OrdinateAppUserId") %>'>
                                                            <asp:ListItem Value="">None</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label8" runat="server" Text='<%# GetAppUserName((object)Eval("OrdinateAppUserId")) %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        <asp:DropDownList ID="DrpOrdinateAppUserId" runat="server" DataSourceID="AppUserDataSource"
                                                            DataTextField="AppUserName" DataValueField="AppUserId">
                                                        </asp:DropDownList>
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Joined On" SortExpression="JoinDate" >
                                                    <EditItemTemplate>
                                                    
                                                    <table>
                                                    <tr>
                                                    <td> <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("JoinDate") %>'></asp:TextBox></td>
                                                    <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8"
                                                            ErrorMessage="*" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                       
                                                       
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("JoinDate") %>'></asp:Label>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                    <table>
                                                    <tr>
                                                    <td><asp:TextBox ID="txtJoinDate" runat="server" CausesValidation="True" ValidationGroup="GrdFooterAdd"></asp:TextBox></td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtJoinDate"
                                                            ErrorMessage="*" ValidationGroup="GrdFooterAdd"></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                    </table>
                                                        
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Active?" SortExpression="IsActive">
                                                    <EditItemTemplate>
                                                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("IsActive") %>' />
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("IsActive") %>' Enabled="false" />
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                   
                                                                    <asp:CheckBox ID="chkIsActive" runat="server" Checked="false" />
                                                                
                                                    </FooterTemplate>
                                                </asp:TemplateField>
                                                                      <asp:TemplateField HeaderImageUrl="~/images/del1.gif" ShowHeader="True" >
                                            <ItemTemplate>
                                                     <asp:ImageButton ID="ImageButton1" ToolTip="Delete" runat="server" CausesValidation="true" CommandName="Delete"
                                                     ImageUrl="~/images/del1.gif" ValidationGroup="GrdEditValGroup" />
                                                     </ItemTemplate>
                                                     
                                                     
                                                      <FooterTemplate>
                                            
                                                                    <asp:Button ID="btnAddAppUser" runat="server" CommandName="Insert" Text="Add" ValidationGroup="GrdFooterAdd" /></td>
                                 
                                                    </FooterTemplate>
                                            </asp:TemplateField>
                                            </Columns>
                                             
                                        </asp:GridView>
                                        <asp:Panel ID="PnlAddRow" runat=server Visible="false">
                                        <table border="0"  cellpadding=0 cellspacing=0  >
                                        <tr class="SimpleBlueTableHeadRow">
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                User Id
                                            </td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px; width: 156px;">
                                                Name&nbsp;</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Email</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                User Type</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Division</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Role</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Reports To</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Joined On&nbsp;</td>
                                            <td class="SimpleBlueTableHeadCell" style="height: 24px">
                                                Active?</td>
                                            </tr>
                                            <tr>
                                            <td class="SimpleBlueTableCell" colspan="9">
                                            &nbsp;</td>
                                            </tr>
                                            <tr align="center">
                                            <td class="SimpleBlueTableCell">
                                   
                                                <table>
                                                    <tr>
                                                <td style="width: 56px">
                                            <asp:TextBox ID="EmptytxtAppUserOrgId" runat="server" ValidationGroup="AddAppUserValGroup" CausesValidation="True"></asp:TextBox></td>
                                            <td>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="AddAppUserValGroup" runat="server" ControlToValidate="EmptytxtAppUserOrgId"
                                                    ErrorMessage="*" ></asp:RequiredFieldValidator></td>
                                                    </tr>
                                                </table>
                                            </td>
                                             <td class="SimpleBlueTableCell" >
                                                 
                                                 <table>
                                                     <tr>
                                                         <td >
                                             <asp:TextBox ID="EmptytxtAppUserName" runat="server" ValidationGroup="AddAppUserValGroup" CausesValidation="True"></asp:TextBox></td>
                                                         <td >
                                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2"  ValidationGroup="AddAppUserValGroup" runat="server" ErrorMessage="*" ControlToValidate="EmptytxtAppUserName"></asp:RequiredFieldValidator>
                                                         </td>
                                                     </tr>
                                                 </table>
                                                 
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                                 <table>
                                                     <tr>
                                                         <td style="width: 16px" >
                                             <asp:TextBox ID="EmptytxtAppUserEmail" runat="server" ValidationGroup="AddAppUserValGroup" CausesValidation="True"></asp:TextBox></td>
                                                         <td >
                                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3"  ValidationGroup="AddAppUserValGroup" runat="server" ErrorMessage="*" ControlToValidate="EmptytxtAppUserEmail"></asp:RequiredFieldValidator></td>
                                                     </tr>
                                                 </table>
                                               
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                            <asp:DropDownList ID="EmptyDrpSystemRoldId" runat="server" DataSourceID="objFooterSystemRoleData"
                                                            DataTextField="SystemRoleName" DataValueField="SystemRoleid">
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objFooterSystemRoleData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetSystemRoles" TypeName="Business.Setup.SystemRoleBL">
                                                        </asp:ObjectDataSource>
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                            <asp:DropDownList ID="EmptyDrpOrgHierarchyId" runat="server" DataSourceID="objFooterOrgHierarchyData"
                                                            DataTextField="OrgHierarchyName" DataValueField="OrgHierarchyId"> </asp:DropDownList><asp:ObjectDataSource ID="objFooterOrgHierarchyData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrganizationHierarchy"
                                                            TypeName="Business.Setup.OrgHierarchyBL"></asp:ObjectDataSource>
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                                                       <asp:DropDownList ID="EmptyDrpOrgRoleId" runat="server" DataSourceID="objFooterOrgRoleData"
                                                            DataTextField="OrgRoleName" DataValueField="OrgRoleId">
                                                        </asp:DropDownList><asp:ObjectDataSource ID="objFooterOrgRoleData" runat="server"
                                                            OldValuesParameterFormatString="original_{0}" SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL">
                                                        </asp:ObjectDataSource>
                                                  
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                                <asp:DropDownList ID="EmptyDrpOrdinateAppUserId"  Enabled=false runat="server" AppendDataBoundItems="true" DataSourceID="AppUserDataSource"
                                                            DataTextField="AppUserName" DataValueField="AppUserId">
                                                            <asp:ListItem Value="">None</asp:ListItem>
                                                        </asp:DropDownList>
                                            </td>
                                           <td class="SimpleBlueTableCell">
                                               <table>
                                                   <tr>
                                                       <td>
                                            
                                                        <asp:TextBox ID="EmptytxtJoinDate" runat="server" ValidationGroup="AddAppUserValGroup" CausesValidation="True"></asp:TextBox></td>
                                                       <td>
                                                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ValidationGroup="AddAppUserValGroup" ErrorMessage="*" ControlToValidate="EmptytxtJoinDate"></asp:RequiredFieldValidator>
                                                       
                                                       </td>
                                                   </tr>
                                               </table>
                                              
                                            </td>
                                             <td class="SimpleBlueTableCell">
                                             <table border="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:CheckBox ID="EmptychkIsActive" runat="server" Checked="false" /></td>
                                                                <td>
                                                                    <asp:Button ID="EmptybtnAddAppUser" runat="server" ValidationGroup="AddAppUserValGroup" CommandName="Insert" Text="Add" OnClick="EmptybtnAddAppUser_Click" /></td>
                                                            </tr>
                                                        </table>
                                            </td>
                                            </tr>
                                            <tr>
                                            <td class="SimpleBlueTableCell" colspan="9" style="height: 18px">
                                            &nbsp;</td>
                                            </tr>
                                            </table>
                                             </asp:Panel>
                                             
                                             
                                     
                                        <asp:ObjectDataSource ID="AppUserDataSource" runat="server" OnInserting="AppUserDataSource_Inserting"
                                            UpdateMethod="UpdateAppUser" TypeName="Business.Setup.AppUserBL" SelectMethod="GetAppUserDetails"
                                            InsertMethod="AddAppUser" DeleteMethod="DeleteAppuser">
                                            <DeleteParameters>
                                                <asp:Parameter Name="AppUserId" Type="Int32" />
                                            </DeleteParameters>
                                            <UpdateParameters>
                                                <asp:Parameter Name="AppUserId" Type="Int32" />
                                                <asp:Parameter Name="AppUserOrgId" Type="String" />
                                                <asp:Parameter Name="AppUserName" Type="String" />
                                                <asp:Parameter Name="AppUserEmail" Type="String" />
                                                <asp:Parameter Name="SystemRoldId" Type="Int32" />
                                                <asp:Parameter Name="OrgHierarchyId" Type="Int32" />
                                                <asp:Parameter Name="OrgRoleId" Type="Int32" />
                                                <asp:Parameter Name="OrdinateAppUserId" Type="Int32" />
                                                <asp:Parameter Name="JoinDate" Type="DateTime" />
                                                <asp:Parameter Name="IsActive" Type="Boolean" />
                                            </UpdateParameters>
                                            <InsertParameters>
                                                <asp:Parameter Name="AppUserOrgId" Type="String" />
                                                <asp:Parameter Name="AppUserName" Type="String" />
                                                <asp:Parameter Name="AppUserEmail" Type="String" />
                                                <asp:Parameter Name="SystemRoldId" Type="Int32" />
                                                <asp:Parameter Name="OrgHierarchyId" Type="Int32" />
                                                <asp:Parameter Name="OrgRoleId" Type="Int32" />
                                                <asp:Parameter Name="OrdinateAppUserId" Type="Int32" />
                                                <asp:Parameter Name="JoinDate" Type="DateTime" />
                                                <asp:Parameter Name="IsActive" Type="Boolean" />
                                            </InsertParameters>
                                        </asp:ObjectDataSource>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top" style="height: 35px">
                                    </td>
                                    <td valign="top" style="width: 1010px; height: 35px;">
                                   <h1 style="text-align: center">
                                       &nbsp;</h1>
                                    </td>
                                    <td valign="top" style="height: 35px">
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
                                    <td align="center" valign="top" style="height: 36px">
                                    </td>
                                    <td valign="top" style="width: 1010px; height: 36px;">
                                        </td>
                                    <td valign="top" style="height: 36px">
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
</asp:Content>
