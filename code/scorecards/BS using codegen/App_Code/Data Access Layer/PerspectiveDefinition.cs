﻿using System;

namespace BS.Business
{

/// <summary>
/// Contains embedded schema and configuration data that is used by the 
/// <see cref="PerspectiveTable">BS.PerspectiveTable</see> class
/// to initialize the class's TableDefinition.
/// </summary>
/// <seealso cref="PerspectiveTable"></seealso>
public class PerspectiveDefinition
{
#region "Definition (XML) for PerspectiveDefinition table"
	//Next 60 lines contain Table Definition (XML) for table "PerspectiveDefinition"
	private static string _DefinitionString = 
@"<XMLDefinition Generator=""Iron Speed Designer"" Version=""5.0"" Type=""GENERIC"">" +
  @"<ColumnDefinition>" +
    @"<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">" +
      @"<columnName>PerspectiveId</columnName>" +
      @"<columnUIName>Perspective</columnUIName>" +
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
      @"<columnName>PerspectiveName</columnName>" +
      @"<columnUIName>Perspective Name</columnUIName>" +
      @"<columnType>String</columnType>" +
      @"<columnDBType>varchar</columnDBType>" +
      @"<columnLengthSet>50</columnLengthSet>" +
      @"<columnDefault></columnDefault>" +
      @"<columnDBDefault></columnDBDefault>" +
      @"<columnIndex>N</columnIndex>" +
      @"<columnUnique>N</columnUnique>" +
      @"<columnFunction></columnFunction>" +
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
    "</Column>" +
  "</ColumnDefinition>" +
  @"<TableName>Perspective</TableName>" +
  @"<Version></Version>" +
  @"<Owner>dbo</Owner>" +
  @"<TableCodeName>Perspective</TableCodeName>" +
  @"<TableAliasName>Perspective_</TableAliasName>" +
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
	/// <see cref="PerspectiveTable"></see>
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
