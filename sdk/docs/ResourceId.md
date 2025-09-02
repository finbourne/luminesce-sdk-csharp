# Finbourne.Luminesce.Sdk.Model.ResourceId
Unique identifier for a resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope used to identify a resource | 
**Code** | **string** | The code used to identify a resource | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string scope = "scope";
string code = "example code";

ResourceId resourceIdInstance = new ResourceId(
    scope: scope,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
