
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// AddPerspectivePage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.AddPerspectivePage
{
  

#region "Section 1: Place your customizations here."

    
public class RoleMeasureTableControlRow : BaseRoleMeasureTableControlRow
{
      
        // The BaseRoleMeasureTableControlRow implements code for a ROW within the
        // the RoleMeasureTableControl table.  The BaseRoleMeasureTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of RoleMeasureTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class RoleMeasureTableControl : BaseRoleMeasureTableControl
{
        // The BaseRoleMeasureTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The RoleMeasureTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class PerspectiveRecordControl : BasePerspectiveRecordControl
{
      
        // The BasePerspectiveRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the RoleMeasureTableControlRow control on the AddPerspectivePage page.
// Do not modify this class. Instead override any method in RoleMeasureTableControlRow.
public class BaseRoleMeasureTableControlRow : BS.UI.BaseApplicationRecordControl
{
        public BaseRoleMeasureTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in RoleMeasureTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
              this.RoleMeasureRecordRowDeleteButton.Click += new ImageClickEventHandler(RoleMeasureRecordRowDeleteButton_Click);
                this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MeasureId.UniqueID + "&DFKA=MeasureName";
                this.MeasureIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MeasureIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MeasureIdAddRecordLink.Click += new ImageClickEventHandler(MeasureIdAddRecordLink_Click);
                this.ObjectiveIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.ObjectiveId.UniqueID + "&DFKA=ObjectiveName";
                this.ObjectiveIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.ObjectiveIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.ObjectiveIdAddRecordLink.Click += new ImageClickEventHandler(ObjectiveIdAddRecordLink_Click);
              this.OrgRoleId.SelectedIndexChanged += new EventHandler(OrgRoleId_SelectedIndexChanged);
            
              this.MeasureId.SelectedIndexChanged += new EventHandler(MeasureId_SelectedIndexChanged);
            
              this.ObjectiveId.SelectedIndexChanged += new EventHandler(ObjectiveId_SelectedIndexChanged);
            
        }

        // To customize, override this method in RoleMeasureTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.RoleMeasureRecordRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "BS") + "'));");
        }

        // Read data from database. To customize, override this method in RoleMeasureTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = RoleMeasureTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseRoleMeasureTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new RoleMeasureRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in RoleMeasureTableControlRow.
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
                
            this.IsNewRecord = true;
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
        
                this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
            }

            

            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            
        }

        //  To customize, override this method in RoleMeasureTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // Perspective in PerspectiveRecordControl is One To Many to RoleMeasureTableControl.
                    
            // Setup the parent id in the record.
            PerspectiveRecordControl recPerspectiveRecordControl = (PerspectiveRecordControl)this.Page.FindControlRecursively("PerspectiveRecordControl");
            if (recPerspectiveRecordControl != null && recPerspectiveRecordControl.DataSource == null) {
                // Load the record if it is not loaded yet.
                recPerspectiveRecordControl.LoadData();
            }
            if (recPerspectiveRecordControl == null || recPerspectiveRecordControl.DataSource == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "BS"));
            }
                    
            this.DataSource.Perspectiveid = recPerspectiveRecordControl.DataSource.PerspectiveId;
            
            // 2. Validate the data.  Override in RoleMeasureTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in RoleMeasureTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((RoleMeasureTableControl)MiscUtils.GetParentControlObject(this, "RoleMeasureTableControl")).DataChanged = true;
                ((RoleMeasureTableControl)MiscUtils.GetParentControlObject(this, "RoleMeasureTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in RoleMeasureTableControlRow.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.OrgRoleId), RoleMeasureTable.OrgRoleId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MeasureId), RoleMeasureTable.MeasureId);
                  
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ObjectiveId), RoleMeasureTable.ObjectiveId);
                  
        }

        //  To customize, override this method in RoleMeasureTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        

        //  To customize, override this method in RoleMeasureTableControlRow.
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

          
            ((RoleMeasureTableControl)MiscUtils.GetParentControlObject(this, "RoleMeasureTableControl")).DataChanged = true;
            ((RoleMeasureTableControl)MiscUtils.GetParentControlObject(this, "RoleMeasureTableControl")).ResetData = true;
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
                
              // event handler for ImageButton
              public virtual void RoleMeasureRecordRowDeleteButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        RoleMeasureTableControl tc= ((RoleMeasureTableControl)MiscUtils.GetParentControlObject(this, "RoleMeasureTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((RoleMeasureTableControlRow)this);
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
                return (string)this.ViewState["BaseRoleMeasureTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseRoleMeasureTableControlRow_Rec"] = value;
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
        
        public System.Web.UI.WebControls.CheckBox RoleMeasureRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton RoleMeasureRecordRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureRecordRowDeleteButton");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList OrgRoleId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleId");
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
           
        public System.Web.UI.WebControls.DropDownList ObjectiveId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveId");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ObjectiveIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveIdAddRecordLink");
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

  
// Base class for the RoleMeasureTableControl control on the AddPerspectivePage page.
// Do not modify this class. Instead override any method in RoleMeasureTableControl.
public class BaseRoleMeasureTableControl : BS.UI.BaseApplicationTableControl
{
        public BaseRoleMeasureTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.RoleMeasurePagination.FirstPage.Click += new ImageClickEventHandler(RoleMeasurePagination_FirstPage_Click);
              this.RoleMeasurePagination.LastPage.Click += new ImageClickEventHandler(RoleMeasurePagination_LastPage_Click);
              this.RoleMeasurePagination.NextPage.Click += new ImageClickEventHandler(RoleMeasurePagination_NextPage_Click);
              this.RoleMeasurePagination.PageSizeButton.Click += new EventHandler(RoleMeasurePagination_PageSizeButton_Click);
            
