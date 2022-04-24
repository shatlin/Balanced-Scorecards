<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="Location.aspx.cs" Inherits="Setup_Location" Title="iScore-Manage Locations" %>
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
                                            Manage Locations of the Organization</h3>
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
                                       
                                       
                                       
                                       
                                       
                                       
                                       <asp:GridView ID="grdLocation" runat="server" AutoGenerateColumns="False" DataKeyNames="LocationId" 
                  
                     DataSourceID="LocationData" AllowPaging="True" OnRowCommand="grdLocation_RowCommand" ShowFooter="True">
                     
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
                                 <asp:Button ID="txtAddLocation" runat="server" CommandName="Insert" Text="Add Location" />
                             </FooterTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="LocationId" InsertVisible="False"  Visible="false" SortExpression="LocationId">
                             <EditItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Eval("LocationId") %>'></asp:Label>
                             </EditItemTemplate>
        
                             <ItemTemplate>
                                 <asp:Label ID="Label1" runat="server" Text='<%# Bind("LocationId") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="LocationName" SortExpression="LocationName">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("LocationName") %>' CausesValidation="True" ValidationGroup="GrdEditValGroup"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ValidationGroup="GrdEditValGroup"></asp:RequiredFieldValidator>
                             </EditItemTemplate>
                             <FooterTemplate>
                                 <asp:TextBox ID="txtLocationName" runat="server" MaxLength="50"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="valLocationName" runat="server" ControlToValidate="txtLocationName"
                                     ErrorMessage="*"></asp:RequiredFieldValidator>
                             </FooterTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label2" runat="server" Text='<%# Bind("LocationName") %>'></asp:Label>
                             </ItemTemplate>
                         </asp:TemplateField>
                         <asp:TemplateField HeaderText="LocationAddress" SortExpression="LocationAddress">
                             <EditItemTemplate>
                                 <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("LocationAddress") %>'></asp:TextBox>
                             </EditItemTemplate>
                             <FooterTemplate>
                                 <asp:TextBox ID="txtLocationAddress" runat="server" MaxLength="1000" TextMode="MultiLine"></asp:TextBox>
                             </FooterTemplate>
                             <ItemTemplate>
                                 <asp:Label ID="Label3" runat="server" Text='<%# Bind("LocationAddress") %>'></asp:Label>
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
                 <asp:ObjectDataSource ID="LocationData" runat="server" DeleteMethod="DeleteLocation"
                     InsertMethod="AddLocation" SelectMethod="GetLocation" TypeName="Business.Setup.LocationBL"
                     UpdateMethod="UpdateLocation" OnInserting="LocationData_Inserting">
                     <DeleteParameters>
                         <asp:Parameter Name="LocationID" Type="Int32" />
                     </DeleteParameters>
                     <UpdateParameters>
                         <asp:Parameter Name="LocationID" Type="Int32" />
                         <asp:Parameter Name="LocationName" Type="String" />
                         <asp:Parameter Name="LocationAddress" Type="String" />
                     </UpdateParameters>
                     <InsertParameters>
                         <asp:Parameter Name="LocationName" Type="String" />
                         <asp:Parameter Name="LocationAddress" Type="String" />
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
                                   <h1 style="text-align: center"></h1>
                                    </td>
                                    <td valign="top">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
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



</ContentTemplate>
 </asp:UpdatePanel>                 
       
       
       
</asp:Content>

