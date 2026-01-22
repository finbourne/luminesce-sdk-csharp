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
**Lineage** | [**TableLineage**](TableLineage.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

bool hasData = //"True";
string progress = "example progress";
List<FeedbackEventArgs> feedback = new List<FeedbackEventArgs>();
string query = "example query";
string queryName = "example queryName";
List<Column> columnsAvailable = new List<Column>();
TableLineage? lineage = new TableLineage();


BackgroundQueryProgressResponse backgroundQueryProgressResponseInstance = new BackgroundQueryProgressResponse(
    hasData: hasData,
    rowCount: rowCount,
    status: status,
    state: state,
    progress: progress,
    feedback: feedback,
    query: query,
    queryName: queryName,
    columnsAvailable: columnsAvailable,
    lineage: lineage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
