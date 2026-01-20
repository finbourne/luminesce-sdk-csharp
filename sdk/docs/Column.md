# Finbourne.Luminesce.Sdk.Model.Column

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsPrimaryKey** | **bool** |  | [optional] 
**IsMain** | **bool** |  | [optional] 
**IsRequiredByProvider** | **bool** |  | [optional] 
**MandatoryForActions** | **string** |  | [optional] 
**Lineage** | [**Lineage**](Lineage.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Type** | **DataType** |  | [optional] 
**Description** | **string** |  | [optional] 
**DisplayName** | **string** |  | [optional] 
**ConditionUsage** | **ConditionAttributes** |  | [optional] 
**SampleValues** | **string** |  | [optional] 
**AllowedValues** | **string** |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

bool isPrimaryKey = //"True";
bool isMain = //"True";
bool isRequiredByProvider = //"True";
string mandatoryForActions = "example mandatoryForActions";
Lineage? lineage = new Lineage();

string name = "example name";
string description = "example description";
string displayName = "example displayName";
string sampleValues = "example sampleValues";
string allowedValues = "example allowedValues";

Column columnInstance = new Column(
    isPrimaryKey: isPrimaryKey,
    isMain: isMain,
    isRequiredByProvider: isRequiredByProvider,
    mandatoryForActions: mandatoryForActions,
    lineage: lineage,
    name: name,
    type: type,
    description: description,
    displayName: displayName,
    conditionUsage: conditionUsage,
    sampleValues: sampleValues,
    allowedValues: allowedValues);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
