﻿
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// AddYearPage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.AddYearPage
{
  

#region "Section 1: Place your customizations here."

    
public class MeasureRoleDetailTableControlRow : BaseMeasureRoleDetailTableControlRow
{
      
        // The BaseMeasureRoleDetailTableControlRow implements code for a ROW within the
        // the MeasureRoleDetailTableControl table.  The BaseMeasureRoleDetailTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of MeasureRoleDetailTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class MeasureRoleDetailTableControl : BaseMeasureRoleDetailTableControl
{
        // The BaseMeasureRoleDetailTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The MeasureRoleDetailTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class YearRecordControl : BaseYearRecordControl
{
      
        // The BaseYearRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the MeasureRoleDetailTableControlRow control on the AddYearPage page.
// Do not modify this class. Instead override any method in MeasureRoleDetailTableControlRow.
public class BaseMeasureRoleDetailTableControlRow : BS.UI.BaseApplicationRecordControl
{
        public BaseMeasureRoleDetailTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in MeasureRoleDetailTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
              this.MeasureRoleDetailRecordRowDeleteButton.Click += new ImageClickEventHandler(MeasureRoleDetailRecordRowDeleteButton_Click);
                this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MeasureId.UniqueID + "&DFKA=MeasureName";
                this.MeasureIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MeasureIdAddRecordLink.Click += new ImageClickEventHandler(MeasureIdAddRecordLink_Click);
                this.MonthIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MonthId.UniqueID + "&DFKA=MonthName";
                this.MonthIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MonthIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MonthIdAddRecordLink.Click += new ImageClickEventHandler(MonthIdAddRecordLink_Click);
              this.MeasureId.SelectedIndexChanged += new EventHandler(MeasureId_SelectedIndexChanged);
            
              this.OrgRoleId.SelectedIndexChanged += new EventHandler(OrgRoleId_SelectedIndexChanged);
            
              this.MonthId.SelectedIndexChanged += new EventHandler(MonthId_SelectedIndexChanged);
            
        }

        // To customize, override this method in MeasureRoleDetailTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.MeasureRoleDetailRecordRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "BS") + "'));");
        }

        // Read data from database. To customize, override this method in MeasureRoleDetailTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = MeasureRoleDetailTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseMeasureRoleDetailTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new MeasureRoleDetailRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in MeasureRoleDetailTableControlRow.
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
                
            this.IsNewRecord = true;
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
        
                this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
            }

            

            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            
        }

        //  To customize, override this method in MeasureRoleDetailTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // Year in YearRecordControl is One To Many to MeasureRoleDetailTableControl.
                    
            // Setup the parent id in the record.
            YearRecordControl recYearRecordControl = (YearRecordControl)this.Page.FindControlRecursively("YearRecordControl");
            if (recYearRecordControl != null && recYearRecordControl.DataSource == null) {
                // Load the record if it is not loaded yet.
                recYearRecordControl.LoadData();
            }
            if (recYearRecordControl == null || recYearRecordControl.DataSource == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "BS"));
            }
                    
            this.DataSource.YearId = recYearRecordControl.DataSource.YearId;
            
            // 2. Validate the data.  Override in MeasureRoleDetailTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in MeasureRoleDetailTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((MeasureRoleDetailTableControl)MiscUtils.GetParentControlObject(this, "MeasureRoleDetailTableControl")).DataChanged = true;
                ((MeasureRoleDetailTableControl)MiscUtils.GetParentControlObject(this, "MeasureRoleDetailTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in MeasureRoleDetailTableControlRow.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MeasureId), MeasureRoleDetailTable.MeasureId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId), MeasureRoleDetailTable.OrgRoleId);
                  
            this.DataSource.Parse(this.Actual.Text, MeasureRoleDetailTable.Actual);
                          
            this.DataSource.Parse(this.Target.Text, MeasureRoleDetailTable.Target);
                          
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MonthId), MeasureRoleDetailTable.MonthId);
                  
        }

        //  To customize, override this method in MeasureRoleDetailTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        

        //  To customize, override this method in MeasureRoleDetailTableControlRow.
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

          
            ((MeasureRoleDetailTableControl)MiscUtils.GetParentControlObject(this, "MeasureRoleDetailTableControl")).DataChanged = true;
            ((MeasureRoleDetailTableControl)MiscUtils.GetParentControlObject(this, "MeasureRoleDetailTableControl")).ResetData = true;
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
                
              // event handler for ImageButton
              public virtual void MeasureRoleDetailRecordRowDeleteButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        MeasureRoleDetailTableControl tc= ((MeasureRoleDetailTableControl)MiscUtils.GetParentControlObject(this, "MeasureRoleDetailTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((MeasureRoleDetailTableControlRow)this);
                    }
                    this.Visible = false;
                }
              
            }
                this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
    
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
                return (string)this.ViewState["BaseMeasureRoleDetailTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseMeasureRoleDetailTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.CheckBox MeasureRoleDetailRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureRoleDetailRecordRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailRecordRowDeleteButton");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList MeasureId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureId");
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
           
        public System.Web.UI.WebControls.TextBox Actual {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Actual");
            }
        }
           
        public System.Web.UI.WebControls.TextBox Target {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Target");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList MonthId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthId");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MonthIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthIdAddRecordLink");
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

  
// Base class for the MeasureRoleDetailTableControl control on the AddYearPage page.
// Do not modify this class. Instead override any method in MeasureRoleDetailTableControl.
public class BaseMeasureRoleDetailTableControl : BS.UI.BaseApplicationTableControl
{
        public BaseMeasureRoleDetailTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.MeasureRoleDetailPagination.FirstPage.Click += new ImageClickEventHandler(MeasureRoleDetailPagination_FirstPage_Click);
              this.MeasureRoleDetailPagination.LastPage.Click += new ImageClickEventHandler(MeasureRoleDetailPagination_LastPage_Click);
              this.MeasureRoleDetailPagination.NextPage.Click += new ImageClickEventHandler(MeasureRoleDetailPagination_NextPage_Click);
              this.MeasureRoleDetailPagination.PageSizeButton.Click += new EventHandler(MeasureRoleDetailPagination_PageSizeButton_Click);
            
