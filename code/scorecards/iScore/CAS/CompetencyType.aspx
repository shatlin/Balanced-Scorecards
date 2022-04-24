<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true"
    CodeFile="CompetencyType.aspx.cs" Inherits="CAS_CompetencyType" Title="Competency Type" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

            <table style="vertical-align: top" height="100%" cellspacing="0" cellpadding="0"
                width="100%" background="../images/topnavbg.jpg" border="0">
                <tbody>
                    <tr>
                        <td style="height: 9px" background="../images/basebg2.jpg" colspan="2">
                            <img height="9" src="../images/basebg2.jpg" width="1" /></td>
                    </tr>
                    <tr>
                        <td style="width: 1034px" valign="top" bgcolor="#ffffff">
                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                <tbody>
                                    <tr>
                                        <td background="../images/navbasebg.jpg" colspan="1" height="29">
                                            <img height="29" src="../images/navbasebg.jpg" width="1" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <table style="width: 100%">
                                                <tbody>
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
                                                </tbody>
                                            </table>
                                            <table cellspacing="0" cellpadding="5" width="100%" border="0">
                                                <tbody>
                                                    <tr>
                                                        <td valign="top" style="height: 78px">
                                                        </td>
                                                        <td class="PageInfoTableBod" valign="top" style="height: 78px">
                                                            <h3>
                                                                Manage&nbsp;Competency Types</h3>
                                                            <h4>
                                                                <asp:Label ID="lblPageInfo" runat="server"></asp:Label></h4>
                                                        </td>
                                                        <td valign="top" style="height: 78px">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td valign="top">
                                                        </td>
                                                        <td valign="top" align="center">
                                                            <h1>
                                                                <asp:GridView ID="grdCompetencyTypes" runat="server" AutoGenerateColumns="False" DataKeyNames="CompetencyTypeId"
                                                                    DataSourceID="CompetencyTypeData" AllowPaging="True" OnRowCommand="grdCompetencyTypes_RowCommand" ShowFooter="true">
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
                                 <asp:Button ID="txtAddCompetencyType" runat="server" CommandName="Insert" Text="Add" />
                             </FooterTemplate>
                         </asp:TemplateField>
                         
                                                                        <asp:TemplateField SortExpression="CompetencyTypeId" HeaderText="CompetencyTypeId" Visible="False"
                                                                            InsertVisible="False">
                                                                            <EditItemTemplate>
                                                                                <asp:Label runat="server" Text='<%# Eval("CompetencyTypeId") %>' ID="Label1"></asp:Label>
                                                                            </EditItemTemplate>
                                                                            <ItemTemplate>
                                                                                <asp:Label runat="server" Text='<%# Bind("CompetencyTypeId") %>' ID="Label1"></asp:Label>
                                                                            </ItemTemplate>
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField SortExpression="CompetencyTypeName" HeaderText="CompetencyTypeName">
                                                                            <EditItemTemplate>
                                                                                <asp:TextBox runat="server" Text='<%# Bind("CompetencyTypeName") %>' ID="TextBox1" CausesValidation="True" ValidationGroup="GrdEditValGroup" Height="30px" MaxLength="50" Width="208px"></asp:TextBox>
                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                                                                            </EditItemTemplate>
                                                                            <ItemTemplate>
                                                                                <asp:Label runat="server" Text='<%# Bind("CompetencyTypeName") %>' ID="Label2"></asp:Label>
                                                                            </ItemTemplate>
                                                                            
                                                                                                         <FooterTemplate>
                                 <asp:TextBox ID="txtCompetencyTypeName" runat="server" MaxLength="50" Height="30px" Width="208px"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="valCompetencyTypeName" runat="server" ControlToValidate="txtCompetencyTypeName"
                                     ErrorMessage="*"></asp:RequiredFieldValidator>
                             </FooterTemplate>
                                                                            
                                                                        </asp:TemplateField>
                                                                        <asp:TemplateField SortExpression="CompetencyTypeDescription" HeaderText="CompetencyTypeDescription">
                                                                            <EditItemTemplate>
                                                                                <asp:TextBox runat="server" Text='<%# Bind("CompetencyTypeDescription") %>' ID="TextBox2" Height="85px" MaxLength="1000" TextMode="MultiLine" Width="555px"></asp:TextBox>
                                                                            </EditItemTemplate>
                                                                            <ItemTemplate>
                                                                                <asp:Label runat="server" Text='<%# Bind("CompetencyTypeDescription") %>' ID="Label3"></asp:Label>
                                                                            </ItemTemplate>
                                                                               <FooterTemplate>
                                 <asp:TextBox ID="txtCompetencyTypeDescription" runat="server" MaxLength="1000" TextMode="MultiLine" Height="85px" Width="555px"></asp:TextBox>
                             </FooterTemplate>
                                                                        </asp:TemplateField>
                                                                                           
                                                                      <asp:TemplateField HeaderImageUrl="~/images/del1.gif" >
                                            <ItemTemplate>
                                                     <asp:ImageButton ID="ImageButton1" ToolTip="Delete" runat="server" CausesValidation="true" CommandName="Delete"
                                                     ImageUrl="~/images/del1.gif" ValidationGroup="GrdEditValGroup" />
                                                     </ItemTemplate>
                                                     </asp:TemplateField>                                                                       

                                                                    </Columns>
                                                                </asp:GridView>
                                                                <asp:ObjectDataSource ID="CompetencyTypeData" runat="server" SelectMethod="GetCompetencyTypes"
                                                                    TypeName="Business.CAS.CompetencyTypeBL" UpdateMethod="UpdateCompetencyType"
                                                                    InsertMethod="AddCompetencyType" DeleteMethod="DeleteCompetencyType" OnInserting="CompetencyTypeData_Inserting">
                                                                    <DeleteParameters>
                                                                        <asp:Parameter Type="Int32" Name="CompetencyTypeID"></asp:Parameter>
                                                                    </DeleteParameters>
                                                                    <UpdateParameters>
                                                                        <asp:Parameter Type="Int32" Name="CompetencyTypeId"></asp:Parameter>
                                                                        <asp:Parameter Type="String" Name="CompetencyTypeName"></asp:Parameter>
                                                                        <asp:Parameter Type="String" Name="CompetencyTypeDescription"></asp:Parameter>
                                                                    </UpdateParameters>
                                                                    <InsertParameters>
                                                                        <asp:Parameter Type="String" Name="CompetencyTypeName"></asp:Parameter>
                                                                        <asp:Parameter Type="String" Name="CompetencyTypeDescription"></asp:Parameter>
                                                                    </InsertParameters>
                                                                </asp:ObjectDataSource>
                                                            </h1>
                                                        </td>
                                                        <td valign="top">
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height: 46px" valign="top" align="center">
                                                        </td>
                                                        <td style="width: 1010px; height: 46px" valign="top">
                                                            <h1 style="text-align: center">
                                                                &nbsp;</h1>
                                                        </td>
                                                        <td style="height: 46px" valign="top">
                                                            &nbsp;
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="center">
                                                            &nbsp;</td>
                                                        <td style="width: 1010px">
                                                            <h1 style="text-align: center">
                                                                &nbsp;</h1>
                                                        </td>
                                                        <td>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td valign="top" align="center" style="height: 41px">
                                                        </td>
                                                        <td style="width: 1010px; height: 41px;" valign="top">
                                                        </td>
                                                        <td valign="top" style="height: 41px">
                                                        </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                            <p>
                                            </p>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                        <td valign="middle" align="center" width="250" rowspan="2">
                            <span style="color: #ffffff">
                                <h1>
                                    &nbsp;</h1>
                            </span>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 1034px; height: 13px" bgcolor="#ffffff">
                        </td>
                    </tr>
                </tbody>
            </table>

</asp:Content>
