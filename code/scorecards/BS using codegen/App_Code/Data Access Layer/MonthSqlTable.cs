// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - overriding base class methods

namespace BS.Data
{

/// <summary>
/// Used by the <see cref="MonthTable"></see> class to access and/or modify the database.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="MonthTable"></see> class.
/// <para>
/// This is a "safe" class, meaning that it is generated once and never overwritten. 
/// Any changes you make to this class will be preserved when you regenerate your application.
/// </para>
/// </remarks>
/// <seealso cref="MonthTable"></seealso>
public class MonthSqlTable : BaseMonthSqlTable
{
} // End class MonthSqlTable

}
