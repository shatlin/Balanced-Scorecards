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
/// See <see cref="BaseYearTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseYearTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseYearTable"></seealso>
/// <seealso cref="BaseYearSqlTable"></seealso>
/// <seealso cref="YearSqlTable"></seealso>
/// <seealso cref="YearDefinition"></seealso>
/// <seealso cref="YearRecord"></seealso>
/// <seealso cref="BaseYearRecord"></seealso>
[SerializableAttribute()]
public class YearTable : BaseYearTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="YearTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="YearTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="YearTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(YearTable_SerializationHelper)); //No other values need to be added
    }

#region "Class YearTable_SerializationHelper"

    [SerializableAttribute()]
    private class YearTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return YearTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="YearTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="YearTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static YearTable Instance = new YearTable();

    private YearTable()
    {
    }


} // End class YearTable

}
