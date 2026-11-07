# Finbourne.Luminesce.Sdk.Model.ExportGrouping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupKeys** | **List&lt;string&gt;** |  | [optional] 
**DateParts** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Aggregations** | [**List&lt;ExportAggregation&gt;**](ExportAggregation.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<string> groupKeys = new List<string>();
Dictionary<string, string> dateParts = new Dictionary<string, string>();
List<ExportAggregation> aggregations = new List<ExportAggregation>();

ExportGrouping exportGroupingInstance = new ExportGrouping(
    groupKeys: groupKeys,
    dateParts: dateParts,
    aggregations: aggregations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
