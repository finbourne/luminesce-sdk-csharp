# Finbourne.Luminesce.Sdk.Model.AvailableParameter
Information about a field that can be designed on (regardless if it currently is)  Kind of a \"mini-available catalog entry\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderName** | **string** | Name of the Provider with a TableParameter | 
**ParameterName** | **string** | Name of the TableParameter on the Provider | 
**Fields** | [**List&lt;MappableField&gt;**](MappableField.md) | Fields that can be mapped to | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string providerName = "providerName";
string parameterName = "parameterName";
List<MappableField> fields = new List<MappableField>();

AvailableParameter availableParameterInstance = new AvailableParameter(
    providerName: providerName,
    parameterName: parameterName,
    fields: fields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
