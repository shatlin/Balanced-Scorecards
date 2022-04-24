
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using BaseClasses;
using BaseClasses.Utils;
using BaseClasses.Web.UI;
using BaseClasses.Web.UI.WebControls;
        
using BS.Business;
using BS.Data;
        
namespace BS.UI
{

  // Code-behind class for the Menu user control.
       
partial class Menu : BaseApplicationMenuControl , IMenu
{
		

#region "Section 1: Place your customizations here."    

        public Menu()
        {
            this.Initialize();
        }

        public void LoadData()
        {
            // LoadData reads database data and assigns it to UI controls.
            // Customize by adding code before or after the call to LoadData_Base()
            // or replace the call to LoadData_Base().
            LoadData_Base();
         }

#region "Ajax Functions"

        
        [System.Web.Services.WebMethod()]
        public static Object[] GetRecordFieldValue(String tableName , 
                                                    String recordID , 
                                                    String columnName, 
                                                    String title, 
                                                    bool persist, 
                                                    int popupWindowHeight, 
                                                    int popupWindowWidth, 
                                                    bool popupWindowScrollBar)
        {
            // GetRecordFieldValue gets the pop up window content from the column specified by
            // columnName in the record specified by the recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            // or replace the call to  GetRecordFieldValue_Base().

            return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }

    
        [System.Web.Services.WebMethod()]
        public static object[] GetImage(String tableName,
      
                                        String recordID, 
                                        String columnName, 
                                        String title, 
                                        bool persist, 
                                        int popupWindowHeight, 
                                        int popupWindowWidth, 
                                        bool popupWindowScrollBar)
        {
            // GetImage gets the Image url for the image in the column "columnName" and
            // in the record specified by recordID in data base table specified by tableName.
            // Customize by adding code before or after the call to  GetImage_Base()
            // or replace the call to  GetImage_Base().
            return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar);
        }
        
    
#endregion

    // Page Event Handlers - buttons, sort, links
    
