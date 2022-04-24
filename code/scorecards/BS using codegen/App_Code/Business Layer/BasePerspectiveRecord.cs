// This class is "generated" and will be overwritten.
// Your customizations should be made in PerspectiveRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="PerspectiveRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PerspectiveTable"></see> class.
/// </remarks>
/// <seealso cref="PerspectiveTable"></seealso>
/// <seealso cref="PerspectiveRecord"></seealso>
public class BasePerspectiveRecord : PrimaryKeyRecord
{

	public readonly static PerspectiveTable TableUtils = PerspectiveTable.Instance;

	// Constructors
 
	protected BasePerspectiveRecord() : base(TableUtils)
	{
	}

	protected BasePerspectiveRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Perspective_.PerspectiveId field.
	/// </summary>
	public ColumnValue GetPerspectiveIdValue()
	{
		return this.GetValue(TableUtils.PerspectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Perspective_.PerspectiveId field.
	/// </summary>
	public Int32 GetPerspectiveIdFieldValue()
	{
		return this.GetValue(TableUtils.PerspectiveIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public ColumnValue GetPerspectiveNameValue()
	{
		return this.GetValue(TableUtils.PerspectiveNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public string GetPerspectiveNameFieldValue()
	{
		return this.GetValue(TableUtils.PerspectiveNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public void SetPerspectiveNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PerspectiveNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public void SetPerspectiveNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PerspectiveNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Perspective_.PerspectiveId field.
	/// </summary>
	public Int32 PerspectiveId
	{
		get
		{
			return this.GetValue(TableUtils.PerspectiveIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PerspectiveIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PerspectiveIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PerspectiveIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Perspective_.PerspectiveId field.
	/// </summary>
	public string PerspectiveIdDefault
	{
		get
		{
			return TableUtils.PerspectiveIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public string PerspectiveName
	{
		get
		{
			return this.GetValue(TableUtils.PerspectiveNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PerspectiveNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PerspectiveNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PerspectiveNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Perspective_.PerspectiveName field.
	/// </summary>
	public string PerspectiveNameDefault
	{
		get
		{
			return TableUtils.PerspectiveNameColumn.DefaultValue;
		}
	}


#endregion
}

}
