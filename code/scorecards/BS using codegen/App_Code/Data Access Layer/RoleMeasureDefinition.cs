using System;

namespace BS.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="RoleMeasureTable">BS.RoleMeasureTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="RoleMeasureTable"></seealso>
public class RoleMeasureDefinition
{
#region "Definition (XML) for RoleMeasureDefinition table"
	//Next 158 lines contain Table Definition (XML) for table "RoleMeasureDefinition"
	private static string _DefinitionString = 
@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""5.0"" Type=""GENERIC"">" +
  @"<ColumnDefinition>" +
    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">" +
      @"<columnName>RoleMeasureId</columnName>" +
      @"<columnUIName>Role Measure</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>Y</columnIndex>" +
      @"<columnUnique>Y</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>Y</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>Y</columnComputed>" +
      @"<columnIdentity>Y</columnIdentity>" +
      @"<columnReadOnly>Y</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
    "</Column>" +
    @"<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">" +
      @"<columnName>OrgRoleId</columnName>" +
      @"<columnUIName>Organization Role</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_RoleMeasure_OrgRole</columnFKName>" +
        @"<columnFKTable>BS.Business.OrgRoleTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>dbo</columnFKOwner>" +
        @"<columnFKColumn>OrgRoleId</columnFKColumn>" +
        @"<columnFKColumnDisplay>OrgRoleName</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">" +
      @"<columnName>MeasureId</columnName>" +
      @"<columnUIName>Measure</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_RoleMeasure_Measure</columnFKName>" +
        @"<columnFKTable>BS.Business.MeasureTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>dbo</columnFKOwner>" +
        @"<columnFKColumn>MeasureId</columnFKColumn>" +
        @"<columnFKColumnDisplay>MeasureName</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">" +
      @"<columnName>ObjectiveId</columnName>" +
      @"<columnUIName>Objective</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_RoleMeasure_Objective</columnFKName>" +
        @"<columnFKTable>BS.Business.ObjectiveTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>dbo</columnFKOwner>" +
        @"<columnFKColumn>ObjectiveId</columnFKColumn>" +
        @"<columnFKColumnDisplay>ObjectiveName</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
    @"<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">" +
      @"<columnName>Perspectiveid</columnName>" +
      @"<columnUIName>Perspectiveid</columnUIName>" +
      @"<columnType>Number</columnType>" +
      @"<columnDBType>int</columnDBType>" +
      @"<columnLengthSet>10.0</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction>notrim</columnFunction>" +
      @"<columnDBFormat></columnDBFormat>" +
      @"<columnPK>N</columnPK>" +
      @"<columnPermanent>N</columnPermanent>" +
      @"<columnComputed>N</columnComputed>" +
      @"<columnIdentity>N</columnIdentity>" +
      @"<columnReadOnly>N</columnReadOnly>" +
      @"<columnRequired>Y</columnRequired>" +
      @"<columnNotNull>Y</columnNotNull>" +
      @"<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>" +
      @"<columnTableAliasName></columnTableAliasName>" +
      @"<foreignKey>" +
        @"<columnFKName>FK_RoleMeasure_Perspective</columnFKName>" +
        @"<columnFKTable>BS.Business.PerspectiveTable, App_Code</columnFKTable>" +
        @"<columnFKOwner>dbo</columnFKOwner>" +
        @"<columnFKColumn>PerspectiveId</columnFKColumn>" +
        @"<columnFKColumnDisplay>PerspectiveName</columnFKColumnDisplay>" +
        @"<foreignKeyType>Explicit</foreignKeyType>" +
      "</foreignKey>" +
    "</Column>" +
  "</ColumnDefinition>" +
  @"<TableName>RoleMeasure</TableName>" +
  @"<Version></Version>" +
  @"<Owner>dbo</Owner>" +
  @"<TableCodeName>RoleMeasure</TableCodeName>" +
  @"<TableAliasName>RoleMeasure_</TableAliasName>" +
  @"<ConnectionName>DatabaseiScoreDB1</ConnectionName>" +
  @"<canCreateRecords Source=""Database"">Y</canCreateRecords>" +
  @"<canEditRecords Source=""Database"">Y</canEditRecords>" +
  @"<canDeleteRecords Source=""Database"">Y</canDeleteRecords>" +
  @"<canViewRecords Source=""Database"">Y</canViewRecords>" +
  @"<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>" +
  @"<AppShortName>BS</AppShortName>" +
"</XMLDefinition>";
#endregion

	/// <summary>
	/// Gets the embedded schema and configuration data for the  
	/// <see cref="RoleMeasureTable"></see>
	/// class's TableDefinition.
	/// </summary>
	/// <remarks>This function is only called once at runtime.</remarks>
	/// <returns>An XML string.</returns>
	public static string GetXMLString()
	{
		return _DefinitionString;
	}
}

}
