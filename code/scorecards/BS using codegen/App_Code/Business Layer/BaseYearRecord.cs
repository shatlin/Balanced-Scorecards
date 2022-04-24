// This class is "generated" and will be overwritten.
// Your customizations should be made in YearRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="YearRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="YearTable"></see> class.
/// </remarks>
/// <seealso cref="YearTable"></seealso>
/// <seealso cref="YearRecord"></seealso>
public class BaseYearRecord : PrimaryKeyRecord
{

	public readonly static YearTable TableUtils = YearTable.Instance;

	// Constructors
 
	protected BaseYearRecord() : base(TableUtils)
	{
	}

	protected BaseYearRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Year_.YearId field.
	/// </summary>
	public ColumnValue GetYearIdValue()
	{
		return this.GetValue(TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Year_.YearId field.
	/// </summary>
	public Int32 GetYearIdFieldValue()
	{
		return this.GetValue(TableUtils.YearIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Year_.YearValue field.
	/// </summary>
	public ColumnValue GetYearValueValue()
	{
		return this.GetValue(TableUtils.YearValueColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Year_.YearValue field.
	/// </summary>
	public string GetYearValueFieldValue()
	{
		return this.GetValue(TableUtils.YearValueColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Year_.YearValue field.
	/// </summary>
	public void SetYearValueFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YearValueColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Year_.YearValue field.
	/// </summary>
	public void SetYearValueFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YearValueColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Year_.YearId field.
	/// </summary>
	public Int32 YearId
	{
		get
		{
			return this.GetValue(TableUtils.YearIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YearIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YearIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YearIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Year_.YearId field.
	/// </summary>
	public string YearIdDefault
	{
		get
		{
			return TableUtils.YearIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Year_.YearValue field.
	/// </summary>
	public string YearValue
	{
		get
		{
			return this.GetValue(TableUtils.YearValueColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.YearValueColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool YearValueSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.YearValueColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Year_.YearValue field.
	/// </summary>
	public string YearValueDefault
	{
		get
		{
			return TableUtils.YearValueColumn.DefaultValue;
		}
	}


#endregion
}

}
