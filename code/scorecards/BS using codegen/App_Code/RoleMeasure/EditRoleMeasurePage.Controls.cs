
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// EditRoleMeasurePage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.EditRoleMeasurePage
{
  

#region "Section 1: Place your customizations here."

    
public class RoleMeasureRecordControl : BaseRoleMeasureRecordControl
{
      
        // The BaseRoleMeasureRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RoleMeasureRecordControl control on the EditRoleMeasurePage page.
// Do not modify this class. Instead override any method in RoleMeasureRecordControl.
public class BaseRoleMeasureRecordControl : BS.UI.BaseApplicationRecordControl
{
        public BaseRoleMeasureRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in RoleMeasureRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
                this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MeasureId.UniqueID + "&DFKA=MeasureName";
                this.MeasureIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MeasureIdAddRecordLink.Click += new ImageClickEventHandler(MeasureIdAddRecordLink_Click);
                this.ObjectiveIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.ObjectiveId.UniqueID + "&DFKA=ObjectiveName";
                this.ObjectiveIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.ObjectiveIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.ObjectiveIdAddRecordLink.Click += new ImageClickEventHandler(ObjectiveIdAddRecordLink_Click);
                this.PerspectiveidAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.Perspectiveid.UniqueID + "&DFKA=PerspectiveName";
                this.PerspectiveidAddRecordLink.Attributes["onClick"] = "window.open('" + this.PerspectiveidAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.PerspectiveidAddRecordLink.Click += new ImageClickEventHandler(PerspectiveidAddRecordLink_Click);
              this.OrgRoleId.SelectedIndexChanged += new EventHandler(OrgRoleId_SelectedIndexChanged);
            
              this.MeasureId.SelectedIndexChanged += new EventHandler(MeasureId_SelectedIndexChanged);
            
              this.ObjectiveId.SelectedIndexChanged += new EventHandler(ObjectiveId_SelectedIndexChanged);
            
              this.Perspectiveid.SelectedIndexChanged += new EventHandler(Perspectiveid_SelectedIndexChanged);
            
        }

        // To customize, override this method in RoleMeasureRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in RoleMeasureRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = RoleMeasureTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            if (wc == null) {
                this.DataSource = new RoleMeasureRecord();
                return;
            }

            // Retrieve the record from the database.
            RoleMeasureRecord[] recList = RoleMeasureTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "BS"));
            }

            
                    this.DataSource = RoleMeasureTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in RoleMeasureRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.OrgRoleIdSpecified) {
                this.PopulateOrgRoleIdDropDownList(this.DataSource.OrgRoleId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateOrgRoleIdDropDownList(RoleMeasureTable.OrgRoleId.DefaultValue, 100);
                } else {
                this.PopulateOrgRoleIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.MeasureIdSpecified) {
                this.PopulateMeasureIdDropDownList(this.DataSource.MeasureId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateMeasureIdDropDownList(RoleMeasureTable.MeasureId.DefaultValue, 100);
                } else {
                this.PopulateMeasureIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.ObjectiveIdSpecified) {
                this.PopulateObjectiveIdDropDownList(this.DataSource.ObjectiveId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateObjectiveIdDropDownList(RoleMeasureTable.ObjectiveId.DefaultValue, 100);
                } else {
                this.PopulateObjectiveIdDropDownList(null, 100);
                }
            }
                
            if (this.DataSource.PerspectiveidSpecified) {
                this.PopulatePerspectiveidDropDownList(this.DataSource.Perspectiveid.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulatePerspectiveidDropDownList(RoleMeasureTable.Perspectiveid.DefaultValue, 100);
                } else {
                this.PopulatePerspectiveidDropDownList(null, 100);
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

        //  To customize, override this method in RoleMeasureRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in RoleMeasureRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in RoleMeasureRecordControl to set additional fields.
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

        //  To customize, override this method in RoleMeasureRecordControl.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId), RoleMeasureTable.OrgRoleId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MeasureId), RoleMeasureTable.MeasureId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ObjectiveId), RoleMeasureTable.ObjectiveId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.Perspectiveid), RoleMeasureTable.Perspectiveid);
                  
        }

        //  To customize, override this method in RoleMeasureRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            RoleMeasureTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            
            // Retrieve the record id from the URL parameter.
              
            string recId = this.Page.Request.QueryString["RoleMeasure"];
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "BS").Replace("{URL}", "RoleMeasure"));
            }
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(RoleMeasureTable.RoleMeasureId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(RoleMeasureTable.RoleMeasureId).ToString());
            } else {
                
                wc.iAND(RoleMeasureTable.RoleMeasureId, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              
            return wc;
          
        }
        

        //  To customize, override this method in RoleMeasureRecordControl.
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
            RoleMeasureTable.DeleteRecord(pk);

          
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
        
        public virtual WhereClause CreateWhereClause_OrgRoleIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_MeasureIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_ObjectiveIdDropDownList() {
            return new WhereClause();
        }
                
        public virtual WhereClause CreateWhereClause_PerspectiveidDropDownList() {
            return new WhereClause();
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
                !MiscUtils.SetSelectedValue(this.OrgRoleId, RoleMeasureTable.OrgRoleId.Format(selectedValue))) {
                string fvalue = RoleMeasureTable.OrgRoleId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.OrgRoleId.Items.Insert(0, item);
            }

                  
            this.OrgRoleId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
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
                !MiscUtils.SetSelectedValue(this.MeasureId, RoleMeasureTable.MeasureId.Format(selectedValue))) {
                string fvalue = RoleMeasureTable.MeasureId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.MeasureId.Items.Insert(0, item);
            }

                  
            this.MeasureId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the ObjectiveId list.
        protected virtual void PopulateObjectiveIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_ObjectiveIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(ObjectiveTable.ObjectiveName, OrderByItem.OrderDir.Asc);

                      this.ObjectiveId.Items.Clear();
            foreach (ObjectiveRecord itemValue in ObjectiveTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.ObjectiveIdSpecified) {
                    cvalue = itemValue.ObjectiveId.ToString();
                    fvalue = itemValue.Format(ObjectiveTable.ObjectiveName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.ObjectiveId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.ObjectiveId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.ObjectiveId, RoleMeasureTable.ObjectiveId.Format(selectedValue))) {
                string fvalue = RoleMeasureTable.ObjectiveId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.ObjectiveId.Items.Insert(0, item);
            }

                  
            this.ObjectiveId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
        // Fill the Perspectiveid list.
        protected virtual void PopulatePerspectiveidDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_PerspectiveidDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(PerspectiveTable.PerspectiveName, OrderByItem.OrderDir.Asc);

                      this.Perspectiveid.Items.Clear();
            foreach (PerspectiveRecord itemValue in PerspectiveTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.PerspectiveIdSpecified) {
                    cvalue = itemValue.PerspectiveId.ToString();
                    fvalue = itemValue.Format(PerspectiveTable.PerspectiveName);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.Perspectiveid.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.Perspectiveid, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.Perspectiveid, RoleMeasureTable.Perspectiveid.Format(selectedValue))) {
                string fvalue = RoleMeasureTable.Perspectiveid.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.Perspectiveid.Items.Insert(0, item);
            }

                  
            this.Perspectiveid.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
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
              public virtual void ObjectiveIdAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../Objective/AddObjectivePage.aspx";
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
              public virtual void PerspectiveidAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../Perspective/AddPerspectivePage.aspx";
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
            
              protected virtual void OrgRoleId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.OrgRoleId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.OrgRoleId, RoleMeasureTable.OrgRoleId.Format(selectedValue))) {
              string fvalue = RoleMeasureTable.OrgRoleId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.OrgRoleId.Items.Insert(0, item);
              }
              }
            
              protected virtual void MeasureId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.MeasureId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.MeasureId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.MeasureId, RoleMeasureTable.MeasureId.Format(selectedValue))) {
              string fvalue = RoleMeasureTable.MeasureId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.MeasureId.Items.Insert(0, item);
              }
              }
            
              protected virtual void ObjectiveId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.ObjectiveId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.ObjectiveId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.ObjectiveId, RoleMeasureTable.ObjectiveId.Format(selectedValue))) {
              string fvalue = RoleMeasureTable.ObjectiveId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.ObjectiveId.Items.Insert(0, item);
              }
              }
            
              protected virtual void Perspectiveid_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.Perspectiveid);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.Perspectiveid, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.Perspectiveid, RoleMeasureTable.Perspectiveid.Format(selectedValue))) {
              string fvalue = RoleMeasureTable.Perspectiveid.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.Perspectiveid.Items.Insert(0, item);
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
                return (string)this.ViewState["BaseRoleMeasureRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseRoleMeasureRecordControl_Rec"] = value;
            }
        }
        
        private RoleMeasureRecord _DataSource;
        public RoleMeasureRecord DataSource {
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
        
        public System.Web.UI.WebControls.Literal RoleMeasureDialogTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureDialogTitle");
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
           
        public System.Web.UI.WebControls.DropDownList ObjectiveId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveId");
            }
        }
        
        public System.Web.UI.WebControls.Literal ObjectiveIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveIdLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ObjectiveIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveIdAddRecordLink");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList Perspectiveid {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Perspectiveid");
            }
        }
        
        public System.Web.UI.WebControls.Literal PerspectiveidLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PerspectiveidLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PerspectiveidAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PerspectiveidAddRecordLink");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            RoleMeasureRecord rec = null;
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

        public RoleMeasureRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return RoleMeasureTable.GetRecord(this.RecordUniqueId, true);
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

  