              public void MeasureMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MeasureMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MeasureRoleDetailMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureRoleDetailMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureRoleDetailMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MeasureRoleDetailMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureRoleDetailMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureRoleDetailMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MeasureTypeMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureTypeMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureTypeMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MeasureTypeMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for MeasureTypeMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MeasureTypeMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MonthMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for MonthMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MonthMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void MonthMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for MonthMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          MonthMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void ObjectiveMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for ObjectiveMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          ObjectiveMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void ObjectiveMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for ObjectiveMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          ObjectiveMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void PerspectiveMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for PerspectiveMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          PerspectiveMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void PerspectiveMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for PerspectiveMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          PerspectiveMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void RoleMeasureMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for RoleMeasureMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          RoleMeasureMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void RoleMeasureMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for RoleMeasureMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          RoleMeasureMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void YearMenuItem_Click(object sender, EventArgs args)
              {
            
          // Click handler for YearMenuItem.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          YearMenuItem_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        
              public void YearMenuItemHilited_Click(object sender, EventArgs args)
              {
            
          // Click handler for YearMenuItemHilited.
          // Customize by adding code before the call or replace the call to the Base function with your own code.
          YearMenuItemHilited_Click_Base(sender, args);
          // NOTE: If the Base function redirects to another page, any code here will not be executed.
          }
        

#endregion

#region "Section 2: Do not modify this section."
        

        private void Initialize()
        {
            // Called by the class constructor to initialize event handlers for Init and Load
            // You can customize by modifying the constructor in Section 1.
            this.Init += new EventHandler(Page_InitializeEventHandlers);
            this.Load += new EventHandler(Page_Load);

            
        }

        // Handles base.Init. Registers event handler for any button, sort or links.
        // You can add additional Init handlers in Section 1.
        protected virtual void Page_InitializeEventHandlers(object sender, System.EventArgs e)
        {
            // Register the Event handler for any Events.
        
              this.MeasureMenuItem.Button.Click += new EventHandler(MeasureMenuItem_Click);
              this.MeasureMenuItemHilited.Button.Click += new EventHandler(MeasureMenuItemHilited_Click);
              this.MeasureRoleDetailMenuItem.Button.Click += new EventHandler(MeasureRoleDetailMenuItem_Click);
              this.MeasureRoleDetailMenuItemHilited.Button.Click += new EventHandler(MeasureRoleDetailMenuItemHilited_Click);
              this.MeasureTypeMenuItem.Button.Click += new EventHandler(MeasureTypeMenuItem_Click);
              this.MeasureTypeMenuItemHilited.Button.Click += new EventHandler(MeasureTypeMenuItemHilited_Click);
              this.MonthMenuItem.Button.Click += new EventHandler(MonthMenuItem_Click);
              this.MonthMenuItemHilited.Button.Click += new EventHandler(MonthMenuItemHilited_Click);
              this.ObjectiveMenuItem.Button.Click += new EventHandler(ObjectiveMenuItem_Click);
              this.ObjectiveMenuItemHilited.Button.Click += new EventHandler(ObjectiveMenuItemHilited_Click);
              this.PerspectiveMenuItem.Button.Click += new EventHandler(PerspectiveMenuItem_Click);
              this.PerspectiveMenuItemHilited.Button.Click += new EventHandler(PerspectiveMenuItemHilited_Click);
              this.RoleMeasureMenuItem.Button.Click += new EventHandler(RoleMeasureMenuItem_Click);
              this.RoleMeasureMenuItemHilited.Button.Click += new EventHandler(RoleMeasureMenuItemHilited_Click);
              this.YearMenuItem.Button.Click += new EventHandler(YearMenuItem_Click);
              this.YearMenuItemHilited.Button.Click += new EventHandler(YearMenuItemHilited_Click);
        }

        // Handles base.Load.  Read database data and put into the UI controls.
        // You can add additional Load handlers in Section 1.
        protected virtual void Page_Load(object sender, EventArgs e)
        {
        

            // Load data only when displaying the page for the first time
            if ((!this.IsPostBack)) {   
        

        // Read the data for all controls on the page.
        // To change the behavior, override the DataBind method for the individual
        // record or table UI controls.
        this.LoadData();
    }
    }

    public static object[] GetRecordFieldValue_Base(String tableName , 
                                                    String recordID , 
                                                    String columnName, 
                                                    String title, 
                                                    bool persist, 
                                                    int popupWindowHeight, 
                                                    int popupWindowWidth, 
                                                    bool popupWindowScrollBar)
    {
        string content =  NetUtils.EncodeStringForHtmlDisplay(BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)) ;
        // returnValue is an array of string values.
        // returnValue(0) represents title of the pop up window.
        // returnValue(1) represents content ie, image url.
        // retrunValue(2) represents whether pop up window should be made persistant
        // or it should closes as soon as mouse moved out.
        // returnValue(3), (4) represents pop up window height and width respectivly
        // ' returnValue(5) represents whether pop up window should contain scroll bar.
        // (0),(2),(3) and (4) is initially set as pass through attribute.
        // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        object[] returnValue = new object[6];
        returnValue[0] = title;
        returnValue[1] = content;
        returnValue[2] = persist;
        returnValue[3] = popupWindowWidth;
        returnValue[4] = popupWindowHeight;
        returnValue[5] = popupWindowScrollBar;
        return returnValue;
    }

    public static object[] GetImage_Base(String tableName, 
                                          String recordID, 
                                          String columnName, 
                                          String title, 
                                          bool persist, 
                                          int popupWindowHeight, 
                                          int popupWindowWidth, 
                                          bool popupWindowScrollBar)
    {
        string  content= "<IMG src =" + "\"../Shared/ExportFieldValue.aspx?Table=" + tableName + "&Field=" + columnName + "&Record=" + recordID + "\"/>";
        // returnValue is an array of string values.
        // returnValue(0) represents title of the pop up window.
        // returnValue(1) represents content ie, image url.
        // retrunValue(2) represents whether pop up window should be made persistant
        // or it should closes as soon as mouse moved out.
        // returnValue(3), (4) represents pop up window height and width respectivly
        // returnValue(5) represents whether pop up window should contain scroll bar.
        // (0),(2),(3), (4) and (5) is initially set as pass through attribute.
        // They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        object[] returnValue = new object[6];
        returnValue[0] = title;
        returnValue[1] = content;
        returnValue[2] = persist;
        returnValue[3] = popupWindowWidth;
        returnValue[4] = popupWindowHeight;
        returnValue[5] = popupWindowScrollBar;
        return returnValue;
    }
    

