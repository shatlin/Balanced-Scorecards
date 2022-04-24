// This class is "generated" and will be overwritten.
// Your customizations should be made in MonthRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="MonthRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MonthTable"></see> class.
/// </remarks>
/// <seealso cref="MonthTable"></seealso>
/// <seealso cref="MonthRecord"></seealso>
public class BaseMonthRecord : PrimaryKeyRecord
{

	public readonly static MonthTable TableUtils = MonthTable.Instance;

	// Constructors
 
	protected BaseMonthRecord() : base(TableUtils)
	{
	}

	protected BaseMonthRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Month_.MonthId field.
	/// </summary>
	public ColumnValue GetMonthIdValue()
	{
		return this.GetValue(TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Month_.MonthId field.
	/// </summary>
	public Int32 GetMonthIdFieldValue()
	{
		return this.GetValue(TableUtils.MonthIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Month_.MonthName field.
	/// </summary>
	public ColumnValue GetMonthNameValue()
	{
		return this.GetValue(TableUtils.MonthNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Month_.MonthName field.
	/// </summary>
	public string GetMonthNameFieldValue()
	{
		return this.GetValue(TableUtils.MonthNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Month_.MonthName field.
	/// </summary>
	public void SetMonthNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MonthNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Month_.MonthName field.
	/// </summary>
	public void SetMonthNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MonthNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Month_.MonthId field.
	/// </summary>
	public Int32 MonthId
	{
		get
		{
			return this.GetValue(TableUtils.MonthIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MonthIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MonthIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MonthIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Month_.MonthId field.
	/// </summary>
	public string MonthIdDefault
	{
		get
		{
			return TableUtils.MonthIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Month_.MonthName field.
	/// </summary>
	public string MonthName
	{
		get
		{
			return this.GetValue(TableUtils.MonthNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MonthNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MonthNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MonthNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Month_.MonthName field.
	/// </summary>
	public string MonthNameDefault
	{
		get
		{
			return TableUtils.MonthNameColumn.DefaultValue;
		}
	}


#endregion
}

}
