
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// AddMeasurePage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.AddMeasurePage
{
  

#region "Section 1: Place your customizations here."

    
//public class MeasureRoleDetailTableControlRow : BaseMeasureRoleDetailTableControlRow
//{
//      
//        // The BaseMeasureRoleDetailTableControlRow implements code for a ROW within the
//        // the MeasureRoleDetailTableControl table.  The BaseMeasureRoleDetailTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of MeasureRoleDetailTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//
//}
//

  

//public class MeasureRoleDetailTableControl : BaseMeasureRoleDetailTableControl
//{
//        // The BaseMeasureRoleDetailTableControl class implements the LoadData, DataBind, CreateWhereClause
//        // and other methods to load and display the data in a table control.
//
//        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//        // The MeasureRoleDetailTableControlRow class offers another place where you can customize
//        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
//public class RoleMeasureTableControlRow : BaseRoleMeasureTableControlRow
//{
//      
//        // The BaseRoleMeasureTableControlRow implements code for a ROW within the
//        // the RoleMeasureTableControl table.  The BaseRoleMeasureTableControlRow implements the DataBind and SaveData methods.
//        // The loading of data is actually performed by the LoadData method in the base class of RoleMeasureTableControl.
//
//        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
//        // SaveData, GetUIData, and Validate methods.
//        
//
//}
//

  

//public class RoleMeasureTableControl : BaseRoleMeasureTableControl
//{
//        // The BaseRoleMeasureTableControl class implements the LoadData, DataBind, CreateWhereClause
//        // and other methods to load and display the data in a table control.
//
//        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
//        // The RoleMeasureTableControlRow class offers another place where you can customize
//        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
//
//}
//

  
public class MeasureRecordControl : BaseMeasureRecordControl
{
      
        // The BaseMeasureRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the MeasureRecordControl control on the AddMeasurePage page.
// Do not modify this class. Instead override any method in MeasureRecordControl.
public class BaseMeasureRecordControl : BS.UI.BaseApplicationRecordControl
{
        public BaseMeasureRecordControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in MeasureRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
                this.MeasureTypeIdAddRecordLink.Attributes["RedirectUrl"] += "?Target=" + this.MeasureTypeId.UniqueID + "&DFKA=MeasureTypename";
                this.MeasureTypeIdAddRecordLink.Attributes["onClick"] = "window.open('" + this.MeasureTypeIdAddRecordLink.Attributes["RedirectUrl"] + "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;";
              
              this.MeasureTypeIdAddRecordLink.Click += new ImageClickEventHandler(MeasureTypeIdAddRecordLink_Click);
              this.MeasureTypeId.SelectedIndexChanged += new EventHandler(MeasureTypeId_SelectedIndexChanged);
            
        }

        // To customize, override this method in MeasureRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
        }

        // Read data from database. To customize, override this method in MeasureRecordControl.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = MeasureTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            WhereClause wc = this.CreateWhereClause();
            if (wc == null) {
                this.DataSource = new MeasureRecord();
                return;
            }

            // Retrieve the record from the database.
            MeasureRecord[] recList = MeasureTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                throw new Exception(Page.GetResourceValue("Err:NoRecRetrieved", "BS"));
            }

            
                    this.DataSource = (MeasureRecord)MeasureRecord.Copy(recList[0], false);
                  
        }

        // Populate the UI controls using the DataSource. To customize, override this method in MeasureRecordControl.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.MeasureNameSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureTable.MeasureName);
                this.MeasureName.Text = formattedValue;
                        
            } else {  
                this.MeasureName.Text = MeasureTable.MeasureName.Format(MeasureTable.MeasureName.DefaultValue);
            }
                    
            if (this.DataSource.MeasureTypeIdSpecified) {
                this.PopulateMeasureTypeIdDropDownList(this.DataSource.MeasureTypeId.ToString(), 100);
            } else {
                if (!this.DataSource.IsCreated) {
                    this.PopulateMeasureTypeIdDropDownList(MeasureTable.MeasureTypeId.DefaultValue, 100);
                } else {
                this.PopulateMeasureTypeIdDropDownList(null, 100);
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

        //  To customize, override this method in MeasureRecordControl.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in MeasureRecordControl to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in MeasureRecordControl to set additional fields.
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

        //  To customize, override this method in MeasureRecordControl.
        public virtual void GetUIData()
        {
        
            bool clearDataSource = false;
            foreach(BaseColumn col in MeasureRecord.TableUtils.TableDefinition.Columns){
                if ((col.ColumnType == BaseColumn.ColumnTypes.Unique_Identifier)){
                    clearDataSource = true;
                }
            }

            if (clearDataSource){
                this.DataSource = new MeasureRecord();
            }
        
            this.DataSource.Parse(this.MeasureName.Text, MeasureTable.MeasureName);
                          
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.MeasureTypeId), MeasureTable.MeasureTypeId);
                  
        }

        //  To customize, override this method in MeasureRecordControl.
        public virtual WhereClause CreateWhereClause()
        {
        
            WhereClause wc;
            MeasureTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Measure"];
            if (recId == null || recId.Length == 0) {
                return null;
            }
                       
            HttpContext.Current.Session["SelectedID"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                KeyValue pkValue = KeyValue.XmlToKey(recId);
                
                wc.iAND(MeasureTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(MeasureTable.MeasureId).ToString());
            } else {
                
                wc.iAND(MeasureTable.MeasureId, BaseFilter.ComparisonOperator.EqualsTo, recId);
            }
              
            return wc;  
          
        }
        

        //  To customize, override this method in MeasureRecordControl.
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
            MeasureTable.DeleteRecord(pk);

          
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
        
        public virtual WhereClause CreateWhereClause_MeasureTypeIdDropDownList() {
            return new WhereClause();
        }
                
        // Fill the MeasureTypeId list.
        protected virtual void PopulateMeasureTypeIdDropDownList
                (string selectedValue, int maxItems) {
                  
            //Setup the WHERE clause.
            WhereClause wc = CreateWhereClause_MeasureTypeIdDropDownList();
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MeasureTypeTable.MeasureTypename, OrderByItem.OrderDir.Asc);

                      this.MeasureTypeId.Items.Clear();
            foreach (MeasureTypeRecord itemValue in MeasureTypeTable.GetRecords(wc, orderBy, 0, maxItems)) {
                // Create the item and add to the list.
                string cvalue = null;
                string fvalue = null;
                if (itemValue.MeasureTypeIdSpecified) {
                    cvalue = itemValue.MeasureTypeId.ToString();
                    fvalue = itemValue.Format(MeasureTypeTable.MeasureTypename);
                }

                ListItem item = new ListItem(fvalue, cvalue);
                this.MeasureTypeId.Items.Add(item);
            }
                    
            // Setup the selected item.
            if (selectedValue != null &&
                selectedValue.Length > 0 &&
                !MiscUtils.SetSelectedValue(this.MeasureTypeId, selectedValue) &&
                !MiscUtils.SetSelectedValue(this.MeasureTypeId, MeasureTable.MeasureTypeId.Format(selectedValue))) {
                string fvalue = MeasureTable.MeasureTypeId.Format(selectedValue);
                ListItem item = new ListItem(fvalue, selectedValue);
                item.Selected = true;
                this.MeasureTypeId.Items.Insert(0, item);
            }

                  
            this.MeasureTypeId.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:PleaseSelect", "BS"), "--PLEASE_SELECT--"));
                  
        }
                
              // event handler for ImageButton
              public virtual void MeasureTypeIdAddRecordLink_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../MeasureType/AddMeasureTypePage.aspx";
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
            
              protected virtual void MeasureTypeId_SelectedIndexChanged(object sender, EventArgs args)
              {
              string selectedValue = MiscUtils.GetValueSelectedPageRequest(this.MeasureTypeId);
              if (selectedValue != null &&
              selectedValue.Length > 0 &&
              !MiscUtils.SetSelectedValue(this.MeasureTypeId, selectedValue) &&
              !MiscUtils.SetSelectedValue(this.MeasureTypeId, MeasureTable.MeasureTypeId.Format(selectedValue))) {
              string fvalue = MeasureTable.MeasureTypeId.Format(selectedValue);
              ListItem item = new ListItem(fvalue, selectedValue);
              item.Selected = true;
              this.MeasureTypeId.Items.Insert(0, item);
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
                return (string)this.ViewState["BaseMeasureRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseMeasureRecordControl_Rec"] = value;
            }
        }
        
        private MeasureRecord _DataSource;
        public MeasureRecord DataSource {
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
        
        public System.Web.UI.WebControls.Literal MeasureDialogTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureDialogTitle");
            }
        }
           
        public System.Web.UI.WebControls.TextBox MeasureName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureName");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureNameLabel");
            }
        }
           
        public System.Web.UI.WebControls.DropDownList MeasureTypeId {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeId");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeIdAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeIdAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureTypeIdLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeIdLabel");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            MeasureRecord rec = null;
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

        public MeasureRecord GetRecord()
        {
        
            if (this.DataSource != null) {
              return this.DataSource;
            }
            
            return new MeasureRecord();
          
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

  