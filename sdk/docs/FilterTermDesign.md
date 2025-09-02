# Finbourne.Luminesce.Sdk.Model.FilterTermDesign
A single filter clause

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Operator** | **QueryDesignerBinaryOperator** |  | 
**Value** | **string** | The value to compare against (always as a string, but will be formatted to the correct type) | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string value = "value";

FilterTermDesign filterTermDesignInstance = new FilterTermDesign(
    operator: operator,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
