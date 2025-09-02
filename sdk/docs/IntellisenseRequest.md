# Finbourne.Luminesce.Sdk.Model.IntellisenseRequest
Representation of a request for IntellisenseItems

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Lines** | **List&lt;string&gt;** | The lines of text the user currently has in the editor | 
**Position** | [**CursorPosition**](CursorPosition.md) |  | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<string> lines = new List<string>();
CursorPosition position = new CursorPosition();

IntellisenseRequest intellisenseRequestInstance = new IntellisenseRequest(
    lines: lines,
    position: position);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
