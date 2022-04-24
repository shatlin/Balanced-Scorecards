using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;
/// <summary>
/// Summary description for DisplayMsgs
/// </summary>
public class MsgColl
{
    private static Hashtable MsgHash = new Hashtable();

    public MsgColl()
    {

    }

    public enum Msg
    {
        //login page
        LoginTableHeader = 101,
        ErrorOccured = 102,
        PasswordlengthMustbesix = 103,
        PasswordConfirmationMisMatch = 104,
        BtnTextCreateEmployee = 105,
        BtnTextLogin = 106,
        PageLogin = 107,
        PageInfoLogin = 108,
        LoginFailed = 109,
        LoginTableHeaderFirstTimeuse = 110,

        //global parameters
        PageGlobalParameters = 201,
        PageInfoGlobalParameters = 202,

        //OrganizationHierarchy
        PageInfoOrgHierarchy = 301,
        PageInfoOrgHierarchyNoRows = 302,

        //ApplicationUser
        PageApplicationUser = 401,
        PageInfoApplicationUser = 402,

        //Location
        PageLocation = 501,
        PageInfoLocation = 502,

        //Scoreacard Types
        PageScorecardTypes = 601,
        PageInfoScorecardTypes = 602,

        //Scoreacard Types
        PagePeriod = 701,
        PageInfoPeriod = 702,

        //Organization Roles
        PageOrganizationRole = 801,
        PageInfoOrganizationRole = 802,

        //Competency Type
        PageCompetencyType = 901,
        PageInfoCompetencyType = 902,

        //Home Page
        PageHome = 1001,

        // Role Competency

        PageRoleCompetency=1101,
        PageinfoRoleCompetency=1102,

        //Access Deied

        PageAccessDeied = 1101,
        PageinfoAccessDeied = 1102

    }

    public static void InitialiseHashTable()
    {
        //login page
        MsgHash.Add(101, "Please enter user name and password");
        MsgHash.Add(102, "Error Occured.Please contact Administrator");
        MsgHash.Add(103, "Password must be minimum six characters");
        MsgHash.Add(104, "Password and confirmation does not match");
        MsgHash.Add(105, "Create Employee");
        MsgHash.Add(106, "Login");
        MsgHash.Add(107, "Login.aspx");
        MsgHash.Add(108, "Please enter your username and password to login to the system");
        MsgHash.Add(109, "Login Failed. Please try again");
        MsgHash.Add(110, "Please create a user name and password ");

        //global parameters

        MsgHash.Add(201, "GlobalParameters.aspx");
        MsgHash.Add(202, "In this page, You can set up the global parameters that will be used through out the system");

        //OrganizationHierarchy
        MsgHash.Add(301, "The Organization Hierarchy Can be managed Here. You can add, edit , delete Organization Elements");
        MsgHash.Add(302, "The Organization Hierarchy Can be managed Here. You can add, edit , delete Organization Elements.Organization Hierachy is not set up yet.Please use the Add Organziation Hierarchy Panel to Add a top level Organization");

        //ApplicationUser
        MsgHash.Add(401, "ApplicationUser.aspx");
        MsgHash.Add(402, "Here the Application users can be managed. Users can be added, User Details can be edited and Users can be removed from the system");
        //Location
        MsgHash.Add(501, "Location.aspx");
        MsgHash.Add(502, "This page is used to manage the locations of the organization");


        MsgHash.Add(601, "ScorecardTypes.aspx");
        MsgHash.Add(602, "The scorecard Names, their Descriptions can be managed in this page");

        MsgHash.Add(701, "Period.aspx");
        MsgHash.Add(702, "The scorecard exercise periods, the time duration for which the exercise are done is managed through this period page");

        //Organization Roles

        MsgHash.Add(801, "OrganizationRole.aspx");
        MsgHash.Add(802, " The roles played by the individuals in an orgainzation can be managed here.");

        //Competency Type
        MsgHash.Add(901, "CompetencyType.aspx");
        MsgHash.Add(902, "Competency Types can be managed in this page");

        // home page
        MsgHash.Add(1001, "home.aspx");

        // Role Competency
        MsgHash.Add(1101,"RoleComp.aspx");
        MsgHash.Add(1102,"Competencies can be assigned to roles in this page.Please select role, competency and the desired rating");

        // Access Denied

        MsgHash.Add(1201, "AccessDeied.aspx");
        MsgHash.Add(1202, "You are not authorized to view this Page. Please Login with the correct rights or use the menu items to use the features you are authorized");
    }

    public static string GetMsg(Msg enumMsgValue)
    {
        if (MsgHash.Count == 0)
        {
            InitialiseHashTable();
        }
        return (MsgHash[Convert.ToInt32(enumMsgValue)].ToString());
    }


}
