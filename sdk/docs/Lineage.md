# Finbourne.Luminesce.Sdk.Model.Lineage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Subtype** | **string** |  | [optional] 
**Alias** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**DocumentationAsHtml** | **string** |  | [optional] 
**DocumentationAsMarkDown** | **string** |  | [optional] 
**FullText** | **string** |  | [optional] 
**Children** | [**List&lt;Lineage&gt;**](Lineage.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string type = "example type";
string subtype = "example subtype";
string alias = "example alias";
string displayName = "example displayName";
string description = "example description";
string documentationAsHtml = "example documentationAsHtml";
string documentationAsMarkDown = "example documentationAsMarkDown";
string fullText = "example fullText";
List<Lineage> children = new List<Lineage>();

Lineage lineageInstance = new Lineage(
    type: type,
    subtype: subtype,
    alias: alias,
    displayName: displayName,
    description: description,
    documentationAsHtml: documentationAsHtml,
    documentationAsMarkDown: documentationAsMarkDown,
    fullText: fullText,
    children: children);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
