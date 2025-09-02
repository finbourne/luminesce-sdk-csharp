# Finbourne.Luminesce.Sdk.Model.AccessControlledAction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** |  | [optional] 
**Action** | [**ActionId**](ActionId.md) |  | [optional] 
**LimitedSet** | [**List&lt;IdSelectorDefinition&gt;**](IdSelectorDefinition.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string description = "example description";
ActionId? action = new ActionId();

List<IdSelectorDefinition> limitedSet = new List<IdSelectorDefinition>();

AccessControlledAction accessControlledActionInstance = new AccessControlledAction(
    description: description,
    action: action,
    limitedSet: limitedSet);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
