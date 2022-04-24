
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowMeasureRoleDetailPage.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;

using ReportTools.ReportCreator;
using ReportTools.Shared;

using BS.Business;
using BS.Data;
        

#endregion

  
namespace BS.UI.Controls.ShowMeasureRoleDetailPage
{
  

#region "Section 1: Place your customizations here."

    
public class MeasureRoleDetailRecordControl : BaseMeasureRoleDetailRecordControl
{
      
        // The BaseMeasureRoleDetailRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the MeasureRoleDetailRecordControl control on the ShowMeasureRoleDetailPage page.
// Do not modify this class. Instead override any method in MeasureRoleDetailRecordControl.
public class BaseMeasureRoleDetailRecordControl : BS.UI.BaseApplicationRecordControl
{
        public BaseMeasureRoleDetailRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in MeasureRoleDetailRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
              this.MeasureRoleDetailDialogEditButton.Click += new ImageClickEventHandler(MeasureRoleDetailDialogEditButton_Click);
              this.MeasureId.Click += new EventHandler(MeasureId_Click);
            
              this.MonthId.Click += new EventHandler(MonthId_Click);
            
              this.YearId.Click += new EventHandler(YearId_Click);
            
        }

        // To customize, override this method in MeasureRoleDetailRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in MeasureRoleDetailRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = MeasureRoleDetailTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            if (wc == null) {
                this.DataSource = new MeasureRoleDetailRecord();
                return;
            }

