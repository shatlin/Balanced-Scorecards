// This class is "generated" and will be overwritten.
// Your customizations should be made in MeasureTypeRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="MeasureTypeRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MeasureTypeTable"></see> class.
/// </remarks>
/// <seealso cref="MeasureTypeTable"></seealso>
/// <seealso cref="MeasureTypeRecord"></seealso>
public class BaseMeasureTypeRecord : PrimaryKeyRecord
{

	public readonly static MeasureTypeTable TableUtils = MeasureTypeTable.Instance;

	// Constructors
 
	protected BaseMeasureTypeRecord() : base(TableUtils)
	{
	}

	protected BaseMeasureTypeRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureType_.MeasureTypeId field.
	/// </summary>
	public ColumnValue GetMeasureTypeIdValue()
	{
		return this.GetValue(TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureType_.MeasureTypeId field.
	/// </summary>
	public Int32 GetMeasureTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public ColumnValue GetMeasureTypenameValue()
	{
		return this.GetValue(TableUtils.MeasureTypenameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public string GetMeasureTypenameFieldValue()
	{
		return this.GetValue(TableUtils.MeasureTypenameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public void SetMeasureTypenameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeasureTypenameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public void SetMeasureTypenameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureTypenameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureType_.MeasureTypeId field.
	/// </summary>
	public Int32 MeasureTypeId
	{
		get
		{
			return this.GetValue(TableUtils.MeasureTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeasureTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeasureTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeasureTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureType_.MeasureTypeId field.
	/// </summary>
	public string MeasureTypeIdDefault
	{
		get
		{
			return TableUtils.MeasureTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public string MeasureTypename
	{
		get
		{
			return this.GetValue(TableUtils.MeasureTypenameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeasureTypenameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeasureTypenameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeasureTypenameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureType_.MeasureTypename field.
	/// </summary>
	public string MeasureTypenameDefault
	{
		get
		{
			return TableUtils.MeasureTypenameColumn.DefaultValue;
		}
	}


#endregion
}

}
