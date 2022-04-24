// This class is "generated" and will be overwritten.
// Your customizations should be made in MeasureRoleDetailRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="MeasureRoleDetailRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MeasureRoleDetailTable"></see> class.
/// </remarks>
/// <seealso cref="MeasureRoleDetailTable"></seealso>
/// <seealso cref="MeasureRoleDetailRecord"></seealso>
public class BaseMeasureRoleDetailRecord : PrimaryKeyRecord
{

	public readonly static MeasureRoleDetailTable TableUtils = MeasureRoleDetailTable.Instance;

	// Constructors
 
	protected BaseMeasureRoleDetailRecord() : base(TableUtils)
	{
	}

	protected BaseMeasureRoleDetailRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MeasureDetailId field.
	/// </summary>
	public ColumnValue GetMeasureDetailIdValue()
	{
		return this.GetValue(TableUtils.MeasureDetailIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MeasureDetailId field.
	/// </summary>
	public Int32 GetMeasureDetailIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureDetailIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public ColumnValue GetMeasureIdValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public Int32 GetMeasureIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public ColumnValue GetOrgRoleIdValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public Int32 GetOrgRoleIdFieldValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public ColumnValue GetActualValue()
	{
		return this.GetValue(TableUtils.ActualColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public Decimal GetActualFieldValue()
	{
		return this.GetValue(TableUtils.ActualColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public void SetActualFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public void SetActualFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public void SetActualFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public void SetActualFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActualColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public void SetActualFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActualColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public ColumnValue GetTargetValue()
	{
		return this.GetValue(TableUtils.TargetColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public Decimal GetTargetFieldValue()
	{
		return this.GetValue(TableUtils.TargetColumn).ToDecimal();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public void SetTargetFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TargetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public void SetTargetFieldValue(string val)
	{
		this.SetString(val, TableUtils.TargetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public void SetTargetFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TargetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public void SetTargetFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TargetColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public void SetTargetFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TargetColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public ColumnValue GetMonthIdValue()
	{
		return this.GetValue(TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public Int32 GetMonthIdFieldValue()
	{
		return this.GetValue(TableUtils.MonthIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public void SetMonthIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public void SetMonthIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public void SetMonthIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public void SetMonthIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MonthIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public void SetMonthIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MonthIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public ColumnValue GetYearIdValue()
	{
		return this.GetValue(TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public Int32 GetYearIdFieldValue()
	{
		return this.GetValue(TableUtils.YearIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public void SetYearIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public void SetYearIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public void SetYearIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public void SetYearIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YearIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public void SetYearIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.YearIdColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.MeasureDetailId field.
	/// </summary>
	public Int32 MeasureDetailId
	{
		get
		{
			return this.GetValue(TableUtils.MeasureDetailIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MeasureDetailIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MeasureDetailIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MeasureDetailIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureDetailId field.
	/// </summary>
	public string MeasureDetailIdDefault
	{
		get
		{
			return TableUtils.MeasureDetailIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.MeasureId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MeasureId field.
	/// </summary>
	public string MeasureIdDefault
	{
		get
		{
			return TableUtils.MeasureIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public Int32 OrgRoleId
	{
		get
		{
			return this.GetValue(TableUtils.OrgRoleIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OrgRoleIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OrgRoleIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OrgRoleIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.OrgRoleId field.
	/// </summary>
	public string OrgRoleIdDefault
	{
		get
		{
			return TableUtils.OrgRoleIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public Decimal Actual
	{
		get
		{
			return this.GetValue(TableUtils.ActualColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ActualColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActualSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActualColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Actual field.
	/// </summary>
	public string ActualDefault
	{
		get
		{
			return TableUtils.ActualColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public Decimal Target
	{
		get
		{
			return this.GetValue(TableUtils.TargetColumn).ToDecimal();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TargetColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TargetSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TargetColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.Target field.
	/// </summary>
	public string TargetDefault
	{
		get
		{
			return TableUtils.TargetColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.MonthId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.MonthId field.
	/// </summary>
	public string MonthIdDefault
	{
		get
		{
			return TableUtils.MonthIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's MeasureRoleDetail_.YearId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's MeasureRoleDetail_.YearId field.
	/// </summary>
	public string YearIdDefault
	{
		get
		{
			return TableUtils.YearIdColumn.DefaultValue;
		}
	}


#endregion
}

}
