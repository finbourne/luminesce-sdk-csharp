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
**Recipe** | **string** | The recipe to use for valuations | [optional] 
**Currency** | **string** | The currency to use for valuations | [optional] 
**Tenor** | **string** | The tenor to use for valuations | [optional] 
**OrderFlow** | **string** | Type of order flow to include | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

TableView lusidGridDesign = new TableView();
ResourceId resourceId = new ResourceId();
bool? useSettleDate = //"True";
DateParameters? dates = new DateParameters();

string recipe = "example recipe";
string currency = "example currency";
string tenor = "example tenor";
string orderFlow = "example orderFlow";

LusidGridData lusidGridDataInstance = new LusidGridData(
    lusidGridDesign: lusidGridDesign,
    resourceId: resourceId,
    dashboardType: dashboardType,
    useSettleDate: useSettleDate,
    dates: dates,
    recipe: recipe,
    currency: currency,
    tenor: tenor,
    orderFlow: orderFlow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
