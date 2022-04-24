
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// EditMeasureTypeTablePage.aspx page.  The Row or RecordControl classes are the 
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

  
namespace BS.UI.Controls.EditMeasureTypeTablePage
{
  

#region "Section 1: Place your customizations here."

    
public class MeasureTypeTableControlRow : BaseMeasureTypeTableControlRow
{
      
        // The BaseMeasureTypeTableControlRow implements code for a ROW within the
        // the MeasureTypeTableControl table.  The BaseMeasureTypeTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of MeasureTypeTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        

}

  

public class MeasureTypeTableControl : BaseMeasureTypeTableControl
{
        // The BaseMeasureTypeTableControl class implements the LoadData, DataBind, CreateWhereClause
        // and other methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        // The MeasureTypeTableControlRow class offers another place where you can customize
        // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the MeasureTypeTableControlRow control on the EditMeasureTypeTablePage page.
// Do not modify this class. Instead override any method in MeasureTypeTableControlRow.
public class BaseMeasureTypeTableControlRow : BS.UI.BaseApplicationRecordControl
{
        public BaseMeasureTypeTableControlRow()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        // To customize, override this method in MeasureTypeTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Register the event handlers.
        
              this.MeasureTypeRecordRowEditButton.Click += new ImageClickEventHandler(MeasureTypeRecordRowEditButton_Click);
              this.MeasureTypeRecordRowViewButton.Click += new ImageClickEventHandler(MeasureTypeRecordRowViewButton_Click);
              this.MeasureTypeRecordRowDeleteButton.Click += new ImageClickEventHandler(MeasureTypeRecordRowDeleteButton_Click);
        }

        // To customize, override this method in MeasureTypeTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {
        
                // Show confirmation message on Click
                this.MeasureTypeRecordRowDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "BS") + "'));");
        }

        // Read data from database. To customize, override this method in MeasureTypeTableControlRow.
        public virtual void LoadData()  
        {
        
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
                this.DataSource = MeasureTypeTable.GetRecord(this.RecordUniqueId, true);
                return;
            }
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseMeasureTypeTableControl when the data for the entire
            // table is loaded.
            this.DataSource = new MeasureTypeRecord();
          
        }

        // Populate the UI controls using the DataSource. To customize, override this method in MeasureTypeTableControlRow.
        public override void DataBind()
        {
            base.DataBind();

            // Make sure that the DataSource is initialized.
            if (this.DataSource == null) {
                return;
            }
        

            // For each field, check to see if a value is specified.  If a value is specified,
            // then format the value for display.  If no value is specified, use the default value (formatted).

        
            if (this.DataSource.MeasureTypenameSpecified) {
                      
                string formattedValue = this.DataSource.Format(MeasureTypeTable.MeasureTypename);
                this.MeasureTypename.Text = formattedValue;
                        
            } else {  
                this.MeasureTypename.Text = MeasureTypeTable.MeasureTypename.Format(MeasureTypeTable.MeasureTypename.DefaultValue);
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

        //  To customize, override this method in MeasureTypeTableControlRow.
        public virtual void SaveData()
        {
            // 1. Load the existing record from the database. Since we save the entire reocrd, this ensures 
            // that fields that are not displayed also properly initialized.
            this.LoadData();
        
            // 2. Validate the data.  Override in MeasureTypeTableControlRow to add custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.  Override in MeasureTypeTableControlRow to set additional fields.
            this.GetUIData();

            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
              
                ((MeasureTypeTableControl)MiscUtils.GetParentControlObject(this, "MeasureTypeTableControl")).DataChanged = true;
                ((MeasureTypeTableControl)MiscUtils.GetParentControlObject(this, "MeasureTypeTableControl")).ResetData = true;
            }
            // Reseting of this.IsNewRecord is moved to Save button's click even handler.
            // this.IsNewRecord = false;
            this.DataChanged = true;
            this.ResetData = true;
            
        }

        //  To customize, override this method in MeasureTypeTableControlRow.
        public virtual void GetUIData()
        {
        
            this.DataSource.Parse(this.MeasureTypename.Text, MeasureTypeTable.MeasureTypename);
                          
        }

        //  To customize, override this method in MeasureTypeTableControlRow.
        public virtual WhereClause CreateWhereClause()
        {
        
            return null;
          
        }
        

        //  To customize, override this method in MeasureTypeTableControlRow.
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
            MeasureTypeTable.DeleteRecord(pk);

          
            ((MeasureTypeTableControl)MiscUtils.GetParentControlObject(this, "MeasureTypeTableControl")).DataChanged = true;
            ((MeasureTypeTableControl)MiscUtils.GetParentControlObject(this, "MeasureTypeTableControl")).ResetData = true;
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
              public virtual void MeasureTypeRecordRowEditButton_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../MeasureType/EditMeasureTypePage.aspx?MeasureType={PK}";
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
              public virtual void MeasureTypeRecordRowViewButton_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../MeasureType/ShowMeasureTypePage.aspx?MeasureType={PK}";
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
              public virtual void MeasureTypeRecordRowDeleteButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        MeasureTypeTableControl tc= ((MeasureTypeTableControl)MiscUtils.GetParentControlObject(this, "MeasureTypeTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((MeasureTypeTableControlRow)this);
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
                return (string)this.ViewState["BaseMeasureTypeTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseMeasureTypeTableControlRow_Rec"] = value;
            }
        }
        
        private MeasureTypeRecord _DataSource;
        public MeasureTypeRecord DataSource {
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
        
        public System.Web.UI.WebControls.CheckBox MeasureTypeRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeRecordRowSelection");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeRecordRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeRecordRowEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeRecordRowViewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeRecordRowViewButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeRecordRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeRecordRowDeleteButton");
            }
        }
           
        public System.Web.UI.WebControls.TextBox MeasureTypename {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypename");
            }
        }
        