              this.MeasureRoleDetailPagination.PreviousPage.Click += new ImageClickEventHandler(MeasureRoleDetailPagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.MeasureIdLabel1.Click += new EventHandler(MeasureIdLabel1_Click);
            
              this.OrgRoleIdLabel1.Click += new EventHandler(OrgRoleIdLabel1_Click);
            
              this.ActualLabel.Click += new EventHandler(ActualLabel_Click);
            
              this.TargetLabel.Click += new EventHandler(TargetLabel_Click);
            
              this.MonthIdLabel.Click += new EventHandler(MonthIdLabel_Click);
            

            // Setup the button events.
        
              this.MeasureRoleDetailAddButton.Click += new ImageClickEventHandler(MeasureRoleDetailAddButton_Click);
              this.MeasureRoleDetailDeleteButton.Click += new ImageClickEventHandler(MeasureRoleDetailDeleteButton_Click);
              this.MeasureRoleDetailResetButton.Click += new ImageClickEventHandler(MeasureRoleDetailResetButton_Click);

            // Setup the filter and search events.
        
            this.MeasureIdFilter.SelectedIndexChanged += new EventHandler(MeasureIdFilter_SelectedIndexChanged);
            this.OrgRoleIdFilter.SelectedIndexChanged += new EventHandler(OrgRoleIdFilter_SelectedIndexChanged);
            if (!this.Page.IsPostBack && this.InSession(this.MeasureIdFilter)) {
                this.MeasureIdFilter.Items.Add(new ListItem(this.GetFromSession(this.MeasureIdFilter), this.GetFromSession(this.MeasureIdFilter)));
                this.MeasureIdFilter.SelectedValue = this.GetFromSession(this.MeasureIdFilter);
            }
            if (!this.Page.IsPostBack && this.InSession(this.OrgRoleIdFilter)) {
                this.OrgRoleIdFilter.Items.Add(new ListItem(this.GetFromSession(this.OrgRoleIdFilter), this.GetFromSession(this.OrgRoleIdFilter)));
                this.OrgRoleIdFilter.SelectedValue = this.GetFromSession(this.OrgRoleIdFilter);
            }

            // Control Initializations.
            // Initialize the table's current sort order.
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            } else {
                this.CurrentSortOrder = new OrderBy(true, true);
        
            }

    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
            this.ClearControlsFromSession();
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
                // Show confirmation message on Click
                this.MeasureRoleDetailDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "BS") + "'));");
        }

        // Read data from database. Returns an array of records that can be assigned
        // to the DataSource table control property.
        public virtual void LoadData()
        {
            try {
            
                // The WHERE clause will be empty when displaying all records in table.
                WhereClause wc = CreateWhereClause();
                if (wc != null && !wc.RunQuery) {
                    // Initialize an empty array of records
                    ArrayList alist = new ArrayList(0);
                    this.DataSource = (MeasureRoleDetailRecord[])(alist.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord")));
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = MeasureRoleDetailTable.GetRecordCount(wc);

                // Go to the last page.
                if (this.TotalPages <= 0 || this.PageIndex < 0) {
                    this.PageIndex = 0;
                } else if (this.DisplayLastPage || this.PageIndex >= this.TotalPages) {
                    this.PageIndex = this.TotalPages - 1;
                }

                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.TotalRecords <= 0) {
                    // Initialize an empty array of records
                    ArrayList alist = new ArrayList(0);
                    this.DataSource = (MeasureRoleDetailRecord[])(alist.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (MeasureRoleDetailTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (MeasureRoleDetailRecord[])(postdata.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = MeasureRoleDetailTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
                }

                // Initialize the page and grand totals. now
            
            } catch (Exception ex) {
                throw ex;
            } finally {
                // Add records to the list.
                this.AddNewRecords();
            }
        }

        // Populate the UI controls.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();

            // Setup the pagination controls.
            BindPaginationControls();

            // Populate all filters data.
        
            this.PopulateMeasureIdFilter(MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), 500);
            this.PopulateOrgRoleIdFilter(MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), 500);

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("MeasureRoleDetailTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                MeasureRoleDetailTableControlRow recControl = (MeasureRoleDetailTableControlRow)(repItem.FindControl("MeasureRoleDetailTableControlRow"));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                recControl.Visible = !this.InDeletedRecordIds(recControl);
                index += 1;
            }
        }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(MeasureRoleDetailTable.MeasureId, this.DataSource);
            this.Page.PregetDfkaRecords(MeasureRoleDetailTable.OrgRoleId, this.DataSource);
            this.Page.PregetDfkaRecords(MeasureRoleDetailTable.MonthId, this.DataSource);
        }
         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for MeasureRoleDetailTableControl pagination.
        
            this.MeasureRoleDetailPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.MeasureRoleDetailPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.MeasureRoleDetailPagination.LastPage.Enabled = false;
            }
          
            this.MeasureRoleDetailPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.MeasureRoleDetailPagination.NextPage.Enabled = false;
            }
          
            this.MeasureRoleDetailPagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.MeasureRoleDetailPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.MeasureRoleDetailPagination.CurrentPage.Text = "0";
            }
            this.MeasureRoleDetailPagination.PageSize.Text = this.PageSize.ToString();
            this.MeasureRoleDetailTotalItems.Text = this.TotalRecords.ToString();
            this.MeasureRoleDetailPagination.TotalItems.Text = this.TotalRecords.ToString();
            this.MeasureRoleDetailPagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (MeasureRoleDetailTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    recCtl.Delete();
                } else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }
            
            this.DataChanged = true;
            this.ResetData = true;
        }

        public virtual OrderBy CreateOrderBy()
        {
            return this.CurrentSortOrder;
        }

        // This CreateWhereClause is used for loading the data.
        public virtual WhereClause CreateWhereClause()
        {
            MeasureRoleDetailTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        YearRecordControl parentRecordControl = (YearRecordControl)(this.Page.FindControlRecursively("YearRecordControl"));
            YearRecord parentRec = parentRecordControl.GetRecord();
            if (parentRec == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:ParentNotInitialized", "BS"));
            }
           
            if (parentRec.YearIdSpecified) {
                wc.iAND(MeasureRoleDetailTable.YearId, BaseFilter.ComparisonOperator.EqualsTo, parentRec.YearId.ToString());
            } else {
                wc.RunQuery = false;
                return wc;
            }
            
            if (MiscUtils.IsValueSelected(this.MeasureIdFilter)) {
                wc.iAND(MeasureRoleDetailTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), false, false);
            }
                      
            if (MiscUtils.IsValueSelected(this.OrgRoleIdFilter)) {
                wc.iAND(MeasureRoleDetailTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), false, false);
            }
                      
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            MeasureRoleDetailTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            String recId  = (String)HttpContext.Current.Session["SelectedID"];
            if (recId != null) {
                if (KeyValue.IsXmlKey(recId)) {
                    KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                    wc.iAND(MeasureRoleDetailTable.YearId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(YearTable.YearId).ToString());
                
                } else {
                
                    wc.iAND(MeasureRoleDetailTable.YearId, BaseFilter.ComparisonOperator.EqualsTo, recId);
              
                }
            }
              
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            String MeasureIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "MeasureIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(MeasureIdFilterSelectedValue)) {
                wc.iAND(MeasureRoleDetailTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MeasureIdFilterSelectedValue, false, false);
            }
                      
            String OrgRoleIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "OrgRoleIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(OrgRoleIdFilterSelectedValue)) {
                wc.iAND(MeasureRoleDetailTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, OrgRoleIdFilterSelectedValue, false, false);
            }
                      
            return wc;
        }
          
        // Formats the result Item and adds it to the list of suggestions.
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
              int index  = StringUtils.InvariantLCase(resultItem).IndexOf(StringUtils.InvariantLCase(prefixText));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                 // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = "..." + resultItem.Substring(index, resultItem.Length - index);
                        }
                    } else {
                        if (index == 0) {
                          itemToAdd = resultItem.Substring(index, (columnLength - 3)) + "...";
                        } else {
                            // Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." + resultItem.Substring(index, (columnLength - 6)) + "...";
                        }
                    }
                } else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    } else {
                        // Sanity check at end of the string
                        if ((index + prefixText.Length) == columnLength) {
                            itemToAdd = "..." + resultItem.Substring((index - columnLength), index);
                        } else if ((resultItem.Length - index) < subStringBeginIndex) {
                            //  Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd = "..." + resultItem.Substring(resultItem.Length - columnLength, resultItem.Length);
                        } else if (index <= subStringBeginIndex) {
                            // Sanity chet at beginning of the string
                            itemToAdd = resultItem.Substring(0, columnLength) + "...";
                        } else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = "..." + resultItem.Substring(index - subStringBeginIndex, columnLength) + "...";
                        }
                    }
                } else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        if (index == resultItem.Length) {   //Make decision to append "..."
                            itemToAdd = resultItem.Substring(0, index);
                        } else {
                            itemToAdd = resultItem.Substring(0, index) + "...";
                        }
                    } else if (index == resultItem.Length) {
                        itemToAdd = "..." + resultItem.Substring(index - (columnLength - 3), columnLength - 3);
                    } else {
                        // Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                        itemToAdd = "..." + resultItem.Substring(index - (columnLength - 6), (columnLength - 6)) + "...";
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.InvariantCultureIgnoreCase);
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {
                    if (itemToAdd.EndsWith("...")) {
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...";
                    }
                    else {
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);
                    }
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    if (itemToAdd.StartsWith("...")) {
                        itemToAdd = "..." + itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                    }
                    else {
                        itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                    }
                }

                if (itemToAdd!= null && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.MeasureRoleDetailPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.MeasureRoleDetailPagination.PageSize.Text);
                } catch (Exception ex) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
            ArrayList newRecordList = new ArrayList();

            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("MeasureRoleDetailTableControlRepeater"));
                int index = 0;

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    MeasureRoleDetailTableControlRow recControl = (MeasureRoleDetailTableControlRow)(repItem.FindControl("MeasureRoleDetailTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        MeasureRoleDetailRecord rec = new MeasureRoleDetailRecord();
        
                        if (MiscUtils.IsValueSelected(recControl.MeasureId)) {
                            rec.Parse(recControl.MeasureId.SelectedItem.Value, MeasureRoleDetailTable.MeasureId);
                        }
                        if (MiscUtils.IsValueSelected(recControl.OrgRoleId)) {
                            rec.Parse(recControl.OrgRoleId.SelectedItem.Value, MeasureRoleDetailTable.OrgRoleId);
                        }
                        if (recControl.Actual.Text != "") {
                            rec.Parse(recControl.Actual.Text, MeasureRoleDetailTable.Actual);
                        }
                        if (recControl.Target.Text != "") {
                            rec.Parse(recControl.Target.Text, MeasureRoleDetailTable.Target);
                        }
                        if (MiscUtils.IsValueSelected(recControl.MonthId)) {
                            rec.Parse(recControl.MonthId.SelectedItem.Value, MeasureRoleDetailTable.MonthId);
                        }
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new MeasureRoleDetailRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (MeasureRoleDetailRecord[])(finalList.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(MeasureRoleDetailTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(MeasureRoleDetailTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
        // Get the filters' data for MeasureIdFilter.
        protected virtual void PopulateMeasureIdFilter(string selectedValue, int maxItems)
        {
              
            //Setup the WHERE clause.
            WhereClause wc = new WhereClause();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MeasureTable.MeasureName, OrderByItem.OrderDir.Asc);

            string noValueFormat = Page.GetResourceValue("Txt:Other", "BS");

            this.MeasureIdFilter.Items.Clear();
            foreach (MeasureRecord itemValue in MeasureTable.GetRecords(wc, orderBy, 0, maxItems))
            {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = noValueFormat;
                if (itemValue.MeasureIdSpecified) {
                    cvalue = itemValue.MeasureId.ToString();
                    fvalue = itemValue.Format(MeasureTable.MeasureName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                if (this.MeasureIdFilter.Items.IndexOf(item) < 0) {
                    this.MeasureIdFilter.Items.Add(item);
                }
            }
                
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.MeasureIdFilter, selectedValue);

            // Add the All item.
            this.MeasureIdFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "BS"), "--ANY--"));
        }
            
        // Get the filters' data for OrgRoleIdFilter.
        protected virtual void PopulateOrgRoleIdFilter(string selectedValue, int maxItems)
        {
              
            //Setup the WHERE clause.
            WhereClause wc = new WhereClause();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(OrgRoleTable.OrgRoleName, OrderByItem.OrderDir.Asc);

            string noValueFormat = Page.GetResourceValue("Txt:Other", "BS");

            this.OrgRoleIdFilter.Items.Clear();
            foreach (OrgRoleRecord itemValue in OrgRoleTable.GetRecords(wc, orderBy, 0, maxItems))
            {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = noValueFormat;
                if (itemValue.OrgRoleIdSpecified) {
                    cvalue = itemValue.OrgRoleId.ToString();
                    fvalue = itemValue.Format(OrgRoleTable.OrgRoleName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                if (this.OrgRoleIdFilter.Items.IndexOf(item) < 0) {
                    this.OrgRoleIdFilter.Items.Add(item);
                }
            }
                
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.OrgRoleIdFilter, selectedValue);

            // Add the All item.
            this.OrgRoleIdFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "BS"), "--ANY--"));
        }
                          
        // Create a where clause for the filter MeasureIdFilter.
        public virtual WhereClause CreateWhereClause_MeasureIdFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.OrgRoleIdFilter)) {
                wc.iAND(MeasureRoleDetailTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), false, false);
            }
                      
            return wc;
        }
                          
        // Create a where clause for the filter OrgRoleIdFilter.
        public virtual WhereClause CreateWhereClause_OrgRoleIdFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.MeasureIdFilter)) {
                wc.iAND(MeasureRoleDetailTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), false, false);
            }
                      
            return wc;
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
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();

            // Save filter controls to values to session.
        
            this.SaveToSession(this.MeasureIdFilter, this.MeasureIdFilter.SelectedValue);
            this.SaveToSession(this.OrgRoleIdFilter, this.OrgRoleIdFilter.SelectedValue);
            
            // Save table control properties to the session.
            if (this.CurrentSortOrder != null) {
                this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
            }
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
        
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
            this.SaveToSession("MeasureIdFilter_Ajax", this.MeasureIdFilter.SelectedValue);
            this.SaveToSession("OrgRoleIdFilter_Ajax", this.OrgRoleIdFilter.SelectedValue);
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.MeasureIdFilter);
            this.RemoveFromSession(this.OrgRoleIdFilter);
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["MeasureRoleDetailTableControl_OrderBy"];
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            } else {
                this.CurrentSortOrder = new OrderBy(true, true);
            }

            if (ViewState["Page_Index"] != null) {
                this.PageIndex = (int)ViewState["Page_Index"];
            }

            if (ViewState["Page_Size"] != null) {
                this.PageSize = (int)ViewState["Page_Size"];
            }
        
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
            if (this.CurrentSortOrder != null) {
                this.ViewState["MeasureRoleDetailTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
              // event handler for ImageButton
              public virtual void MeasureRoleDetailPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureRoleDetailPagination_LastPage_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureRoleDetailPagination_NextPage_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for LinkButton
              public virtual void MeasureRoleDetailPagination_PageSizeButton_Click(object sender, EventArgs args)
              {
              
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.MeasureRoleDetailPagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.MeasureRoleDetailPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureRoleDetailPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            

        // Generate the event handling functions for sorting events.
        
              // event handler for FieldSort
              public virtual void MeasureIdLabel1_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureRoleDetailTable.MeasureId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureRoleDetailTable.MeasureId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void OrgRoleIdLabel1_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureRoleDetailTable.OrgRoleId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureRoleDetailTable.OrgRoleId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void ActualLabel_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureRoleDetailTable.Actual);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureRoleDetailTable.Actual, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void TargetLabel_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureRoleDetailTable.Target);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureRoleDetailTable.Target, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void MonthIdLabel_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureRoleDetailTable.MonthId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureRoleDetailTable.MonthId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            

        // Generate the event handling functions for button events.
        
              // event handler for ImageButton
              public virtual void MeasureRoleDetailAddButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
                this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureRoleDetailDeleteButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
          
            }
                this.Page.CommitTransaction(sender);
      
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureRoleDetailResetButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
              this.MeasureIdFilter.ClearSelection();
            
              this.OrgRoleIdFilter.ClearSelection();
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By")) {
              this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              } else {
              this.CurrentSortOrder = new OrderBy(true, true);
            
            }

            this.DataChanged = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
    
            }
    
              }
            

        // Generate the event handling functions for filter and search events.
        
        // event handler for FieldFilter
        protected virtual void MeasureIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            this.DataChanged = true;
        }
            
        // event handler for FieldFilter
        protected virtual void OrgRoleIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            this.DataChanged = true;
        }
            

        // verify the processing details for these properties
        private int _PageSize;
        public int PageSize {
            get {
                return this._PageSize;
            }
            set {
                this._PageSize = value;
            }
        }

        private int _PageIndex;
        public int PageIndex {
            get {
                // _PageSize return (the PageIndex);
                return this._PageIndex;
            }
            set {
                this._PageIndex = value;
            }
        }

        private int _TotalRecords;
        public int TotalRecords {
            get {
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                }
                this._TotalRecords = value;
            }
        }

        private int _TotalPages;
        public int TotalPages {
            get {
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        private bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }

        private bool _DataChanged = false;
        public bool DataChanged {
            get {
                return this._DataChanged;
            }
            set {
                this._DataChanged = value;
            }
        }

        private bool _ResetData = false;
        public bool ResetData {
            get {
                return this._ResetData;
            }
            set {
                this._ResetData = value;
            }
        }

        private int _AddNewRecord = 0;
        public int AddNewRecord {
            get {
                return this._AddNewRecord;
            }
            set {
                this._AddNewRecord = value;
            }
        }

        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }

        private MeasureRoleDetailRecord[] _DataSource = null;
        public  MeasureRoleDetailRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal MeasureRoleDetailTableTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailTableTitle");
            }
        }
        
        public System.Web.UI.WebControls.Label MeasureRoleDetailTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailTotalItems");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList MeasureIdFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList OrgRoleIdFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal OrgRoleIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdLabel");
            }
        }
        
        public BS.UI.IPagination MeasureRoleDetailPagination {
            get {
                return (BS.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureRoleDetailAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailAddButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureRoleDetailDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureRoleDetailResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox MeasureRoleDetailToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureRoleDetailToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton MeasureIdLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OrgRoleIdLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ActualLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActualLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TargetLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TargetLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton MonthIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MonthIdLabel");
            }
        }
        
#endregion

#region "Helper Functions"
        
                public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
              
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                MeasureRoleDetailTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
                }

                MeasureRoleDetailRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
            
                return ModifyRedirectUrl(url, arg, rec, bEncrypt);
              
            }
            return url;
        }
          
        public int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (MeasureRoleDetailTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.MeasureRoleDetailRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public MeasureRoleDetailTableControlRow GetSelectedRecordControl()
        {
        MeasureRoleDetailTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public MeasureRoleDetailTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (MeasureRoleDetailTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.MeasureRoleDetailRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (MeasureRoleDetailTableControlRow[])(selectedList.ToArray(Type.GetType("BS.UI.Controls.AddYearPage.MeasureRoleDetailTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            MeasureRoleDetailTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
            }
            
            foreach (MeasureRoleDetailTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.MeasureRoleDetailRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public MeasureRoleDetailTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("MeasureRoleDetailTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                MeasureRoleDetailTableControlRow recControl = (MeasureRoleDetailTableControlRow)repItem.FindControl("MeasureRoleDetailTableControlRow");
                recList.Add(recControl);
            }

            return (MeasureRoleDetailTableControlRow[])recList.ToArray(Type.GetType("BS.UI.Controls.AddYearPage.MeasureRoleDetailTableControlRow"));
        }

        public BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  
// Base class for the YearRecordControl control on the AddYearPage page.
// Do not modify this class. Instead override any method in YearRecordControl.
public class BaseYearRecordControl : BS.UI.BaseApplicationRecordControl
{
        public BaseYearRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in YearRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
        }

        // To customize, override this method in YearRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in YearRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = YearTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            if (wc == null) {
                this.DataSource = new YearRecord();
                return;
            }

            // Retrieve the record from the database.
            YearRecord[] recList = YearTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "BS"));
            }

            
                    this.DataSource = (YearRecord)YearRecord.Copy(recList[0], false);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in YearRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.YearValueSpecified) {
                      
                string formattedValue = this.DataSource.Format(YearTable.YearValue);
                this.YearValue.Text = formattedValue;
                        
            } else {  
                this.YearValue.Text = YearTable.YearValue.Format(YearTable.YearValue.DefaultValue);
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

        //  To customize, override this method in YearRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in YearRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in YearRecordControl to set additional fields.
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

        //  To customize, override this method in YearRecordControl.
        public virtual void GetUIData()
        {
        
            bool clearDataSource = false;
            foreach(BaseColumn col in YearRecord.TableUtils.TableDefinition.Columns){
                if ((col.ColumnType == BaseColumn.ColumnTypes.Unique_Identifier)){
                    clearDataSource = true;
                }
            }

            if (clearDataSource){
                this.DataSource = new YearRecord();
            }
        
            this.DataSource.Parse(this.YearValue.Text, YearTable.YearValue);
                          
        }

        //  To customize, override this method in YearRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            YearTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Year"];
            if (recId == null || recId.Length == 0) {
                return null;
            }
                       
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(YearTable.YearId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(YearTable.YearId).ToString());
            } else {
                
                wc.iAND(YearTable.YearId, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              
            return wc;  
          
        }
        

        //  To customize, override this method in YearRecordControl.
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
            YearTable.DeleteRecord(pk);

          
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
                return (string)this.ViewState["BaseYearRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseYearRecordControl_Rec"] = value;
            }
        }
        
        private YearRecord _DataSource;
        public YearRecord DataSource {
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
        
        public System.Web.UI.WebControls.Literal YearDialogTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearDialogTitle");
            }
        }
           
        public System.Web.UI.WebControls.TextBox YearValue {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearValue");
            }
        }
        
        public System.Web.UI.WebControls.Literal YearValueLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "YearValueLabel");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            YearRecord rec = null;
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

        public YearRecord GetRecord()
        {
        
            if (this.DataSource != null) {
              return this.DataSource;
            }
            
            return new YearRecord();
          
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

  