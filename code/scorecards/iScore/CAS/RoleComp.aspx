<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="RoleComp.aspx.cs" Inherits="CAS_RoleComp" Title="Untitled Page" %>
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
                                            Assign Competencies to Roles</h3>
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
                                           &nbsp;
                                           <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="RoleCompetencyId"
                                               DataSourceID="ObjectDataSource2" ShowFooter="True" AllowPaging="True" AllowSorting="True" OnRowCommand="GridView1_RowCommand">
                                               <Columns>
                                                   <asp:BoundField DataField="RoleCompetencyId" HeaderText="RoleCompetencyId" InsertVisible="False"
                                                       ReadOnly="True" SortExpression="RoleCompetencyId"  Visible="False" />
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
                                 <asp:Button ID="txtAddCompetency" runat="server" CommandName="Insert" Text="Add" ValidationGroup="GrdAddValGrup"/>
                                 

                                 
                             </FooterTemplate>
                         </asp:TemplateField>
                                                   <asp:TemplateField HeaderText="Organization Role" SortExpression="OrgRoleId">
                                                       <EditItemTemplate>
                                                           <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1"
                                                               DataTextField="OrgRoleName" DataValueField="OrgRoleId" SelectedValue='<%# Bind("OrgRoleId") %>'>
                                                           </asp:DropDownList>
                                                           <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                                                               SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL"></asp:ObjectDataSource>
                                                       </EditItemTemplate>
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label3" runat="server" Text='<%# GetOrgRoleName((object)Eval("OrgRoleId"))%>'></asp:Label>
                                                       </ItemTemplate>
                             
                                  <FooterTemplate>
                                 <asp:DropDownList ID="drpFooterOrgRole" runat="server" DataSourceID="ODS1"
                                                               DataTextField="OrgRoleName" DataValueField="OrgRoleId" >
                                                               
                                                              
                                  </asp:DropDownList>
                                         <asp:ObjectDataSource ID="ODS1" runat="server" OldValuesParameterFormatString="original_{0}"
                                                               SelectMethod="GetOrgRoles" TypeName="Business.Setup.OrgRoleBL"></asp:ObjectDataSource>                  
                             </FooterTemplate>
                                                   </asp:TemplateField>
                                                   <asp:TemplateField HeaderText="Competency" SortExpression="CompetencyId">
                                                       <EditItemTemplate>
                                                           <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="ObjectDataSource3" DataTextField="CompetencyName" DataValueField="CompetencyId" SelectedValue='<%# Bind("CompetencyId") %>' >
                                                           </asp:DropDownList>
                                                           <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}"
                                                               SelectMethod="GetCompetencies" TypeName="Business.CAS.CompetencyBL"></asp:ObjectDataSource>
                                                       </EditItemTemplate>
                                                       
                                                           <FooterTemplate>
                                                           <asp:DropDownList ID="drpFooterCompetency" runat="server" DataSourceID="ODS3" DataTextField="CompetencyName" DataValueField="CompetencyId"  >
                                                           </asp:DropDownList>
                                                            <asp:ObjectDataSource ID="ODS3" runat="server" OldValuesParameterFormatString="original_{0}"
                                                               SelectMethod="GetCompetencies" TypeName="Business.CAS.CompetencyBL"></asp:ObjectDataSource>
                                                       </FooterTemplate>
                                                       
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label1" runat="server" Text='<%# GetCompetencyName((object)Eval("CompetencyId"))%>'></asp:Label>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                   <asp:BoundField DataField="RatingMasterId" HeaderText="RatingMasterId" SortExpression="RatingMasterId" Visible="False"  />
                                                   <asp:TemplateField HeaderText="Desired Rating" SortExpression="DesiredRating">
                                                       <EditItemTemplate>
                                                           &nbsp;
                                                           <asp:DropDownList ID="DropDownList3" runat="server" SelectedValue='<%# Bind("DesiredRating") %>'>
                                                               <asp:ListItem>1</asp:ListItem>
                                                               <asp:ListItem>2</asp:ListItem>
                                                               <asp:ListItem>3</asp:ListItem>
                                                               <asp:ListItem>4</asp:ListItem>
                                                               <asp:ListItem>5</asp:ListItem>
                                                           </asp:DropDownList>
                                                       </EditItemTemplate>
                                                       
                                                       <FooterTemplate>
                                                           &nbsp;
                                                           <asp:DropDownList ID="drpFooterDesiredRating" runat="server">
                                                               <asp:ListItem>1</asp:ListItem>
                                                               <asp:ListItem>2</asp:ListItem>
                                                               <asp:ListItem>3</asp:ListItem>
                                                               <asp:ListItem>4</asp:ListItem>
                                                               <asp:ListItem>5</asp:ListItem>
                                                           </asp:DropDownList>
                                                       </FooterTemplate>
                                                       
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("DesiredRating") %>'></asp:Label>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                   
                                    
                    
                                                                      <asp:TemplateField HeaderImageUrl="~/images/del1.gif" >
                                            <ItemTemplate>
                                                     <asp:ImageButton ID="ImageButtonX" ToolTip="Delete" runat="server" CausesValidation="true" CommandName="Delete"
                                                     ImageUrl="~/images/del1.gif" ValidationGroup="GrdEditValGroup" />
                                                     </ItemTemplate>
                                                     </asp:TemplateField>
                                               </Columns>
                                           </asp:GridView>
                                       
                                       
                                       
                                       </h1>
                                    </td>
                                    <td valign="top">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top" style="height: 16px">
                                    </td>
                                    <td valign="top" style="width: 1010px; height: 16px;">
                                   <h1 style="text-align: center">
                                           &nbsp;</h1>
                                    </td>
                                    <td valign="top" style="height: 16px">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="height: 149px">
                                        &nbsp;</td>
                                    <td style="width: 1010px; height: 149px;">
                                       <h1 style="text-align: center">
                                           &nbsp;<asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="DeleteRoleCompetency"
                                               InsertMethod="AddRoleCompetency" SelectMethod="GetRoleCompetencyList" TypeName="Business.CAS.RoleCompetencyBL"
                                               UpdateMethod="UpdateRoleCompetency" OnInserting="ObjectDataSource2_Inserting">
                                               <DeleteParameters>
                                                   <asp:Parameter Name="RoleCompetencyID" Type="Int32" />
                                               </DeleteParameters>
                                               <UpdateParameters>
                                                   <asp:Parameter Name="RoleCompetencyId" Type="Int32" />
                                                   <asp:Parameter Name="OrgroleId" Type="Int32" />
                                                   <asp:Parameter Name="CompetencyId" Type="Int32" />
                                                   <asp:Parameter Name="RatingMasterId" Type="Int32" />
                                                   <asp:Parameter Name="DesiredRating" Type="Int32" />
                                               </UpdateParameters>
                                               <InsertParameters>
                                                   <asp:Parameter Name="OrgroleId" Type="Int32" />
                                                   <asp:Parameter Name="CompetencyId" Type="Int32" />
                                                   <asp:Parameter Name="RatingMasterId" Type="Int32" />
                                                   <asp:Parameter Name="DesiredRating" Type="Int32" />
                                               </InsertParameters>
                                           </asp:ObjectDataSource>
                                       </h1></td>
                                    <td style="height: 149px">
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" valign="top">
                                    </td>
                                    <td valign="top" style="width: 1010px">
                                        <h1 style="text-align: center">
                                            &nbsp;</h1></td>
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
                <span style="color: #ffffff"><h1>
                    &nbsp;</h1>
                    <p>
                        &nbsp;</p>
                </span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
</asp:Content>