#endregion

#region "Helper Functions"
    
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
      
        {
            MeasureTypeRecord rec = null;
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

        public MeasureTypeRecord GetRecord()
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            if (this.RecordUniqueId != null) {
                return MeasureTypeTable.GetRecord(this.RecordUniqueId, true);
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

  
// Base class for the MeasureTypeTableControl control on the EditMeasureTypeTablePage page.
// Do not modify this class. Instead override any method in MeasureTypeTableControl.
public class BaseMeasureTypeTableControl : BS.UI.BaseApplicationTableControl
{
        public BaseMeasureTypeTableControl()
        {
            this.Init += new EventHandler(Control_Init);
            this.Load += new EventHandler(Control_Load);
            this.PreRender += new EventHandler(Control_PreRender);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
            // Setup the pagination events.
        
              this.MeasureTypePagination.FirstPage.Click += new ImageClickEventHandler(MeasureTypePagination_FirstPage_Click);
              this.MeasureTypePagination.LastPage.Click += new ImageClickEventHandler(MeasureTypePagination_LastPage_Click);
              this.MeasureTypePagination.NextPage.Click += new ImageClickEventHandler(MeasureTypePagination_NextPage_Click);
              this.MeasureTypePagination.PageSizeButton.Click += new EventHandler(MeasureTypePagination_PageSizeButton_Click);
            
              this.MeasureTypePagination.PreviousPage.Click += new ImageClickEventHandler(MeasureTypePagination_PreviousPage_Click);

            // Setup the sorting events.
        
              this.MeasureTypenameLabel1.Click += new EventHandler(MeasureTypenameLabel1_Click);
            

            // Setup the button events.
        
              this.MeasureTypeAddButton.Click += new ImageClickEventHandler(MeasureTypeAddButton_Click);
              this.MeasureTypeEditButton.Click += new ImageClickEventHandler(MeasureTypeEditButton_Click);
              this.MeasureTypeDeleteButton.Click += new ImageClickEventHandler(MeasureTypeDeleteButton_Click);
              this.MeasureTypeSaveButton.Click += new ImageClickEventHandler(MeasureTypeSaveButton_Click);
              this.MeasureTypeRefreshButton.Click += new ImageClickEventHandler(MeasureTypeRefreshButton_Click);
              this.MeasureTypeResetButton.Click += new ImageClickEventHandler(MeasureTypeResetButton_Click);

            // Setup the filter and search events.
        
            this.MeasureTypenameFilter.SelectedIndexChanged += new EventHandler(MeasureTypenameFilter_SelectedIndexChanged);
            if (!this.Page.IsPostBack && this.InSession(this.MeasureTypenameFilter)) {
                this.MeasureTypenameFilter.Items.Add(new ListItem(this.GetFromSession(this.MeasureTypenameFilter), this.GetFromSession(this.MeasureTypenameFilter)));
                this.MeasureTypenameFilter.SelectedValue = this.GetFromSession(this.MeasureTypenameFilter);
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
                this.MeasureTypeDeleteButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "BS") + "'));");
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
                    this.DataSource = (MeasureTypeRecord[])(alist.ToArray(Type.GetType("BS.Business.MeasureTypeRecord")));
                    return;
                }

                OrderBy orderBy = CreateOrderBy();

                // Get the pagesize from the pagesize control.
                this.GetPageSize();

                // Get the total number of records to be displayed.
                this.TotalRecords = MeasureTypeTable.GetRecordCount(wc);

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
                    this.DataSource = (MeasureTypeRecord[])(alist.ToArray(Type.GetType("BS.Business.MeasureTypeRecord")));
                } else if (this.AddNewRecord > 0) {
                    // Get the records from the posted data
                    ArrayList postdata = new ArrayList(0);
                    foreach (MeasureTypeTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                        }
                    }
                    this.DataSource = (MeasureTypeRecord[])(postdata.ToArray(Type.GetType("BS.Business.MeasureTypeRecord")));
                } else {
                    // Get the records from the database
                    this.DataSource = MeasureTypeTable.GetRecords(wc, orderBy, this.PageIndex, this.PageSize);
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
        

            // Setup the pagination controls.
            BindPaginationControls();

            // Populate all filters data.
        
            this.PopulateMeasureTypenameFilter(MiscUtils.GetSelectedValue(this.MeasureTypenameFilter, this.GetFromSession(this.MeasureTypenameFilter)), 500);

            // Bind the repeater with the list of records to expand the UI.
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("MeasureTypeTableControlRepeater"));
            rep.DataSource = this.DataSource;
            rep.DataBind();

            int index = 0;
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                MeasureTypeTableControlRow recControl = (MeasureTypeTableControlRow)(repItem.FindControl("MeasureTypeTableControlRow"));
                recControl.DataSource = this.DataSource[index];
                recControl.DataBind();
                recControl.Visible = !this.InDeletedRecordIds(recControl);
                index += 1;
            }
        }

         

        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.

            // Bind the buttons for MeasureTypeTableControl pagination.
        
            this.MeasureTypePagination.FirstPage.Enabled = !(this.PageIndex == 0);
            this.MeasureTypePagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.MeasureTypePagination.LastPage.Enabled = false;
            }
          
            this.MeasureTypePagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);
            if (this.TotalPages == 0) {
                this.MeasureTypePagination.NextPage.Enabled = false;
            }
          
            this.MeasureTypePagination.PreviousPage.Enabled = !(this.PageIndex == 0);

            // Bind the pagination labels.
        
            if (this.TotalPages > 0) {
                this.MeasureTypePagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } else {
                this.MeasureTypePagination.CurrentPage.Text = "0";
            }
            this.MeasureTypePagination.PageSize.Text = this.PageSize.ToString();
            this.MeasureTypeTotalItems.Text = this.TotalRecords.ToString();
            this.MeasureTypePagination.TotalItems.Text = this.TotalRecords.ToString();
            this.MeasureTypePagination.TotalPages.Text = this.TotalPages.ToString();
        }

        public virtual void SaveData()
        {
            foreach (MeasureTypeTableControlRow recCtl in this.GetRecordControls())
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
            MeasureTypeTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
            // CreateWhereClause() Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
        
            if (MiscUtils.IsValueSelected(this.MeasureTypenameFilter)) {
                wc.iAND(MeasureTypeTable.MeasureTypename, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.MeasureTypenameFilter, this.GetFromSession(this.MeasureTypenameFilter)), false, false);
            }
                      
            return (wc);
        }
        
         
        // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            MeasureTypeTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
            // Compose the WHERE clause consiting of:
            // 1. Static clause defined at design time.
            // 2. User selected filter criteria.
            // 3. User selected search criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelatvieVirtualPath"];
          
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
            String MeasureTypenameFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "MeasureTypenameFilter_Ajax"];
            if (MiscUtils.IsValueSelected(MeasureTypenameFilterSelectedValue)) {
                wc.iAND(MeasureTypeTable.MeasureTypename, BaseFilter.ComparisonOperator.EqualsTo, MeasureTypenameFilterSelectedValue, false, false);
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
        
            if (this.MeasureTypePagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.MeasureTypePagination.PageSize.Text);
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
                System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(this.FindControl("MeasureTypeTableControlRepeater"));
                int index = 0;

                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                    // Loop through all rows in the table, set its DataSource and call DataBind().
                    MeasureTypeTableControlRow recControl = (MeasureTypeTableControlRow)(repItem.FindControl("MeasureTypeTableControlRow"));

                    if (recControl.Visible && recControl.IsNewRecord) {
                        MeasureTypeRecord rec = new MeasureTypeRecord();
        
                        if (recControl.MeasureTypename.Text != "") {
                            rec.Parse(recControl.MeasureTypename.Text, MeasureTypeTable.MeasureTypename);
                        }
                        newRecordList.Add(rec);
                    }
                }
            }

            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
                newRecordList.Insert(0, new MeasureTypeRecord());
            }
            this.AddNewRecord = 0;

            // Finally , add any new records to the DataSource.
            if (newRecordList.Count > 0) {
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                this.DataSource = (MeasureTypeRecord[])(finalList.ToArray(Type.GetType("BS.Business.MeasureTypeRecord")));
            }
        }

        
        public void AddToDeletedRecordIds(MeasureTypeTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        private bool InDeletedRecordIds(MeasureTypeTableControlRow rec)            
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
        
        // Get the filters' data for MeasureTypenameFilter.
        protected virtual void PopulateMeasureTypenameFilter(string selectedValue, int maxItems)
        {
              
            // Setup the WHERE clause, including the base table if needed.
                
            WhereClause wc = new WhereClause();
                  
            OrderBy orderBy = new OrderBy(false, true);
            orderBy.Add(MeasureTypeTable.MeasureTypename, OrderByItem.OrderDir.Asc);

            string[] list = MeasureTypeTable.GetValues(MeasureTypeTable.MeasureTypename, wc, orderBy, maxItems);
            
            this.MeasureTypenameFilter.Items.Clear();
            
            foreach (string itemValue in list)
            {
                // Create the item and add to the list.
                string fvalue = MeasureTypeTable.MeasureTypename.Format(itemValue);
                ListItem item = new ListItem(fvalue, itemValue);
                this.MeasureTypenameFilter.Items.Add(item);
            }
                    
            // Set the selected value.
            MiscUtils.SetSelectedValue(this.MeasureTypenameFilter, selectedValue);

            // Add the All item.
            this.MeasureTypenameFilter.Items.Insert(0, new ListItem(Page.GetResourceValue("Txt:All", "BS"), "--ANY--"));
        }
                          
        // Create a where clause for the filter MeasureTypenameFilter.
        public virtual WhereClause CreateWhereClause_MeasureTypenameFilter()
        {
              
            WhereClause wc = new WhereClause();
                  
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
        
            this.SaveToSession(this.MeasureTypenameFilter, this.MeasureTypenameFilter.SelectedValue);
            
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
          
            this.SaveToSession("MeasureTypenameFilter_Ajax", this.MeasureTypenameFilter.SelectedValue);
           HttpContext.Current.Session["AppRelatvieVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.MeasureTypenameFilter);
            
            // Clear table properties from the session.
            this.RemoveFromSession(this, "Order_By");
            this.RemoveFromSession(this, "Page_Index");
            this.RemoveFromSession(this, "Page_Size");
            
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["MeasureTypeTableControl_OrderBy"];
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
                this.ViewState["MeasureTypeTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
            
            this.ViewState["Page_Index"] = this.PageIndex;
            this.ViewState["Page_Size"] = this.PageSize;
        
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
            return (base.SaveViewState());
        }

        // Generate the event handling functions for pagination events.
        
              // event handler for ImageButton
              public virtual void MeasureTypePagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypePagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypePagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypePagination_PageSizeButton_Click(object sender, EventArgs args)
              {
              
            try {
                
            this.DataChanged = true;
            this.PageSize = Convert.ToInt32(this.MeasureTypePagination.PageSize.Text);
            this.PageIndex = Convert.ToInt32(this.MeasureTypePagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureTypePagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypenameLabel1_Click(object sender, EventArgs args)
              {
              
            OrderByItem sd = this.CurrentSortOrder.Find(MeasureTypeTable.MeasureTypename);
            if (sd != null) {
                sd.Reverse();
            } else {
                this.CurrentSortOrder.Reset();
                this.CurrentSortOrder.Add(MeasureTypeTable.MeasureTypename, OrderByItem.OrderDir.Asc);
            }

            this.DataChanged = true;
              
              }
            

        // Generate the event handling functions for button events.
        
              // event handler for ImageButton
              public virtual void MeasureTypeAddButton_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypeEditButton_Click(object sender, ImageClickEventArgs args)
              {
              
            string url = @"../MeasureType/EditMeasureTypePage.aspx?MeasureType={PK}";
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
              public virtual void MeasureTypeDeleteButton_Click(object sender, ImageClickEventArgs args)
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
              public virtual void MeasureTypeSaveButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                DbUtils.StartTransaction();
                
                if (!this.Page.IsPageRefresh) {
            
                    this.SaveData();
              
                }
                  this.Page.CommitTransaction(sender);
      
                // When one tries to add two duplicate records, an exception is thrown.Before throwing an exception, the first record's IsNewRecord property is set to false. 
                // Now when one tries to delete these two records simultaneously, since the first record's IsNewRecord property is false, the server tries to delete it from the database, which result in an error.
                // To avoid this problem every record's IsNewRecord property is set to false only after all the records are saved in the database. 
           
                foreach (MeasureTypeTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
              // Whenever an existing record is deleted and saved and then tried to add the same record, it does not display the newly added record after saving, because, while displaying each records DeletedRecordIds is checked to see if it is waiting to be deleted.
              // Since DeletedRecordIds is not reset after each record deletion, when one tries to add the same record it sees record id in DeleteReordIds and does not display it. 
              // To overcome this problem, DeletedRecordIds is reset.
          
                this.DeletedRecordIds = null;
            
            } catch (Exception ex) {
                this.Page.RollBackTransaction(sender);
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
                DbUtils.EndTransaction();
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureTypeRefreshButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
            ((MeasureTypeTableControl)(this.Page.FindControlRecursively("MeasureTypeTableControl"))).ResetData = true;
                
            } catch (Exception ex) {
                this.Page.ErrorOnPage = true;
    
                throw ex;
            } finally {
    
            }
    
              }
            
              // event handler for ImageButton
              public virtual void MeasureTypeResetButton_Click(object sender, ImageClickEventArgs args)
              {
              
            try {
                
              this.MeasureTypenameFilter.ClearSelection();
            
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
        protected virtual void MeasureTypenameFilter_SelectedIndexChanged(object sender, EventArgs args)
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

        private MeasureTypeRecord[] _DataSource = null;
        public  MeasureTypeRecord[] DataSource {
            get {
                return this._DataSource;
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal MeasureTypeTableTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeTableTitle");
            }
        }
        
        public System.Web.UI.WebControls.Label MeasureTypeTotalItems {
            get {
                return (System.Web.UI.WebControls.Label)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeTotalItems");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList MeasureTypenameFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypenameFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal MeasureTypenameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypenameLabel");
            }
        }
        
        public BS.UI.IPagination MeasureTypePagination {
            get {
                return (BS.UI.IPagination)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypePagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeAddButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeSaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeSaveButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeRefreshButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeRefreshButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton MeasureTypeResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeResetButton");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox MeasureTypeToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypeToggleAll");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton MeasureTypenameLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "MeasureTypenameLabel1");
            }
        }
        
#endregion

#region "Helper Functions"
        
                public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
              
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                MeasureTypeTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
                }

                MeasureTypeRecord rec = null;
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
            foreach (MeasureTypeTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.MeasureTypeRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public MeasureTypeTableControlRow GetSelectedRecordControl()
        {
        MeasureTypeTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public MeasureTypeTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (MeasureTypeTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.MeasureTypeRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (MeasureTypeTableControlRow[])(selectedList.ToArray(Type.GetType("BS.UI.Controls.EditMeasureTypeTablePage.MeasureTypeTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            MeasureTypeTableControlRow[] recList = this.GetSelectedRecordControls();
            if (recList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "BS"));
            }
            
            foreach (MeasureTypeTableControlRow recCtl in recList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.MeasureTypeRecordRowSelection.Checked = false;
                
                } else {
                
                    recCtl.Delete();
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public MeasureTypeTableControlRow[] GetRecordControls()
        {
            ArrayList recList = new ArrayList();
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("MeasureTypeTableControlRepeater");

            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
            {
                MeasureTypeTableControlRow recControl = (MeasureTypeTableControlRow)repItem.FindControl("MeasureTypeTableControlRow");
                recList.Add(recControl);
            }

            return (MeasureTypeTableControlRow[])recList.ToArray(Type.GetType("BS.UI.Controls.EditMeasureTypeTablePage.MeasureTypeTableControlRow"));
        }

        public BaseApplicationPage Page {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

    #endregion

    

    }
  

#endregion
    
  
}

  