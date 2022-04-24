<%@ Page Language="C#" MasterPageFile="~/common/iMaster.master" AutoEventWireup="true" CodeFile="Period.aspx.cs" Inherits="Setup_Period" Title="iScore-Manage Scorecard Period" %>
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
            <td valign="top" bgcolor="#FFFFFF" style="width: 1034px; height: 512px;">
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
                                            Manage Scorecard Exercise Timings</h3>
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
                                       
                                       
                                       
                                       
                                       
                                       
             
                 <asp:GridView ID="grdPeriod" runat="server" AutoGenerateColumns="False" DataKeyNames="PeriodId" 
                  
                     DataSourceID="PeriodData" AllowPaging="True" >
                     
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
                         <asp:BoundField DataField="PeriodId" HeaderText="PeriodId" InsertVisible="False"
                             ReadOnly="True" SortExpression="PeriodId" Visible="False" />
                         <asp:BoundField DataField="ScorecardTypeId" HeaderText="Scorecard Type" SortExpression="ScorecardTypeId" />
                         <asp:BoundField DataField="ExercisePeriodStartDate" HeaderText="Exercise is For (From)"
                             SortExpression="ExercisePeriodStartDate" />
                         <asp:BoundField DataField="ExercisePeriodEndDate" HeaderText="Exercise is For (To)"
                             SortExpression="ExercisePeriodEndDate" />
                         <asp:BoundField DataField="ExerciseStartDate" HeaderText="Exercise is From" SortExpression="ExerciseStartDate" />
                         <asp:BoundField DataField="ExerciseEndDate" HeaderText="Exercise Ends on" SortExpression="ExerciseEndDate" />
                         
                                             </Columns>
                 </asp:GridView>
                 <asp:ObjectDataSource ID="PeriodData" runat="server" SelectMethod="GetPeriod" TypeName="Business.Setup.PeriodBL"
                     UpdateMethod="UpdatePeriod">
                     <UpdateParameters>
                         <asp:Parameter Name="PeriodId" Type="Int32" />
                         <asp:Parameter Name="ScorecardTypeId" Type="Int32" />
                         <asp:Parameter Name="ExercisePeriodStartDate" Type="DateTime" />
                         <asp:Parameter Name="ExercisePeriodEndDate" Type="DateTime" />
                         <asp:Parameter Name="ExerciseStartDate" Type="DateTime" />
                         <asp:Parameter Name="ExerciseEndDate" Type="DateTime" />
                     </UpdateParameters>
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
                                        <h1 style="text-align: center">
                                            &nbsp;</h1></td>
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

