# Finbourne.Luminesce.Sdk.Model.FilterModel
Representation of the data used in a filter for the where clause

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FilterType** | **FilterType** |  | 
**Type** | **Type** |  | [optional] 
**Filter** | **string** | The filter value | [optional] 
**FilterTo** | **decimal?** | The upper bound filter value for the number filter type | [optional] 
**Values** | **List&lt;string&gt;** | An array of possible values for the set filter type | [optional] 
**DateFrom** | **string** | A lower bound date for the date filter type | [optional] 
**DateTo** | **string** | An upper bound date for the date filter type | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string filter = "example filter";
List<string> values = new List<string>();
string dateFrom = "example dateFrom";
string dateTo = "example dateTo";

FilterModel filterModelInstance = new FilterModel(
    filterType: filterType,
    type: type,
    filter: filter,
    filterTo: filterTo,
    values: values,
    dateFrom: dateFrom,
    dateTo: dateTo);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
