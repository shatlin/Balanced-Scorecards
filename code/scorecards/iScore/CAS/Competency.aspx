<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true"
    CodeFile="Competency.aspx.cs" Inherits="CAS_Competency" Title="Untitled Page" %>

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
                                                <td style="height: 78px" valign="top">
                                                </td>
                                                <td style="height: 78px" class="PageInfoTableBod" valign="top">
                                                    <h3>
                                                        Manage&nbsp;Competency</h3>
                                                    <h4>
                                                        <asp:Label ID="lblPageInfo" runat="server"></asp:Label></h4>
                                                </td>
                                                <td style="height: 78px" valign="top">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td valign="top">
                                                </td>
                                                <td valign="top" align="center">
                                                    <h1>
                                                        <asp:GridView ID="grdCompetency" ShowFooter="true" runat="server" 
                                                            AllowPaging="True" DataSourceID="CompetencyData" DataKeyNames="CompetencyId"
                                                            AutoGenerateColumns="False" OnRowCommand="grdCompetency_RowCommand">
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
                                 <asp:Button ID="txtAddCompetency" runat="server" CommandName="Insert" Text="Add" />
                             </FooterTemplate>
                         </asp:TemplateField>
                                                                <asp:TemplateField SortExpression="CompetencyId" HeaderText="CompetencyId" InsertVisible="False" Visible="False">
                                                                    <EditItemTemplate>
                                                                        <asp:Label runat="server" Text='<%# Eval("CompetencyId") %>' ID="Label1"></asp:Label>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label runat="server" Text='<%# Bind("CompetencyId") %>' ID="Label1"></asp:Label>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField SortExpression="CompetencyTypeId" HeaderText="Competency Type">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox runat="server" Text='<%# Bind("CompetencyTypeId") %>' ID="TextBox1"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label runat="server" Text='<%# GetCompetencyTypeName((object)Eval("CompetencyTypeId")) %>' ID="Label2"></asp:Label>
                                                                    </ItemTemplate>
                                                                     <FooterTemplate>
                                 
                                                                         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource1"
                                                                             DataTextField="CompetencyTypeName" DataValueField="CompetencyTypeId">
                                                                         </asp:DropDownList>
                             </FooterTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField SortExpression="CompetencyName" HeaderText="CompetencyName">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox runat="server" Text='<%# Bind("CompetencyName") %>' ID="TextBox2"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label runat="server" Text='<%# Bind("CompetencyName") %>' ID="Label3"></asp:Label>
                                                                    </ItemTemplate>
                                                                     <FooterTemplate>
                                 <asp:TextBox ID="txtCompetencyName" runat="server" MaxLength="50" ></asp:TextBox>
                             </FooterTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField SortExpression="CompetencyDesc" HeaderText="CompetencyDesc">
                                                                    <EditItemTemplate>
                                                                        <asp:TextBox runat="server" Text='<%# Bind("CompetencyDesc") %>' ID="TextBox3" MaxLength="1000" TextMode="MultiLine" Height="85px" Width="255px"></asp:TextBox>
                                                                    </EditItemTemplate>
                                                                    <ItemTemplate>
                                                                        <asp:Label runat="server" Text='<%# Bind("CompetencyDesc") %>' ID="Label4"></asp:Label>
                                                                    </ItemTemplate>
                                <FooterTemplate>
                                 <asp:TextBox ID="txtCompetencyDesc" runat="server" MaxLength="1000" TextMode="MultiLine" Height="85px" Width="255px"></asp:TextBox>
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
                                                        <asp:ObjectDataSource ID="CompetencyData" runat="server" 
                                                            DeleteMethod="DeleteCompetency" InsertMethod="AddCompetency" UpdateMethod="UpdateCompetency"
                                                            TypeName="Business.CAS.CompetencyBL" SelectMethod="GetCompetencies" OnInserting="CompetencyData_Inserting">
                                                            <DeleteParameters>
                                                                <asp:Parameter Type="Int32" Name="CompetencyID"></asp:Parameter>
                                                            </DeleteParameters>
                                                            <UpdateParameters>
                                                                <asp:Parameter Type="Int32" Name="CompetencyId"></asp:Parameter>
                                                                <asp:Parameter Type="Int32" Name="CompetencyTypeId"></asp:Parameter>
                                                                <asp:Parameter Type="String" Name="CompetencyName"></asp:Parameter>
                                                                <asp:Parameter Type="String" Name="CompetencyDesc"></asp:Parameter>
                                                            </UpdateParameters>
                                                            <InsertParameters>
                                                                <asp:Parameter Type="Int32" Name="CompetencyTypeId"></asp:Parameter>
                                                                <asp:Parameter Type="String" Name="CompetencyName"></asp:Parameter>
                                                                <asp:Parameter Type="String" Name="CompetencyDesc"></asp:Parameter>
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
                                                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                                                            SelectMethod="GetCompetencyTypes" TypeName="Business.CAS.CompetencyTypeBL"></asp:ObjectDataSource>
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
                                                <td valign="top" align="center">
                                                </td>
                                                <td style="width: 1010px" valign="top">
                                                </td>
                                                <td valign="top">
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