              this.RoleMeasurePagination.PreviousPage.Click += new ImageClickEventHandler(RoleMeasurePagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.OrgRoleIdLabel1.Click += new EventHandler(OrgRoleIdLabel1_Click);
            
              this.MeasureIdLabel1.Click += new EventHandler(MeasureIdLabel1_Click);
            
              this.ObjectiveIdLabel.Click += new EventHandler(ObjectiveIdLabel_Click);
            

            // Setup the button events.
        
              this.RoleMeasureAddButton.Click += new ImageClickEventHandler(RoleMeasureAddButton_Click);
              this.RoleMeasureDeleteButton.Click += new ImageClickEventHandler(RoleMeasureDeleteButton_Click);
              this.RoleMeasureResetButton.Click += new ImageClickEventHandler(RoleMeasureResetButton_Click);

            // Setup the filter and search events.
        
            this.OrgRoleIdFilter.SelectedIndexChanged += new EventHandler(OrgRoleIdFilter_SelectedIndexChanged);
            this.MeasureIdFilter.SelectedIndexChanged += new EventHandler(MeasureIdFilter_SelectedIndexChanged);
            if (!this.Page.IsPostBack && this.InSession(this.OrgRoleIdFilter)) {
                this.OrgRoleIdFilter.Items.Add(new ListItem(this.GetFromSession(this.OrgRoleIdFilter), this.GetFromSession(this.OrgRoleIdFilter)));
                this.OrgRoleIdFilter.SelectedValue = this.GetFromSession(this.OrgRoleIdFilter);
            }
            if (!this.Page.IsPostBack && this.InSession(this.MeasureIdFilter)) {
                this.MeasureIdFilter.Items.Add(new ListItem(this.GetFromSession(this.MeasureIdFilter), this.GetFromSession(this.MeasureIdFilter)));
                this.MeasureIdFilter.SelectedValue = this.GetFromSession(this.MeasureIdFilter);
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
                this.RoleMeasureDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "BS") + "'));");
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
                    this.DataSource = (RoleMeasureRecord[])(alist.ToArray(Type.GetType("BS.Business.RoleMeasureRecord")));
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = RoleMeasureTable.GetRecordCount(wc);

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
                    this.DataSource = (RoleMeasureRecord[])(alist.ToArray(Type.GetType("BS.Business.RoleMeasureRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (RoleMeasureTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (RoleMeasureRecord[])(postdata.ToArray(Type.GetType("BS.Business.RoleMeasureRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = RoleMeasureTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
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
        
            this.PopulateOrgRoleIdFilter(MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), 500);
            this.PopulateMeasureIdFilter(MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), 500);

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("RoleMeasureTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                RoleMeasureTableControlRow recControl = (RoleMeasureTableControlRow)(repItem.FindControl("RoleMeasureTableControlRow"));
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
          
            this.Page.PregetDfkaRecords(RoleMeasureTable.OrgRoleId, this.DataSource);
            this.Page.PregetDfkaRecords(RoleMeasureTable.MeasureId, this.DataSource);
            this.Page.PregetDfkaRecords(RoleMeasureTable.ObjectiveId, this.DataSource);
        }
         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for RoleMeasureTableControl pagination.
        
            this.RoleMeasurePagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.RoleMeasurePagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.RoleMeasurePagination.LastPage.Enabled = false;
            }
          
