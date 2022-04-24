<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="SelfRating.aspx.cs" Inherits="CAS_SelfRating" Title="Untitled Page" %>
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
                                    <td valign="top" style="height: 110px">
                                    </td>
                                    <td class="PageInfoTableBod" valign="top" style="height: 110px">
                                        <h3>
                                            Self Rating</h3>
                                        <h4>
                                            <asp:Label ID="lblPageInfo" runat="server"></asp:Label>&nbsp;
                                        </h4>
                                        <h4>
                                            <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
                                            <asp:Label ID="Label5" runat="server" Text="Role Id:" Visible="False"></asp:Label>
                                            &nbsp; &nbsp;<asp:Label ID="lblRoleName" runat="server" Visible="False"></asp:Label>&nbsp;&nbsp;
                                            &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                                        </h4>
                                    </td>
                                    <td valign="top" style="height: 110px">
                                    </td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                    </td>
                                    <td valign="top" align="center">
                                       <h1>
                                           <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                                               AutoGenerateColumns="False" DataKeyNames="RoleCompetencyId" DataSourceID="ObjectDataSource2" ShowFooter="True" OnRowDataBound="GridView1_RowDataBound1">
                                               <Columns>
                                                   <asp:TemplateField HeaderText="RoleCompetencyId" InsertVisible="False" SortExpression="RoleCompetencyId"
                                                       Visible="False">
                                                     
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("RoleCompetencyId") %>'></asp:Label>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                   
                                                   <asp:TemplateField HeaderText="OrgRoleId" InsertVisible="False" SortExpression="OrgRoleId"
                                                       Visible="False">
                                                      
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label4" runat="server" Text='<%# Bind("OrgRoleId") %>'></asp:Label>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                                                                       
                                                   <asp:TemplateField HeaderText="Organization Role" SortExpression="OrgRoleId">

                                                       <ItemTemplate>
                                                           <asp:Label ID="Label3" runat="server" Text='<%# GetOrgRoleName((object)Eval("OrgRoleId"))%>'></asp:Label>
                                                       </ItemTemplate>
                                                       </asp:TemplateField>
                                                       
                                        <asp:TemplateField HeaderText="OrgRoleId" InsertVisible="False" SortExpression="OrgRoleId"
                                           Visible="False">
                                          
                                           <ItemTemplate>
                                               <asp:Label ID="Label7" runat="server" Text='<%# Bind("CompetencyId") %>'></asp:Label>
                                           </ItemTemplate>
                                       </asp:TemplateField>
                                                 
                                                   
                                                    
                                                   <asp:TemplateField HeaderText="Competency" SortExpression="CompetencyId">
                                                       
                                                       <ItemTemplate>
                                                           <asp:Label ID="Label1" runat="server" Text='<%# GetCompetencyName((object)Eval("CompetencyId"))%>'></asp:Label>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                   
                                                   <asp:BoundField DataField="RatingMasterId" HeaderText="RatingMasterId" SortExpression="RatingMasterId"
                                                       Visible="False" />
                                                       
                                                   <asp:TemplateField HeaderText="Self Rating"  >
                                                       <ItemTemplate>
                                                     <asp:DropDownList ID="DropDownList3" runat="server" >
                                                               <asp:ListItem>1</asp:ListItem>
                                                               <asp:ListItem>2</asp:ListItem>
                                                               <asp:ListItem>3</asp:ListItem>
                                                               <asp:ListItem>4</asp:ListItem>
                                                               <asp:ListItem>5</asp:ListItem>
                                                           </asp:DropDownList>
                                                       </ItemTemplate>
                                                   </asp:TemplateField>
                                                   
                                                   <asp:BoundField DataField="DesiredRating" HeaderText="DesiredRating" SortExpression="DesiredRating"/>
                                               
                                               
                                               </Columns>
                                           </asp:GridView>
                                           <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetCompetenciesForRole" TypeName="Business.CAS.RoleCompetencyBL" DeleteMethod="DeleteRoleCompetency" OldValuesParameterFormatString="original_{0}"  >
                                               <DeleteParameters>
                                                   <asp:Parameter Name="RoleCompetencyID" Type="Int32" />
                                               </DeleteParameters>
                                               <SelectParameters>
                                                   <asp:ControlParameter ControlID="lblRoleName" Name="iRoleId" PropertyName="Text"
                                                       Type="Int32" />
                                               </SelectParameters>
                                                  
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
                                        <asp:Label ID="lblResult" runat="server" ForeColor="Red"></asp:Label></td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="height: 46px">
                                        &nbsp;</td>
                                    <td style="width: 1010px; height: 46px;">
                                       <h1 style="text-align: center">
                                           <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />&nbsp;</h1></td>
                                    <td style="height: 46px">
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
                <span style="color: #ffffff"><h1></h1></span></td>
        </tr>
        <tr>
            <td bgcolor="#FFFFFF" style="width: 1034px; height: 13px;">
                </td>
        </tr>
    </table>
</asp:Content>

