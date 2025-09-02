# Finbourne.Luminesce.Sdk.Model.AccessControlledResourceIdentifierPartSchemaAttribute

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** |  | [optional] 
**Name** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Required** | **bool** |  | [optional] 
**ValuesPath** | **string** |  | [optional] 
**TypeId** | **Object** |  | [optional] [readonly] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "example name";
string displayName = "example displayName";
string description = "example description";
bool required = //"True";
string valuesPath = "example valuesPath";

AccessControlledResourceIdentifierPartSchemaAttribute accessControlledResourceIdentifierPartSchemaAttributeInstance = new AccessControlledResourceIdentifierPartSchemaAttribute(
    index: index,
    name: name,
    displayName: displayName,
    description: description,
    required: required,
    valuesPath: valuesPath,
    typeId: typeId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