            // Retrieve the record from the database.
            MeasureRoleDetailRecord[] recList = MeasureRoleDetailTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "BS"));
            }

            
                    this.DataSource = MeasureRoleDetailTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in MeasureRoleDetailRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.MeasureIdSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.MeasureId);
                this.MeasureId.Text = formattedValue;
                        
            } else {  
                this.MeasureId.Text = MeasureRoleDetailTable.MeasureId.Format(MeasureRoleDetailTable.MeasureId.DefaultValue);
            }
                    
            if (this.DataSource.OrgRoleIdSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.OrgRoleId);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if (formattedValue != null) {
                    // If formattedValue's length exceeds FieldMaxLength value (100) then, display till FieldMaxLength value
                    if (formattedValue.Length > (int)(100)){
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, 100)) + "...";
                    }
                }           
                this.OrgRoleId.Text = formattedValue;
                        
            } else {  
                this.OrgRoleId.Text = MeasureRoleDetailTable.OrgRoleId.Format(MeasureRoleDetailTable.OrgRoleId.DefaultValue);
            }
                    
            if (this.OrgRoleId.Text == null ||
                this.OrgRoleId.Text.Trim().Length == 0) {
                this.OrgRoleId.Text = "&nbsp;";
            }
                  
            if (this.DataSource.ActualSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.Actual);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if (formattedValue != null) {
                    // If formattedValue's length exceeds FieldMaxLength value (100) then, display till FieldMaxLength value
                    if (formattedValue.Length > (int)(100)){
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, 100)) + "...";
                    }
                }           
                this.Actual.Text = formattedValue;
                        
            } else {  
                this.Actual.Text = MeasureRoleDetailTable.Actual.Format(MeasureRoleDetailTable.Actual.DefaultValue);
            }
                    
            if (this.Actual.Text == null ||
                this.Actual.Text.Trim().Length == 0) {
                this.Actual.Text = "&nbsp;";
            }
                  
            if (this.DataSource.TargetSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.Target);
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if (formattedValue != null) {
                    // If formattedValue's length exceeds FieldMaxLength value (100) then, display till FieldMaxLength value
                    if (formattedValue.Length > (int)(100)){
                        formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, 100)) + "...";
                    }
                }           
                this.Target.Text = formattedValue;
                        
            } else {  
                this.Target.Text = MeasureRoleDetailTable.Target.Format(MeasureRoleDetailTable.Target.DefaultValue);
            }
                    
            if (this.Target.Text == null ||
                this.Target.Text.Trim().Length == 0) {
                this.Target.Text = "&nbsp;";
            }
                  
            if (this.DataSource.MonthIdSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.MonthId);
                this.MonthId.Text = formattedValue;
                        
            } else {  
                this.MonthId.Text = MeasureRoleDetailTable.MonthId.Format(MeasureRoleDetailTable.MonthId.DefaultValue);
            }
                    
            if (this.DataSource.YearIdSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.YearId);
                this.YearId.Text = formattedValue;
                        
            } else {  
                this.YearId.Text = MeasureRoleDetailTable.YearId.Format(MeasureRoleDetailTable.YearId.DefaultValue);
            }
                    
            this.IsNewRecord = true;
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
        
                this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
            }

            

            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            
        }

        //  To customize, override this method in MeasureRoleDetailRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in MeasureRoleDetailRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in MeasureRoleDetailRecordControl to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in MeasureRoleDetailRecordControl.
        public virtual void GetUIData()
        {
        
        }

        //  To customize, override this method in MeasureRoleDetailRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            MeasureRoleDetailTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            
            // Retrieve the record id from the URL parameter.
              
            string recId = this.Page.Request.QueryString["MeasureRoleDetail"];
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "BS").Replace("{URL}", "MeasureRoleDetail"));
            }
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(MeasureRoleDetailTable.MeasureDetailId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(MeasureRoleDetailTable.MeasureDetailId).ToString());
            } else {
                
                wc.iAND(MeasureRoleDetailTable.MeasureDetailId, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              
            return wc;
          
        }
        

        //  To customize, override this method in MeasureRoleDetailRecordControl.
        public virtual void Validate()
        {
            // Initially empty.  Override to add custom validation.
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pk = KeyValue.XmlToKey(this.RecordUniqueId);
            MeasureRoleDetailTable.DeleteRecord(pk);

          
        }

        private void Control_PreRender(object sender, System.EventArgs e)
        {
            try {
                DbUtils.StartTransaction();

                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                    this.LoadData();
                    this.DataBind();
                }

            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
            return base.SaveViewState();
        }
        
              // event handler for ImageButton
              public virtual void MeasureRoleDetailDialogEditButton_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../MeasureRoleDetail/EditMeasureRoleDetailPage.aspx?MeasureRoleDetail={PK}";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
              }
            
              // event handler for LinkButton
              public virtual void MeasureId_Click(object sender, EventArgs args)
              {
              
            string url = @"../Measure/ShowMeasurePage.aspx?Measure={MeasureRoleDetailRecordControl:FK:FK_MeasureAppUserDetail_Measure}";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
              }
            
              // event handler for LinkButton
              public virtual void MonthId_Click(object sender, EventArgs args)
              {
              
            string url = @"../Month/ShowMonthPage.aspx?Month={MeasureRoleDetailRecordControl:FK:FK_MeasureAppUserDetail_Month}";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
              }
            
              // event handler for LinkButton
              public virtual void YearId_Click(object sender, EventArgs args)
              {
              
            string url = @"../Year/ShowYearPage.aspx?Year={MeasureRoleDetailRecordControl:FK:FK_MeasureAppUserDetail_Year1}";
            bool shouldRedirect = true;
            string TargetKey = null;
            string DFKA = null;
            string id = null;
            string value = null;
            try {
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",false);
                url = this.Page.ModifyRedirectUrl(url, "",false);
                        this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                shouldRedirect = false;
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
                this.Page.Response.Redirect(url);
            }
        
            else if (TargetKey != null && !shouldRedirect){
            this.Page.ShouldSaveControlsToSession = true ; 
            this.Page.CloseWindow(true);
            }
        
              }
            
        private bool _IsNewRecord = true;
        public virtual bool IsNewRecord {
            get {
                return this._IsNewRecord;
            }
            set {
                this._IsNewRecord = value;
            }
        }

        private bool _DataChanged = false;
        public virtual bool DataChanged {
            get {
                return this._DataChanged;
            }
            set {
                this._DataChanged = value;
            }
        }

        private bool _ResetData = false;
        public virtual bool ResetData {
            get {
                return (this._ResetData);
            }
            set {
                this._ResetData = value;
            }
        }
        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseMeasureRoleDetailRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseMeasureRoleDetailRecordControl_Rec"] = value;
            }
        }
        
        private MeasureRoleDetailRecord _DataSource;
        public MeasureRoleDetailRecord DataSource {
            get {
                return (this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal MeasureRoleDetailDialogTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailDialogTitle");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureRoleDetailDialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailDialogEditButton");
            }
        }
           
        public System.Web.UI.WebControls.LinkButton MeasureId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureId");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdLabel");
            }
        }
           
        public System.Web.UI.WebControls.Literal OrgRoleId {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleId");
            }
        }
        
        public System.Web.UI.WebControls.Literal OrgRoleIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdLabel");
            }
        }
           
        public System.Web.UI.WebControls.Literal Actual {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actual");
            }
        }
        
        public System.Web.UI.WebControls.Literal ActualLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActualLabel");
            }
        }
           
        public System.Web.UI.WebControls.Literal Target {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Target");
            }
        }
        
        public System.Web.UI.WebControls.Literal TargetLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TargetLabel");
            }
        }
           
        public System.Web.UI.WebControls.LinkButton MonthId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthId");
            }
        }
        
        public System.Web.UI.WebControls.Literal MonthIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthIdLabel");
            }
        }
           
        public System.Web.UI.WebControls.LinkButton YearId {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearId");
            }
        }
        
        public System.Web.UI.WebControls.Literal YearIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearIdLabel");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            MeasureRoleDetailRecord rec = null;
            try {
                rec = this.GetRecord();
            }
            catch (Exception ex) {
                // Do Nothing
            }
            
      if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "BS"));
            }
    
        return ModifyRedirectUrl(url, arg, rec, bEncrypt);
      
        }

        public MeasureRoleDetailRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return MeasureRoleDetailTable.GetRecord(this.RecordUniqueId, true);
            }
            
            // Localization.
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "BS"));
          
        }

        public BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion
    
  
}

  