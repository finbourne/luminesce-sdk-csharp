# Finbourne.Luminesce.Sdk.Model.DateParameters
Collection of date parameters used in dashboards

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateFrom** | **DateTimeOffset?** | Parameter to determine the lower bound in a date range | [optional] 
**DateTo** | **DateTimeOffset?** | Parameter to determine the upper bound in a date range | [optional] 
**EffectiveAt** | **DateTimeOffset?** | EffectiveAt of the dashboard | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | EffectiveFrom of the dashboard | [optional] 
**AsAt** | **DateTimeOffset** | AsAt of the dashboard | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;


DateParameters dateParametersInstance = new DateParameters(
    dateFrom: dateFrom,
    dateTo: dateTo,
    effectiveAt: effectiveAt,
    effectiveFrom: effectiveFrom,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
