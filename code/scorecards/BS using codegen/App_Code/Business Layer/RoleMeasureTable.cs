// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace BS.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BaseRoleMeasureTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseRoleMeasureTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseRoleMeasureTable"></seealso>
/// <seealso cref="BaseRoleMeasureSqlTable"></seealso>
/// <seealso cref="RoleMeasureSqlTable"></seealso>
/// <seealso cref="RoleMeasureDefinition"></seealso>
/// <seealso cref="RoleMeasureRecord"></seealso>
/// <seealso cref="BaseRoleMeasureRecord"></seealso>
[SerializableAttribute()]
public class RoleMeasureTable : BaseRoleMeasureTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="RoleMeasureTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="RoleMeasureTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RoleMeasureTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(RoleMeasureTable_SerializationHelper)); //No other values need to be added
    }

#region "Class RoleMeasureTable_SerializationHelper"

    [SerializableAttribute()]
    private class RoleMeasureTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return RoleMeasureTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="RoleMeasureTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RoleMeasureTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static RoleMeasureTable Instance = new RoleMeasureTable();

    private RoleMeasureTable()
    {
    }


} // End class RoleMeasureTable

}
