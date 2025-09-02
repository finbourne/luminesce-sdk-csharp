# Finbourne.Luminesce.Sdk.Model.ColumnInfo
Information on how to construct a file-read sql query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Select** | **bool** | Should the column be used/selected? | [optional] 
**Type** | **DataType** |  | [optional] 
**Name** | **string** | The name of the column | [optional] 
**XPath** | **string** | Xpath for the column (only applicable to XML defined columns) | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

bool select = //"True";
string name = "example name";
string xPath = "example xPath";

ColumnInfo columnInfoInstance = new ColumnInfo(
    select: select,
    type: type,
    name: name,
    xPath: xPath);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
