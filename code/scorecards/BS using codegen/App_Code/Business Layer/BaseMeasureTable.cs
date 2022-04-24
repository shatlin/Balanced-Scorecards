// This class is "generated" and will be overwritten.
// Your customizations should be made in MeasureTable.cs


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
/// The generated superclass for the <see cref="MeasureTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named Measure.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="MeasureTable.Instance">MeasureTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="MeasureTable"></seealso>
[SerializableAttribute()]
public class BaseMeasureTable : PrimaryKeyTable
{

    private readonly string TableDefinitionString = MeasureDefinition.GetXMLString();







    protected BaseMeasureTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "BS.Business.MeasureTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("App_Code", "BS.Business.MeasureRecord");
        this.ApplicationName = "App_Code";
        this.DataAdapter = new MeasureSqlTable();
        ((MeasureSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;

        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
    }

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeasureIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeasureId
    {
        get
        {
            return MeasureTable.Instance.MeasureIdColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn MeasureNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn MeasureName
    {
        get
        {
            return MeasureTable.Instance.MeasureNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureTypeId column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn MeasureTypeIdColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Measure_.MeasureTypeId column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn MeasureTypeId
    {
        get
        {
            return MeasureTable.Instance.MeasureTypeIdColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRecord records using a where clause.
    /// </summary>
    public static MeasureRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRecord records using a where and order by clause.
    /// </summary>
    public static MeasureRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of MeasureRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static MeasureRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = MeasureTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize);

        return (MeasureRecord[])recList.ToArray(Type.GetType("BS.Business.MeasureRecord"));
    }   
    
    public static MeasureRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = MeasureTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize);

        return (MeasureRecord[])recList.ToArray(Type.GetType("BS.Business.MeasureRecord"));
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

        return (int)MeasureTable.Instance.GetRecordListCount(whereFilter, null);
    }
    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)MeasureTable.Instance.GetRecordListCount(where.GetFilter(), null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeasureRecord record using a where clause.
    /// </summary>
    public static MeasureRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a MeasureRecord record using a where and order by clause.
    /// </summary>
    public static MeasureRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = MeasureTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        MeasureRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (MeasureRecord)recList[0];
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

        return MeasureTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        MeasureRecord[] recs = GetRecords(where);
        return  MeasureTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        MeasureRecord[] recs = GetRecords(where, orderBy);
        return  MeasureTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        MeasureRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  MeasureTable.Instance.CreateDataTable(recs, null);
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
        MeasureTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  MeasureTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return MeasureTable.Instance.ExportRecordData(whereFilter);
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

        return MeasureTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
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

        return MeasureTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return MeasureTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return MeasureTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return MeasureTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return MeasureTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = MeasureTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }

        //Convenience method for getting a record using a string-based record identifier
        public static MeasureRecord GetRecord(string id, bool bMutable)
        {
            return (MeasureRecord)MeasureTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static MeasureRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (MeasureRecord)MeasureTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string MeasureNameValue, 
        string MeasureTypeIdValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(MeasureNameValue, MeasureNameColumn);
        rec.SetString(MeasureTypeIdValue, MeasureTypeIdColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			MeasureTable.Instance.DeleteOneRecord(kv);
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
				MeasureTable.GetRecord(kv, false);
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
            if (!(MeasureTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return MeasureTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(MeasureTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = MeasureTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = MeasureTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (MeasureTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = MeasureTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }

#endregion
}

}
