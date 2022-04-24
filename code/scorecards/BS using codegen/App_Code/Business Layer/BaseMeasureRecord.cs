// This class is "generated" and will be overwritten.
// Your customizations should be made in MeasureRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="MeasureRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MeasureTable"></see> class.
/// </remarks>
/// <seealso cref="MeasureTable"></seealso>
/// <seealso cref="MeasureRecord"></seealso>
public class BaseMeasureRecord : PrimaryKeyRecord
{

	public readonly static MeasureTable TableUtils = MeasureTable.Instance;

	// Constructors
 
	protected BaseMeasureRecord() : base(TableUtils)
	{
	}

	protected BaseMeasureRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureId field.
	/// </summary>
	public ColumnValue GetMeasureIdValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureId field.
	/// </summary>
	public Int32 GetMeasureIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureName field.
	/// </summary>
	public ColumnValue GetMeasureNameValue()
	{
		return this.GetValue(TableUtils.MeasureNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureName field.
	/// </summary>
	public string GetMeasureNameFieldValue()
	{
		return this.GetValue(TableUtils.MeasureNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureName field.
	/// </summary>
	public void SetMeasureNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeasureNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureName field.
	/// </summary>
	public void SetMeasureNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public ColumnValue GetMeasureTypeIdValue()
	{
		return this.GetValue(TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public Int32 GetMeasureTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public void SetMeasureTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public void SetMeasureTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public void SetMeasureTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public void SetMeasureTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public void SetMeasureTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureTypeIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Measure_.MeasureId field.
	/// </summary>
	public Int32 MeasureId
	{
		get
		{
			return this.GetValue(TableUtils.MeasureIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeasureIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeasureIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeasureIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureId field.
	/// </summary>
	public string MeasureIdDefault
	{
		get
		{
			return TableUtils.MeasureIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Measure_.MeasureName field.
	/// </summary>
	public string MeasureName
	{
		get
		{
			return this.GetValue(TableUtils.MeasureNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeasureNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeasureNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeasureNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureName field.
	/// </summary>
	public string MeasureNameDefault
	{
		get
		{
			return TableUtils.MeasureNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Measure_.MeasureTypeId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Measure_.MeasureTypeId field.
	/// </summary>
	public string MeasureTypeIdDefault
	{
		get
		{
			return TableUtils.MeasureTypeIdColumn.DefaultValue;
		}
	}


#endregion
}

}
