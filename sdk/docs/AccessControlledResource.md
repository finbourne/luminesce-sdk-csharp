# Finbourne.Luminesce.Sdk.Model.AccessControlledResource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Application** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Actions** | [**List&lt;AccessControlledAction&gt;**](AccessControlledAction.md) |  | [optional] 
**IdentifierParts** | [**List&lt;AccessControlledResourceIdentifierPartSchemaAttribute&gt;**](AccessControlledResourceIdentifierPartSchemaAttribute.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string application = "example application";
string name = "example name";
string description = "example description";
List<AccessControlledAction> actions = new List<AccessControlledAction>();
List<AccessControlledResourceIdentifierPartSchemaAttribute> identifierParts = new List<AccessControlledResourceIdentifierPartSchemaAttribute>();

AccessControlledResource accessControlledResourceInstance = new AccessControlledResource(
    application: application,
    name: name,
    description: description,
    actions: actions,
    identifierParts: identifierParts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
