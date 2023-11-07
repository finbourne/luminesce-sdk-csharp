# Finbourne.Luminesce.Sdk.Model.BackgroundQueryProgressResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasData** | **bool** | Is there currently data for this Query? | [optional] 
**RowCount** | **int** | Number of rows of data held. -1 if none as yet. | [optional] 
**Status** | **TaskStatus** |  | [optional] 
**State** | **BackgroundQueryState** |  | [optional] 
**Progress** | **string** | The full progress log (up to this point at least) | [optional] 
**Feedback** | [**List&lt;FeedbackEventArgs&gt;**](FeedbackEventArgs.md) | Individual Feedback Messages (to replace Progress).  A given message will be returned from only one call. | [optional] 
**Query** | **string** | The LuminesceSql of the original request | [optional] 
**QueryName** | **string** | The QueryName given in the original request | [optional] 
**ColumnsAvailable** | [**List&lt;Column&gt;**](Column.md) | When HasData is true this is the schema of columns that will be returned if the data is requested | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

