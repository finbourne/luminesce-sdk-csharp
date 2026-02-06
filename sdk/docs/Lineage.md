# Finbourne.Luminesce.Sdk.Model.Lineage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Subtype** | **string** |  | [optional] 
**Alias** | **string** |  | [optional] 
**ColumnTitleTooltip** | **string** |  | [optional] 
**ColumnTitleIcon** | **LineageColumnIcon** |  | [optional] 
**ExplainTitle** | **string** |  | [optional] 
**ExplainTooltip** | **string** |  | [optional] 
**FullFormula** | **string** |  | [optional] 
**DocumentationAsHtml** | **string** |  | [optional] 
**DocumentationAsMarkDown** | **string** |  | [optional] 
**Children** | [**List&lt;Lineage&gt;**](Lineage.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string type = "example type";
string subtype = "example subtype";
string alias = "example alias";
string columnTitleTooltip = "example columnTitleTooltip";
string explainTitle = "example explainTitle";
string explainTooltip = "example explainTooltip";
string fullFormula = "example fullFormula";
string documentationAsHtml = "example documentationAsHtml";
string documentationAsMarkDown = "example documentationAsMarkDown";
List<Lineage> children = new List<Lineage>();

Lineage lineageInstance = new Lineage(
    type: type,
    subtype: subtype,
    alias: alias,
    columnTitleTooltip: columnTitleTooltip,
    columnTitleIcon: columnTitleIcon,
    explainTitle: explainTitle,
    explainTooltip: explainTooltip,
    fullFormula: fullFormula,
    documentationAsHtml: documentationAsHtml,
    documentationAsMarkDown: documentationAsMarkDown,
    children: children);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
