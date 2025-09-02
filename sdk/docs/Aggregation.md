# Finbourne.Luminesce.Sdk.Model.Aggregation
How to aggregate over a field

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **AggregateFunction** |  | 
**Alias** | **string** | Alias, if any, for the Aggregate expression when selected | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string alias = "example alias";

Aggregation aggregationInstance = new Aggregation(
    type: type,
    alias: alias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
