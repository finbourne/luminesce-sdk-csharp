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

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

