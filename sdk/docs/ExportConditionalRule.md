# Finbourne.Luminesce.Sdk.Model.ExportConditionalRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **ExportRuleOperator** |  | 
**Value** | **string** |  | [optional] 
**ValueTo** | **string** |  | [optional] 
**ValueColumn** | **string** |  | [optional] 
**ValueToColumn** | **string** |  | [optional] 
**SourceColumn** | **string** |  | [optional] 
**Effect** | **ExportRuleEffect** |  | 
**Color** | **ExportRuleColor** |  | [optional] 
**Hex** | **string** |  | [optional] 
**Text** | **string** |  | [optional] 
**Format** | **string** |  | [optional] 
**IncludeAggregates** | **bool** |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string value = "example value";
string valueTo = "example valueTo";
string valueColumn = "example valueColumn";
string valueToColumn = "example valueToColumn";
string sourceColumn = "example sourceColumn";
string hex = "example hex";
string text = "example text";
string format = "example format";
bool includeAggregates = //"True";

ExportConditionalRule exportConditionalRuleInstance = new ExportConditionalRule(
    operator: operator,
    value: value,
    valueTo: valueTo,
    valueColumn: valueColumn,
    valueToColumn: valueToColumn,
    sourceColumn: sourceColumn,
    effect: effect,
    color: color,
    hex: hex,
    text: text,
    format: format,
    includeAggregates: includeAggregates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
