# Finbourne.Luminesce.Sdk.Model.OrderByTermDesign
A single clause within an Order BY

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Name of the field to order by | 
**Direction** | **OrderByDirection** |  | [optional] 
**TableAlias** | **string** | Table Alias of the field to order by | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string field = "field";
string tableAlias = "example tableAlias";

OrderByTermDesign orderByTermDesignInstance = new OrderByTermDesign(
    field: field,
    direction: direction,
    tableAlias: tableAlias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
