# Finbourne.Luminesce.Sdk.Model.QueryDesign
Representation of a \"designable Query\" suitable for formatting to SQL or being built from compliant SQL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TableName** | **string** | Name of the table being designed | 
**Alias** | **string** | Alias for the table in the generated SQL, if any | [optional] 
**Fields** | [**List&lt;FieldDesign&gt;**](FieldDesign.md) | Fields to be selected, aggregated over and/or filtered on | 
**JoinedTables** | [**List&lt;JoinedTableDesign&gt;**](JoinedTableDesign.md) | Joined in table to the main TableName / Alias | [optional] 
**OrderBy** | [**List&lt;OrderByTermDesign&gt;**](OrderByTermDesign.md) | Order By clauses to apply | [optional] 
**Limit** | **int?** | Row limit to apply, if any | [optional] 
**Offset** | **int?** | Row offset to apply, if any | [optional] 
**Warnings** | **List&lt;string&gt;** | Any warnings to show the user when converting from SQL to this representation | [optional] 
**AvailableFields** | [**List&lt;AvailableField&gt;**](AvailableField.md) | Fields that are known to be available for design when parsing SQL | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string tableName = "tableName";
string alias = "example alias";
List<FieldDesign> fields = new List<FieldDesign>();
List<JoinedTableDesign> joinedTables = new List<JoinedTableDesign>();
List<OrderByTermDesign> orderBy = new List<OrderByTermDesign>();
List<string> warnings = new List<string>();
List<AvailableField> availableFields = new List<AvailableField>();

QueryDesign queryDesignInstance = new QueryDesign(
    tableName: tableName,
    alias: alias,
    fields: fields,
    joinedTables: joinedTables,
    orderBy: orderBy,
    limit: limit,
    offset: offset,
    warnings: warnings,
    availableFields: availableFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
