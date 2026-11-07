# Finbourne.Luminesce.Sdk.Model.TableExport

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TableName** | **string** |  | [optional] 
**Columns** | [**List&lt;ExportColumn&gt;**](ExportColumn.md) |  | [optional] 
**Grouping** | [**ExportGrouping**](ExportGrouping.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string tableName = "example tableName";
List<ExportColumn> columns = new List<ExportColumn>();
ExportGrouping? grouping = new ExportGrouping();


TableExport tableExportInstance = new TableExport(
    tableName: tableName,
    columns: columns,
    grouping: grouping);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
