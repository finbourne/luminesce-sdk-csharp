# Finbourne.Luminesce.Sdk.Model.BackgroundMultiQueryProgressResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Progress** | **string** | The full progress log (up to this point at least) | [optional] 
**Feedback** | [**List&lt;FeedbackEventArgs&gt;**](FeedbackEventArgs.md) | Individual Feedback Messages (to replace Progress).  A given message will be returned from only one call. | [optional] 
**Status** | **TaskStatus** |  | [optional] 
**Queries** | [**List&lt;BackgroundQueryProgressResponse&gt;**](BackgroundQueryProgressResponse.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string progress = "example progress";
List<FeedbackEventArgs> feedback = new List<FeedbackEventArgs>();
List<BackgroundQueryProgressResponse> queries = new List<BackgroundQueryProgressResponse>();

BackgroundMultiQueryProgressResponse backgroundMultiQueryProgressResponseInstance = new BackgroundMultiQueryProgressResponse(
    progress: progress,
    feedback: feedback,
    status: status,
    queries: queries);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
