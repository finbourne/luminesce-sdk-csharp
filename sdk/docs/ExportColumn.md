# Finbourne.Luminesce.Sdk.Model.ExportColumn

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColId** | **string** |  | 
**Header** | **string** |  | [optional] 
**DataType** | **ExportColumnDataType** |  | [optional] 
**Hidden** | **bool** |  | [optional] 
**WrapText** | **bool** |  | [optional] 
**ColumnColor** | [**ExportColumnColor**](ExportColumnColor.md) |  | [optional] 
**Number** | [**ExportNumberFormat**](ExportNumberFormat.md) |  | [optional] 
**Date** | [**ExportDateFormat**](ExportDateFormat.md) |  | [optional] 
**ConditionalRules** | [**List&lt;ExportConditionalRule&gt;**](ExportConditionalRule.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string colId = "colId";
string header = "example header";
bool hidden = //"True";
bool wrapText = //"True";
ExportColumnColor? columnColor = new ExportColumnColor();

ExportNumberFormat? number = new ExportNumberFormat();

ExportDateFormat? date = new ExportDateFormat();

List<ExportConditionalRule> conditionalRules = new List<ExportConditionalRule>();

ExportColumn exportColumnInstance = new ExportColumn(
    colId: colId,
    header: header,
    dataType: dataType,
    hidden: hidden,
    wrapText: wrapText,
    columnColor: columnColor,
    number: number,
    date: date,
    conditionalRules: conditionalRules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
