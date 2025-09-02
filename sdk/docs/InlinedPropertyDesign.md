# Finbourne.Luminesce.Sdk.Model.InlinedPropertyDesign
Representation of a set of inlined properties for a given provider so that SQL can be generated to be able to inline properties into luminesce

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderName** | **string** | The provider name for which these properties are to be inlined | [optional] 
**ProviderNameExtension** | **string** | The provider extension name for extended providers | [optional] 
**InlinedPropertyItems** | [**List&lt;InlinedPropertyItem&gt;**](InlinedPropertyItem.md) | Collection of Inlined properties | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string providerName = "example providerName";
string providerNameExtension = "example providerNameExtension";
List<InlinedPropertyItem> inlinedPropertyItems = new List<InlinedPropertyItem>();

InlinedPropertyDesign inlinedPropertyDesignInstance = new InlinedPropertyDesign(
    providerName: providerName,
    providerNameExtension: providerNameExtension,
    inlinedPropertyItems: inlinedPropertyItems);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
