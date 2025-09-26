# Finbourne.Luminesce.Sdk.Model.ErrorHighlightRequest
Request for Error highlighting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lines** | **List&lt;string&gt;** | The lines of text the user currently has in the editor | 
**EnsureSomeTextIsSelected** | **bool** | If an editor requires some selection of non-whitespace this can be set to true to force at least one visible character to be selected. | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<string> lines = new List<string>();
bool ensureSomeTextIsSelected = //"True";

ErrorHighlightRequest errorHighlightRequestInstance = new ErrorHighlightRequest(
    lines: lines,
    ensureSomeTextIsSelected: ensureSomeTextIsSelected);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
