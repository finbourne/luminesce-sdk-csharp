# Finbourne.Luminesce.Sdk.Model.AvailableField
Information about a field that can be designed on (regardless if it currently is)  Kind of a \"mini-available catalog entry\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Field | 
**DataType** | **DataType** |  | [optional] 
**FieldType** | **FieldType** |  | 
**IsMain** | **bool?** | Is this a Main Field within the Provider | [optional] 
**IsPrimaryKey** | **bool?** | Is this a member of the PrimaryKey of the Provider | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "name";
bool? isMain = //"True";
bool? isPrimaryKey = //"True";

AvailableField availableFieldInstance = new AvailableField(
    name: name,
    dataType: dataType,
    fieldType: fieldType,
    isMain: isMain,
    isPrimaryKey: isPrimaryKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
