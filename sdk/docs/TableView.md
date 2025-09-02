# Finbourne.Luminesce.Sdk.Model.TableView
Representation of the table structure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HeaderNames** | **Dictionary&lt;string, string&gt;** | Mapping of column ids to aliases | 
**ColumnState** | [**List&lt;ColumnStateType&gt;**](ColumnStateType.md) | Array of all columns in the dashboard | 
**Filters** | [**Dictionary&lt;string, FilterModel&gt;**](FilterModel.md) | Filters applied to columns in the dashboard | [optional] 
**Meta** | [**TableMeta**](TableMeta.md) |  | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

Dictionary<string, string> headerNames = new Dictionary<string, string>();
List<ColumnStateType> columnState = new List<ColumnStateType>();
Dictionary<string, FilterModel> filters = new Dictionary<string, FilterModel>();
TableMeta meta = new TableMeta();

TableView tableViewInstance = new TableView(
    headerNames: headerNames,
    columnState: columnState,
    filters: filters,
    meta: meta);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