            this.RoleMeasurePagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.RoleMeasurePagination.NextPage.Enabled = false;
            }
          
            this.RoleMeasurePagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.RoleMeasurePagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.RoleMeasurePagination.CurrentPage.Text = "0";
            }
            this.RoleMeasurePagination.PageSize.Text = this.PageSize.ToString();
            this.RoleMeasureTotalItems.Text = this.TotalRecords.ToString();
            this.RoleMeasurePagination.TotalItems.Text = this.TotalRecords.ToString();
            this.RoleMeasurePagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (RoleMeasureTableControlRow recCtl in this.GetRecordControls())
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
            RoleMeasureTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        PerspectiveRecordControl parentRecordControl = (PerspectiveRecordControl)(this.Page.FindControlRecursively("PerspectiveRecordControl"));
            PerspectiveRecord parentRec = parentRecordControl.GetRecord();
            if (parentRec == null) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:ParentNotInitialized", "BS"));
            }
           
            if (parentRec.PerspectiveIdSpecified) {
                wc.iAND(RoleMeasureTable.Perspectiveid, BaseFilter.ComparisonOperator.EqualsTo, parentRec.PerspectiveId.ToString());
            } else {
                wc.RunQuery = false;
                return wc;
            }
            
            if (MiscUtils.IsValueSelected(this.OrgRoleIdFilter)) {
                wc.iAND(RoleMeasureTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), false, false);
            }
                      
            if (MiscUtils.IsValueSelected(this.MeasureIdFilter)) {
                wc.iAND(RoleMeasureTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), false, false);
            }
                      
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            RoleMeasureTable.Instance.InnerFilter = null;
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
                
                    wc.iAND(RoleMeasureTable.Perspectiveid, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(PerspectiveTable.PerspectiveId).ToString());
                
                } else {
                
                    wc.iAND(RoleMeasureTable.Perspectiveid, BaseFilter.ComparisonOperator.EqualsTo, recId);
              
                }
            }
              
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            String OrgRoleIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "OrgRoleIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(OrgRoleIdFilterSelectedValue)) {
                wc.iAND(RoleMeasureTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, OrgRoleIdFilterSelectedValue, false, false);
            }
                      
            String MeasureIdFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "MeasureIdFilter_Ajax"];
            if (MiscUtils.IsValueSelected(MeasureIdFilterSelectedValue)) {
                wc.iAND(RoleMeasureTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MeasureIdFilterSelectedValue, false, false);
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
        
            if (this.RoleMeasurePagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.RoleMeasurePagination.PageSize.Text);
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
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("RoleMeasureTableControlRepeater"));
                int index = 0;

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    RoleMeasureTableControlRow recControl = (RoleMeasureTableControlRow)(repItem.FindControl("RoleMeasureTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        RoleMeasureRecord rec = new RoleMeasureRecord();
        
                        if (MiscUtils.IsValueSelected(recControl.OrgRoleId)) {
                            rec.Parse(recControl.OrgRoleId.SelectedItem.Value, RoleMeasureTable.OrgRoleId);
                        }
                        if (MiscUtils.IsValueSelected(recControl.MeasureId)) {
                            rec.Parse(recControl.MeasureId.SelectedItem.Value, RoleMeasureTable.MeasureId);
                        }
                        if (MiscUtils.IsValueSelected(recControl.ObjectiveId)) {
                            rec.Parse(recControl.ObjectiveId.SelectedItem.Value, RoleMeasureTable.ObjectiveId);
                        }
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new RoleMeasureRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (RoleMeasureRecord[])(finalList.ToArray(Type.GetType("BS.Business.RoleMeasureRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(RoleMeasureTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(RoleMeasureTableControlRow rec)            
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
                          
        // Create a where clause for the filter OrgRoleIdFilter.
        public virtual WhereClause CreateWhereClause_OrgRoleIdFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.MeasureIdFilter)) {
                wc.iAND(RoleMeasureTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.MeasureIdFilter, this.GetFromSession(this.MeasureIdFilter)), false, false);
            }
                      
            return wc;
        }
                          
        // Create a where clause for the filter MeasureIdFilter.
        public virtual WhereClause CreateWhereClause_MeasureIdFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
            if (MiscUtils.IsValueSelected(this.OrgRoleIdFilter)) {
                wc.iAND(RoleMeasureTable.OrgRoleId, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.OrgRoleIdFilter, this.GetFromSession(this.OrgRoleIdFilter)), false, false);
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
        
            this.SaveToSession(this.OrgRoleIdFilter, this.OrgRoleIdFilter.SelectedValue);
            this.SaveToSession(this.MeasureIdFilter, this.MeasureIdFilter.SelectedValue);
            
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
          
            this.SaveToSession("OrgRoleIdFilter_Ajax", this.OrgRoleIdFilter.SelectedValue);
            this.SaveToSession("MeasureIdFilter_Ajax", this.MeasureIdFilter.SelectedValue);
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.OrgRoleIdFilter);
            this.RemoveFromSession(this.MeasureIdFilter);
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["RoleMeasureTableControl_OrderBy"];
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
                this.ViewState["RoleMeasureTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
              // event handler for ImageButton
              public virtual void RoleMeasurePagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void RoleMeasurePagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void RoleMeasurePagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void RoleMeasurePagination_PageSizeButton_Click(object sender, EventArgs args)
              {
              
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.RoleMeasurePagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.RoleMeasurePagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void RoleMeasurePagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void OrgRoleIdLabel1_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(RoleMeasureTable.OrgRoleId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(RoleMeasureTable.OrgRoleId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void MeasureIdLabel1_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(RoleMeasureTable.MeasureId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(RoleMeasureTable.MeasureId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            
              // event handler for FieldSort
              public virtual void ObjectiveIdLabel_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(RoleMeasureTable.ObjectiveId);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(RoleMeasureTable.ObjectiveId, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            

        // Generate the event handling functions for button events.
        
              // event handler for ImageButton
              public virtual void RoleMeasureAddButton_Click(object sender, ImageClickEventArgs args)
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
              public virtual void RoleMeasureDeleteButton_Click(object sender, ImageClickEventArgs args)
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
              public virtual void RoleMeasureResetButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
              this.OrgRoleIdFilter.ClearSelection();
            
              this.MeasureIdFilter.ClearSelection();
            
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
        protected virtual void OrgRoleIdFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            this.DataChanged = true;
        }
            
        // event handler for FieldFilter
        protected virtual void MeasureIdFilter_SelectedIndexChanged(object sender, EventArgs args)
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

        private RoleMeasureRecord[] _DataSource = null;
        public  RoleMeasureRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal RoleMeasureTableTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureTableTitle");
            }
        }
        
        public System.Web.UI.WebControls.Label RoleMeasureTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureTotalItems");
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
        
        public BS.UI.IPagination RoleMeasurePagination {
            get {
                return (BS.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasurePagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton RoleMeasureAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureAddButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton RoleMeasureDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton RoleMeasureResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox RoleMeasureToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleMeasureToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton OrgRoleIdLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "OrgRoleIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton MeasureIdLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureIdLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ObjectiveIdLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ObjectiveIdLabel");
            }
        }
        
#endregion

#region "Helper Functions"
        
                public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
              
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                RoleMeasureTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
                }

                RoleMeasureRecord rec = null;
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
            foreach (RoleMeasureTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.RoleMeasureRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public RoleMeasureTableControlRow GetSelectedRecordControl()
        {
        RoleMeasureTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public RoleMeasureTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (RoleMeasureTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.RoleMeasureRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (RoleMeasureTableControlRow[])(selectedList.ToArray(Type.GetType("BS.UI.Controls.AddPerspectivePage.RoleMeasureTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            RoleMeasureTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
            }
            
            foreach (RoleMeasureTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.RoleMeasureRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public RoleMeasureTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("RoleMeasureTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                RoleMeasureTableControlRow recControl = (RoleMeasureTableControlRow)repItem.FindControl("RoleMeasureTableControlRow");
                recList.Add(recControl);
            }

            return (RoleMeasureTableControlRow[])recList.ToArray(Type.GetType("BS.UI.Controls.AddPerspectivePage.RoleMeasureTableControlRow"));
        }

        public BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  
// Base class for the PerspectiveRecordControl control on the AddPerspectivePage page.
// Do not modify this class. Instead override any method in PerspectiveRecordControl.
public class BasePerspectiveRecordControl : BS.UI.BaseApplicationRecordControl
{
        public BasePerspectiveRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in PerspectiveRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
        }

        // To customize, override this method in PerspectiveRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in PerspectiveRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = PerspectiveTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            if (wc == null) {
                this.DataSource = new PerspectiveRecord();
                return;
            }

            // Retrieve the record from the database.
            PerspectiveRecord[] recList = PerspectiveTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "BS"));
            }

            
                    this.DataSource = (PerspectiveRecord)PerspectiveRecord.Copy(recList[0], false);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in PerspectiveRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.PerspectiveNameSpecified) {
                      
                string formattedValue = this.DataSource.Format(PerspectiveTable.PerspectiveName);
                this.PerspectiveName.Text = formattedValue;
                        
            } else {  
                this.PerspectiveName.Text = PerspectiveTable.PerspectiveName.Format(PerspectiveTable.PerspectiveName.DefaultValue);
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

        //  To customize, override this method in PerspectiveRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in PerspectiveRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in PerspectiveRecordControl to set additional fields.
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

        //  To customize, override this method in PerspectiveRecordControl.
        public virtual void GetUIData()
        {
        
            bool clearDataSource = false;
            foreach(BaseColumn col in PerspectiveRecord.TableUtils.TableDefinition.Columns){
                if ((col.ColumnType == BaseColumn.ColumnTypes.Unique_Identifier)){
                    clearDataSource = true;
                }
            }

            if (clearDataSource){
                this.DataSource = new PerspectiveRecord();
            }
        
            this.DataSource.Parse(this.PerspectiveName.Text, PerspectiveTable.PerspectiveName);
                          
        }

        //  To customize, override this method in PerspectiveRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            PerspectiveTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Perspective"];
            if (recId == null || recId.Length == 0) {
                return null;
            }
                       
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(PerspectiveTable.PerspectiveId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(PerspectiveTable.PerspectiveId).ToString());
            } else {
                
                wc.iAND(PerspectiveTable.PerspectiveId, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              
            return wc;  
          
        }
        

        //  To customize, override this method in PerspectiveRecordControl.
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
            PerspectiveTable.DeleteRecord(pk);

          
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
                return (string)this.ViewState["BasePerspectiveRecordControl_Rec"];
            }
            set {
                this.ViewState["BasePerspectiveRecordControl_Rec"] = value;
            }
        }
        
        private PerspectiveRecord _DataSource;
        public PerspectiveRecord DataSource {
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
        
        public System.Web.UI.WebControls.Literal PerspectiveDialogTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PerspectiveDialogTitle");
            }
        }
           
        public System.Web.UI.WebControls.TextBox PerspectiveName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PerspectiveName");
            }
        }
        
        public System.Web.UI.WebControls.Literal PerspectiveNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PerspectiveNameLabel");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            PerspectiveRecord rec = null;
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

        public PerspectiveRecord GetRecord()
        {
        
            if (this.DataSource != null) {
              return this.DataSource;
            }
            
            return new PerspectiveRecord();
          
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

  