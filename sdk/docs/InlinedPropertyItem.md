# Finbourne.Luminesce.Sdk.Model.InlinedPropertyItem
Information about a inlined property so that decorated properties can be inlined into luminesce

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Key of the property | 
**Name** | **string** | Name of the property | [optional] 
**IsMain** | **bool** | Is Main indicator for the property | [optional] 
**Description** | **string** | Description of the property | [optional] 
**DataType** | **string** | Data type of the property | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string key = "key";
string name = "example name";
bool isMain = //"True";
string description = "example description";
string dataType = "example dataType";

InlinedPropertyItem inlinedPropertyItemInstance = new InlinedPropertyItem(
    key: key,
    name: name,
    isMain: isMain,
    description: description,
    dataType: dataType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
