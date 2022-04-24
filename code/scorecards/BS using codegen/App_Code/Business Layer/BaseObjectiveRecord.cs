// This class is "generated" and will be overwritten.
// Your customizations should be made in ObjectiveRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="ObjectiveRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ObjectiveTable"></see> class.
/// </remarks>
/// <seealso cref="ObjectiveTable"></seealso>
/// <seealso cref="ObjectiveRecord"></seealso>
public class BaseObjectiveRecord : PrimaryKeyRecord
{

	public readonly static ObjectiveTable TableUtils = ObjectiveTable.Instance;

	// Constructors
 
	protected BaseObjectiveRecord() : base(TableUtils)
	{
	}

	protected BaseObjectiveRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Objective_.ObjectiveId field.
	/// </summary>
	public ColumnValue GetObjectiveIdValue()
	{
		return this.GetValue(TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Objective_.ObjectiveId field.
	/// </summary>
	public Int32 GetObjectiveIdFieldValue()
	{
		return this.GetValue(TableUtils.ObjectiveIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public ColumnValue GetObjectiveNameValue()
	{
		return this.GetValue(TableUtils.ObjectiveNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public string GetObjectiveNameFieldValue()
	{
		return this.GetValue(TableUtils.ObjectiveNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public void SetObjectiveNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ObjectiveNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public void SetObjectiveNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ObjectiveNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Objective_.ObjectiveId field.
	/// </summary>
	public Int32 ObjectiveId
	{
		get
		{
			return this.GetValue(TableUtils.ObjectiveIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ObjectiveIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ObjectiveIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ObjectiveIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Objective_.ObjectiveId field.
	/// </summary>
	public string ObjectiveIdDefault
	{
		get
		{
			return TableUtils.ObjectiveIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public string ObjectiveName
	{
		get
		{
			return this.GetValue(TableUtils.ObjectiveNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ObjectiveNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ObjectiveNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ObjectiveNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Objective_.ObjectiveName field.
	/// </summary>
	public string ObjectiveNameDefault
	{
		get
		{
			return TableUtils.ObjectiveNameColumn.DefaultValue;
		}
	}


#endregion
}

}
