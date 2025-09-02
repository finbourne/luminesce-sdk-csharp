# Finbourne.Luminesce.Sdk.Model.ScalarParameter
Describes a scalar parameter as defined in the SQL

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the scalar parameter | 
**Type** | **DataType** |  | 
**Value** | **Object** | the default value of the parameter | [optional] 
**ValueOptions** | **List&lt;Object&gt;** | Values of the parameter listed as being available for choosing from. | [optional] 
**ValueMustBeFromOptions** | **bool** | Must Value be one of ValueOptions (if any)? | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "name";
List<Object> valueOptions = new List<Object>();
bool valueMustBeFromOptions = //"True";

ScalarParameter scalarParameterInstance = new ScalarParameter(
    name: name,
    type: type,
    value: value,
    valueOptions: valueOptions,
    valueMustBeFromOptions: valueMustBeFromOptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
