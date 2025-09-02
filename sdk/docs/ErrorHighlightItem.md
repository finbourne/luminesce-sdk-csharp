# Finbourne.Luminesce.Sdk.Model.ErrorHighlightItem
Representation of a sql error

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Start** | [**CursorPosition**](CursorPosition.md) |  | 
**Stop** | [**CursorPosition**](CursorPosition.md) |  | 
**NoViableAlternativeStart** | [**CursorPosition**](CursorPosition.md) |  | [optional] 
**Length** | **int** | The length of the error token counting line breaks if any | 
**Message** | **string** | The error message | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

CursorPosition start = new CursorPosition();
CursorPosition stop = new CursorPosition();
CursorPosition? noViableAlternativeStart = new CursorPosition();

string message = "message";

ErrorHighlightItem errorHighlightItemInstance = new ErrorHighlightItem(
    start: start,
    stop: stop,
    noViableAlternativeStart: noViableAlternativeStart,
    length: length,
    message: message);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
