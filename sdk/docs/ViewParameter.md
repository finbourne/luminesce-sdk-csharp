# Finbourne.Luminesce.Sdk.Model.ViewParameter
Parameters of view

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the provider | 
**DataType** | **DataType** |  | 
**Value** | **string** | Value of the provider | 
**IsTableDataMandatory** | **bool** | Should this be selected? False would imply it is only being filtered on. Ignored when Aggregations are present | [optional] 
**Description** | **string** | Description of the parameter | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "name";
string value = "value";
bool isTableDataMandatory = //"True";
string description = "example description";

ViewParameter viewParameterInstance = new ViewParameter(
    name: name,
    dataType: dataType,
    value: value,
    isTableDataMandatory: isTableDataMandatory,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
