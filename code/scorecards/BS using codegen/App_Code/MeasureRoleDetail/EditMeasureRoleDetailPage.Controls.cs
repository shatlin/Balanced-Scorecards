
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// EditMeasureRoleDetailPage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.EditMeasureRoleDetailPage
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
    
    
// Base class for the MeasureRoleDetailRecordControl control on the EditMeasureRoleDetailPage page.
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
        
                this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MeasureId.UniqueID + "&DFKA=MeasureName";
                this.MeasureIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MeasureIdAddRecordLink.Click += new ImageClickEventHandler(MeasureIdAddRecordLink_Click);
                this.MonthIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MonthId.UniqueID + "&DFKA=MonthName";
                this.MonthIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MonthIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MonthIdAddRecordLink.Click += new ImageClickEventHandler(MonthIdAddRecordLink_Click);
                this.YearIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.YearId.UniqueID + "&DFKA=YearValue";
                this.YearIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.YearIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.YearIdAddRecordLink.Click += new ImageClickEventHandler(YearIdAddRecordLink_Click);
              this.MeasureId.SelectedIndexChanged += new EventHandler(MeasureId_SelectedIndexChanged);
            
              this.OrgRoleId.SelectedIndexChanged += new EventHandler(OrgRoleId_SelectedIndexChanged);
            
              this.MonthId.SelectedIndexChanged += new EventHandler(MonthId_SelectedIndexChanged);
            
              this.YearId.SelectedIndexChanged += new EventHandler(YearId_SelectedIndexChanged);
            
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
                this.PopulateMeasureIdDropDownList(this.DataSource.MeasureId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateMeasureIdDropDownList(MeasureRoleDetailTable.MeasureId.DefaultValue, 100);
                } else {
                this.PopulateMeasureIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.OrgRoleIdSpecified) {
                this.PopulateOrgRoleIdDropDownList(this.DataSource.OrgRoleId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateOrgRoleIdDropDownList(MeasureRoleDetailTable.OrgRoleId.DefaultValue, 100);
                } else {
                this.PopulateOrgRoleIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.ActualSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.Actual);
                this.Actual.Text = formattedValue;
                        
            } else {  
                this.Actual.Text = MeasureRoleDetailTable.Actual.Format(MeasureRoleDetailTable.Actual.DefaultValue);
            }
                    
            if (this.DataSource.TargetSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureRoleDetailTable.Target);
                this.Target.Text = formattedValue;
                        
            } else {  
                this.Target.Text = MeasureRoleDetailTable.Target.Format(MeasureRoleDetailTable.Target.DefaultValue);
            }
                    
            if (this.DataSource.MonthIdSpecified) {
                this.PopulateMonthIdDropDownList(this.DataSource.MonthId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateMonthIdDropDownList(MeasureRoleDetailTable.MonthId.DefaultValue, 100);
                } else {
                this.PopulateMonthIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.YearIdSpecified) {
                this.PopulateYearIdDropDownList(this.DataSource.YearId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateYearIdDropDownList(MeasureRoleDetailTable.YearId.DefaultValue, 100);
                } else {
                this.PopulateYearIdDropDownList(null, 100);
                }
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
        
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MeasureId), MeasureRoleDetailTable.MeasureId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId), MeasureRoleDetailTable.OrgRoleId);
                  
            this.DataSource.Parse(this.Actual.Text, MeasureRoleDetailTable.Actual);
                          
            this.DataSource.Parse(this.Target.Text, MeasureRoleDetailTable.Target);
                          
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MonthId), MeasureRoleDetailTable.MonthId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.YearId), MeasureRoleDetailTable.YearId);
                  
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
        
        public virtual WhereClause CreateWhereClause_MeasureIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_OrgRoleIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_MonthIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_YearIdDropDownList() {
            return new WhereClause();
        }
                
        // Fill the MeasureId list.
        protected virtual void PopulateMeasureIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_MeasureIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MeasureTable.MeasureName, OrderByItem.OrderDir.Asc);

                      this.MeasureId.Items.Clear();
            foreach (MeasureRecord itemValue in MeasureTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.MeasureIdSpecified) {
                    cvalue = itemValue.MeasureId.ToString();
                    fvalue = itemValue.Format(MeasureTable.MeasureName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.MeasureId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.MeasureId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.MeasureId, MeasureRoleDetailTable.MeasureId.Format(selectedValue))) {
                string fvalue = MeasureRoleDetailTable.MeasureId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.MeasureId.Items.Insert(0, item);
            }

                  
            this.MeasureId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the OrgRoleId list.
        protected virtual void PopulateOrgRoleIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_OrgRoleIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(OrgRoleTable.OrgRoleName, OrderByItem.OrderDir.Asc);

                      this.OrgRoleId.Items.Clear();
            foreach (OrgRoleRecord itemValue in OrgRoleTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.OrgRoleIdSpecified) {
                    cvalue = itemValue.OrgRoleId.ToString();
                    fvalue = itemValue.Format(OrgRoleTable.OrgRoleName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.OrgRoleId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.OrgRoleId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.OrgRoleId, MeasureRoleDetailTable.OrgRoleId.Format(selectedValue))) {
                string fvalue = MeasureRoleDetailTable.OrgRoleId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.OrgRoleId.Items.Insert(0, item);
            }

                  
            this.OrgRoleId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the MonthId list.
        protected virtual void PopulateMonthIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_MonthIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MonthTable.MonthName, OrderByItem.OrderDir.Asc);

                      this.MonthId.Items.Clear();
            foreach (MonthRecord itemValue in MonthTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.MonthIdSpecified) {
                    cvalue = itemValue.MonthId.ToString();
                    fvalue = itemValue.Format(MonthTable.MonthName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.MonthId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.MonthId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.MonthId, MeasureRoleDetailTable.MonthId.Format(selectedValue))) {
                string fvalue = MeasureRoleDetailTable.MonthId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.MonthId.Items.Insert(0, item);
            }

                  
            this.MonthId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the YearId list.
        protected virtual void PopulateYearIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_YearIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(YearTable.YearValue, OrderByItem.OrderDir.Asc);

                      this.YearId.Items.Clear();
            foreach (YearRecord itemValue in YearTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.YearIdSpecified) {
                    cvalue = itemValue.YearId.ToString();
                    fvalue = itemValue.Format(YearTable.YearValue);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.YearId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.YearId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.YearId, MeasureRoleDetailTable.YearId.Format(selectedValue))) {
                string fvalue = MeasureRoleDetailTable.YearId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.YearId.Items.Insert(0, item);
            }

                  
            this.YearId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
              // event handler for ImageButton
              public virtual void MeasureIdAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../Measure/AddMeasurePage.aspx";
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
            
              // event handler for ImageButton
              public virtual void MonthIdAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../Month/AddMonthPage.aspx";
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
            
              // event handler for ImageButton
              public virtual void YearIdAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../Year/AddYearPage.aspx";
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
            
              protected virtual void MeasureId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.MeasureId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.MeasureId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.MeasureId, MeasureRoleDetailTable.MeasureId.Format(selectedValue))) {
              string fvalue = MeasureRoleDetailTable.MeasureId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.MeasureId.Items.Insert(0, item);
              }
              }
            
              protected virtual void OrgRoleId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.OrgRoleId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.OrgRoleId, MeasureRoleDetailTable.OrgRoleId.Format(selectedValue))) {
              string fvalue = MeasureRoleDetailTable.OrgRoleId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.OrgRoleId.Items.Insert(0, item);
              }
              }
            
              protected virtual void MonthId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.MonthId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.MonthId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.MonthId, MeasureRoleDetailTable.MonthId.Format(selectedValue))) {
              string fvalue = MeasureRoleDetailTable.MonthId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.MonthId.Items.Insert(0, item);
              }
              }
            
              protected virtual void YearId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.YearId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.YearId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.YearId, MeasureRoleDetailTable.YearId.Format(selectedValue))) {
              string fvalue = MeasureRoleDetailTable.YearId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.YearId.Items.Insert(0, item);
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
           
        public System.Web.UI.WebControls.DropDownList MeasureId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureId");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdAddRecordLink");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList OrgRoleId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleId");
            }
        }
        
        public System.Web.UI.WebControls.Literal OrgRoleIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdLabel");
            }
        }
           
        public System.Web.UI.WebControls.TextBox Actual {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actual");
            }
        }
        
        public System.Web.UI.WebControls.Literal ActualLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActualLabel");
            }
        }
           
        public System.Web.UI.WebControls.TextBox Target {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Target");
            }
        }
        
        public System.Web.UI.WebControls.Literal TargetLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TargetLabel");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList MonthId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthId");
            }
        }
        
        public System.Web.UI.WebControls.Literal MonthIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MonthIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthIdAddRecordLink");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList YearId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearId");
            }
        }
        
        public System.Web.UI.WebControls.Literal YearIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton YearIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearIdAddRecordLink");
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

  