    // Load data from database into UI controls.
    // Modify LoadData in Section 1 above to customize.  Or override DataBind() in
    // the individual table and record controls to customize.
    public void LoadData_Base()
    {
    
        }

        // Write out event methods for the page events
        
              // event handler for Button with Layout
              public void MeasureMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Measure/ShowMeasureTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MeasureMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Measure/ShowMeasureTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MeasureRoleDetailMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../MeasureRoleDetail/ShowMeasureRoleDetailTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MeasureRoleDetailMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../MeasureRoleDetail/ShowMeasureRoleDetailTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MeasureTypeMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../MeasureType/ShowMeasureTypeTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MeasureTypeMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../MeasureType/ShowMeasureTypeTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MonthMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Month/ShowMonthTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void MonthMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Month/ShowMonthTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void ObjectiveMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Objective/ShowObjectiveTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void ObjectiveMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Objective/ShowObjectiveTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void PerspectiveMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Perspective/ShowPerspectiveTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void PerspectiveMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Perspective/ShowPerspectiveTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void RoleMeasureMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../RoleMeasure/ShowRoleMeasureTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void RoleMeasureMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../RoleMeasure/ShowRoleMeasureTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void YearMenuItem_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Year/ShowYearTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
              // event handler for Button with Layout
              public void YearMenuItemHilited_Click_Base(object sender, EventArgs args)
              {
              
            string url = @"../Year/ShowYearTablePage.aspx";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = ((BaseApplicationPage)this.Page).ModifyRedirectUrl(url, "",false);
                        ((BaseApplicationPage)this.Page).CommitTransaction(sender);
      
            } catch (Exception ex) {
                ((BaseApplicationPage)this.Page).RollBackTransaction(sender);
                shouldRedirect = false;
                ((BaseApplicationPage)this.Page).ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                ((BaseApplicationPage)this.Page).Response.Redirect(url);
            }
        
              }
            
#region Interface Properties
          
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item MeasureMenuItem {
            get {
                return this._MeasureMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted MeasureMenuItemHilited {
            get {
                return this._MeasureMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item MeasureRoleDetailMenuItem {
            get {
                return this._MeasureRoleDetailMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted MeasureRoleDetailMenuItemHilited {
            get {
                return this._MeasureRoleDetailMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item MeasureTypeMenuItem {
            get {
                return this._MeasureTypeMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted MeasureTypeMenuItemHilited {
            get {
                return this._MeasureTypeMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item MonthMenuItem {
            get {
                return this._MonthMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted MonthMenuItemHilited {
            get {
                return this._MonthMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item ObjectiveMenuItem {
            get {
                return this._ObjectiveMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted ObjectiveMenuItemHilited {
            get {
                return this._ObjectiveMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item PerspectiveMenuItem {
            get {
                return this._PerspectiveMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted PerspectiveMenuItemHilited {
            get {
                return this._PerspectiveMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item RoleMeasureMenuItem {
            get {
                return this._RoleMeasureMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted RoleMeasureMenuItemHilited {
            get {
                return this._RoleMeasureMenuItemHilited;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item YearMenuItem {
            get {
                return this._YearMenuItem;
            }
        }
                
        [Bindable(true),
        Category("Behavior"),
        DefaultValue(""),
        NotifyParentProperty(true),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IMenu_Item_Highlighted YearMenuItemHilited {
            get {
                return this._YearMenuItemHilited;
            }
        }
                
#endregion
        
#endregion

  

}
  
}

  