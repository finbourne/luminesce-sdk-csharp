# Finbourne.Luminesce.Sdk.Model.LusidGridData
Representation of the data we will get from the dashboard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidGridDesign** | [**TableView**](TableView.md) |  | 
**ResourceId** | [**ResourceId**](ResourceId.md) |  | 
**DashboardType** | **DashboardType** |  | [optional] 
**UseSettleDate** | **bool?** | Whether to use the Settlement date or the Transaction date | [optional] 
**Dates** | [**DateParameters**](DateParameters.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

TableView lusidGridDesign = new TableView();
ResourceId resourceId = new ResourceId();
bool? useSettleDate = //"True";
DateParameters? dates = new DateParameters();


LusidGridData lusidGridDataInstance = new LusidGridData(
    lusidGridDesign: lusidGridDesign,
    resourceId: resourceId,
    dashboardType: dashboardType,
    useSettleDate: useSettleDate,
    dates: dates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
