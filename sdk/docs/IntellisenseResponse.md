# Finbourne.Luminesce.Sdk.Model.IntellisenseResponse
Available intellisense response information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoCompleteList** | [**List&lt;IntellisenseItem&gt;**](IntellisenseItem.md) | The available items at this point | 
**TryAgainSoonForMore** | **bool** | Should the caller try again soon? (true means a cache is being built and this is a preliminary response!) | 
**SqlWithMarker** | **string** | The SQL this is for with characters indicating the location the pop-up is for | 
**StartReplacementPosition** | [**CursorPosition**](CursorPosition.md) |  | 
**EndReplacementPosition** | [**CursorPosition**](CursorPosition.md) |  | 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<IntellisenseItem> autoCompleteList = new List<IntellisenseItem>();
bool tryAgainSoonForMore = //"True";
string sqlWithMarker = "sqlWithMarker";
CursorPosition startReplacementPosition = new CursorPosition();
CursorPosition endReplacementPosition = new CursorPosition();

IntellisenseResponse intellisenseResponseInstance = new IntellisenseResponse(
    autoCompleteList: autoCompleteList,
    tryAgainSoonForMore: tryAgainSoonForMore,
    sqlWithMarker: sqlWithMarker,
    startReplacementPosition: startReplacementPosition,
    endReplacementPosition: endReplacementPosition);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
