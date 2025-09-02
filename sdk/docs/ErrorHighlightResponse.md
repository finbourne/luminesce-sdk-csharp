# Finbourne.Luminesce.Sdk.Model.ErrorHighlightResponse
Response for error highlighting

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;ErrorHighlightItem&gt;**](ErrorHighlightItem.md) | The errors within the Sql | 
**SqlWithMarker** | **string** | The SQL this is for, with characters indicating the error locations | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<ErrorHighlightItem> errors = new List<ErrorHighlightItem>();
string sqlWithMarker = "sqlWithMarker";

ErrorHighlightResponse errorHighlightResponseInstance = new ErrorHighlightResponse(
    errors: errors,
    sqlWithMarker: sqlWithMarker);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
