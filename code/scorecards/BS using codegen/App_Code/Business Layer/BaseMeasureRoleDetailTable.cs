// This class is "generated" and will be overwritten.
// Your customizations should be made in MeasureRoleDetailTable.cs


using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using BS.Data;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="MeasureRoleDetailTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named MeasureRoleDetail.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="MeasureRoleDetailTable.Instance">MeasureRoleDetailTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="MeasureRoleDetailTable"></seealso>
[SerializableAttribute()]
public class BaseMeasureRoleDetailTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = MeasureRoleDetailDefinition.GetXMLString();







    protected BaseMeasureRoleDetailTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "BS.Business.MeasureRoleDetailTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "BS.Business.MeasureRoleDetailRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new MeasureRoleDetailSqlTable();
        ((MeasureRoleDetailSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MeasureDetailId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeasureDetailIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MeasureDetailId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeasureDetailId
    {
        get
        {
            return MeasureRoleDetailTable.Instance.MeasureDetailIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MeasureId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeasureIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MeasureId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeasureId
    {
        get
        {
            return MeasureRoleDetailTable.Instance.MeasureIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.OrgRoleId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn OrgRoleIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.OrgRoleId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn OrgRoleId
    {
        get
        {
            return MeasureRoleDetailTable.Instance.OrgRoleIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.Actual column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ActualColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.Actual column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Actual
    {
        get
        {
            return MeasureRoleDetailTable.Instance.ActualColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.Target column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn TargetColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.Target column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn Target
    {
        get
        {
            return MeasureRoleDetailTable.Instance.TargetColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MonthId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MonthIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.MonthId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MonthId
    {
        get
        {
            return MeasureRoleDetailTable.Instance.MonthIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.YearId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn YearIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's MeasureRoleDetail_.YearId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn YearId
    {
        get
        {
            return MeasureRoleDetailTable.Instance.YearIdColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRoleDetailRecord records using a where clause.
    /// </summary>
    public static MeasureRoleDetailRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRoleDetailRecord records using a where and order by clause.
    /// </summary>
    public static MeasureRoleDetailRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRoleDetailRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MeasureRoleDetailRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = MeasureRoleDetailTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (MeasureRoleDetailRecord[])recList.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord"));
    }   
    
    public static MeasureRoleDetailRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = MeasureRoleDetailTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (MeasureRoleDetailRecord[])recList.ToArray(Type.GetType("BS.Business.MeasureRoleDetailRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)MeasureRoleDetailTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)MeasureRoleDetailTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeasureRoleDetailRecord record using a where clause.
    /// </summary>
    public static MeasureRoleDetailRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeasureRoleDetailRecord record using a where and order by clause.
    /// </summary>
    public static MeasureRoleDetailRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = MeasureRoleDetailTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MeasureRoleDetailRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MeasureRoleDetailRecord)recList[0];
        }

        return rec;
    }
    
    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return MeasureRoleDetailTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        MeasureRoleDetailRecord[] recs = GetRecords(where);
        return  MeasureRoleDetailTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        MeasureRoleDetailRecord[] recs = GetRecords(where, orderBy);
        return  MeasureRoleDetailTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MeasureRoleDetailRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  MeasureRoleDetailTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        MeasureRoleDetailTable.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  MeasureRoleDetailTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return MeasureRoleDetailTable.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return MeasureRoleDetailTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return MeasureRoleDetailTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return MeasureRoleDetailTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return MeasureRoleDetailTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return MeasureRoleDetailTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return MeasureRoleDetailTable.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = MeasureRoleDetailTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static MeasureRoleDetailRecord GetRecord(string id, bool bMutable)
        {
            return (MeasureRoleDetailRecord)MeasureRoleDetailTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static MeasureRoleDetailRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (MeasureRoleDetailRecord)MeasureRoleDetailTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string MeasureIdValue, 
        string OrgRoleIdValue, 
        string ActualValue, 
        string TargetValue, 
        string MonthIdValue, 
        string YearIdValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(MeasureIdValue, MeasureIdColumn);
        rec.SetString(OrgRoleIdValue, OrgRoleIdColumn);
        rec.SetString(ActualValue, ActualColumn);
        rec.SetString(TargetValue, TargetColumn);
        rec.SetString(MonthIdValue, MonthIdColumn);
        rec.SetString(YearIdValue, YearIdColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			MeasureRoleDetailTable.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				MeasureRoleDetailTable.GetRecord(kv, false);
			}
			catch (Exception ex)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (MeasureRoleDetailTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = MeasureRoleDetailTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
