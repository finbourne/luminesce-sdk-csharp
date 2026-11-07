# Finbourne.Luminesce.Sdk.Model.ExportNumberFormat

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MinDecimals** | **int?** |  | [optional] 
**MaxDecimals** | **int?** |  | [optional] 
**ThousandSeparator** | **bool** |  | [optional] 
**DisplayAsPercentage** | **bool** |  | [optional] 
**NegativeNumberFormat** | **ExportNegativeNumberFormat** |  | [optional] 
**ExcelFormat** | **string** |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

bool thousandSeparator = //"True";
bool displayAsPercentage = //"True";
string excelFormat = "example excelFormat";

ExportNumberFormat exportNumberFormatInstance = new ExportNumberFormat(
    minDecimals: minDecimals,
    maxDecimals: maxDecimals,
    thousandSeparator: thousandSeparator,
    displayAsPercentage: displayAsPercentage,
    negativeNumberFormat: negativeNumberFormat,
    excelFormat: excelFormat);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
