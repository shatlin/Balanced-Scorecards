// This class is "generated" and will be overwritten.
// Your customizations should be made in RoleMeasureRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="RoleMeasureRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RoleMeasureTable"></see> class.
/// </remarks>
/// <seealso cref="RoleMeasureTable"></seealso>
/// <seealso cref="RoleMeasureRecord"></seealso>
public class BaseRoleMeasureRecord : PrimaryKeyRecord
{

	public readonly static RoleMeasureTable TableUtils = RoleMeasureTable.Instance;

	// Constructors
 
	protected BaseRoleMeasureRecord() : base(TableUtils)
	{
	}

	protected BaseRoleMeasureRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.RoleMeasureId field.
	/// </summary>
	public ColumnValue GetRoleMeasureIdValue()
	{
		return this.GetValue(TableUtils.RoleMeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.RoleMeasureId field.
	/// </summary>
	public Int32 GetRoleMeasureIdFieldValue()
	{
		return this.GetValue(TableUtils.RoleMeasureIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public ColumnValue GetOrgRoleIdValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public Int32 GetOrgRoleIdFieldValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public void SetOrgRoleIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public ColumnValue GetMeasureIdValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public Int32 GetMeasureIdFieldValue()
	{
		return this.GetValue(TableUtils.MeasureIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public void SetMeasureIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MeasureIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public ColumnValue GetObjectiveIdValue()
	{
		return this.GetValue(TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public Int32 GetObjectiveIdFieldValue()
	{
		return this.GetValue(TableUtils.ObjectiveIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public void SetObjectiveIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public void SetObjectiveIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public void SetObjectiveIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public void SetObjectiveIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ObjectiveIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public void SetObjectiveIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ObjectiveIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public ColumnValue GetPerspectiveidValue()
	{
		return this.GetValue(TableUtils.PerspectiveidColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public Int32 GetPerspectiveidFieldValue()
	{
		return this.GetValue(TableUtils.PerspectiveidColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public void SetPerspectiveidFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PerspectiveidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public void SetPerspectiveidFieldValue(string val)
	{
		this.SetString(val, TableUtils.PerspectiveidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public void SetPerspectiveidFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PerspectiveidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public void SetPerspectiveidFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PerspectiveidColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public void SetPerspectiveidFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PerspectiveidColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RoleMeasure_.RoleMeasureId field.
	/// </summary>
	public Int32 RoleMeasureId
	{
		get
		{
			return this.GetValue(TableUtils.RoleMeasureIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RoleMeasureIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RoleMeasureIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RoleMeasureIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.RoleMeasureId field.
	/// </summary>
	public string RoleMeasureIdDefault
	{
		get
		{
			return TableUtils.RoleMeasureIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RoleMeasure_.OrgRoleId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.OrgRoleId field.
	/// </summary>
	public string OrgRoleIdDefault
	{
		get
		{
			return TableUtils.OrgRoleIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RoleMeasure_.MeasureId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.MeasureId field.
	/// </summary>
	public string MeasureIdDefault
	{
		get
		{
			return TableUtils.MeasureIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RoleMeasure_.ObjectiveId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.ObjectiveId field.
	/// </summary>
	public string ObjectiveIdDefault
	{
		get
		{
			return TableUtils.ObjectiveIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public Int32 Perspectiveid
	{
		get
		{
			return this.GetValue(TableUtils.PerspectiveidColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PerspectiveidColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PerspectiveidSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PerspectiveidColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RoleMeasure_.Perspectiveid field.
	/// </summary>
	public string PerspectiveidDefault
	{
		get
		{
			return TableUtils.PerspectiveidColumn.DefaultValue;
		}
	}


#endregion
}

}
