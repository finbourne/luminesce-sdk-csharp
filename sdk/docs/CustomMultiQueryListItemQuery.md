# Finbourne.Luminesce.Sdk.Model.CustomMultiQueryListItemQuery
One of the queries of a Finbourne.Honeycomb.WebApi.BackgroundQueries.MultiQuery.CustomMultiQueryListItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The Name given to the query in the original request | [optional] 
**State** | **BackgroundQueryState** |  | [optional] 
**HasResult** | **bool** | Whether its results may be fetched | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "example name";
bool hasResult = //"True";

CustomMultiQueryListItemQuery customMultiQueryListItemQueryInstance = new CustomMultiQueryListItemQuery(
    name: name,
    state: state,
    hasResult: hasResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
