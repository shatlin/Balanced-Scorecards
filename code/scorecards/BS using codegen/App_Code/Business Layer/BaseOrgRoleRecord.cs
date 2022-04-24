// This class is "generated" and will be overwritten.
// Your customizations should be made in OrgRoleRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// The generated superclass for the <see cref="OrgRoleRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="OrgRoleTable"></see> class.
/// </remarks>
/// <seealso cref="OrgRoleTable"></seealso>
/// <seealso cref="OrgRoleRecord"></seealso>
public class BaseOrgRoleRecord : PrimaryKeyRecord
{

	public readonly static OrgRoleTable TableUtils = OrgRoleTable.Instance;

	// Constructors
 
	protected BaseOrgRoleRecord() : base(TableUtils)
	{
	}

	protected BaseOrgRoleRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleId field.
	/// </summary>
	public ColumnValue GetOrgRoleIdValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleId field.
	/// </summary>
	public Int32 GetOrgRoleIdFieldValue()
	{
		return this.GetValue(TableUtils.OrgRoleIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public ColumnValue GetOrgRoleNameValue()
	{
		return this.GetValue(TableUtils.OrgRoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public string GetOrgRoleNameFieldValue()
	{
		return this.GetValue(TableUtils.OrgRoleNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public void SetOrgRoleNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OrgRoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public void SetOrgRoleNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public ColumnValue GetOrgRoleDetailValue()
	{
		return this.GetValue(TableUtils.OrgRoleDetailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public string GetOrgRoleDetailFieldValue()
	{
		return this.GetValue(TableUtils.OrgRoleDetailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public void SetOrgRoleDetailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OrgRoleDetailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public void SetOrgRoleDetailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OrgRoleDetailColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's OrgRole_.OrgRoleId field.
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
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleId field.
	/// </summary>
	public string OrgRoleIdDefault
	{
		get
		{
			return TableUtils.OrgRoleIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public string OrgRoleName
	{
		get
		{
			return this.GetValue(TableUtils.OrgRoleNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OrgRoleNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OrgRoleNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OrgRoleNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleName field.
	/// </summary>
	public string OrgRoleNameDefault
	{
		get
		{
			return TableUtils.OrgRoleNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public string OrgRoleDetail
	{
		get
		{
			return this.GetValue(TableUtils.OrgRoleDetailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OrgRoleDetailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OrgRoleDetailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OrgRoleDetailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's OrgRole_.OrgRoleDetail field.
	/// </summary>
	public string OrgRoleDetailDefault
	{
		get
		{
			return TableUtils.OrgRoleDetailColumn.DefaultValue;
		}
	}


#endregion
}

}
