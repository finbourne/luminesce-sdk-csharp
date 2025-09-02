# Finbourne.Luminesce.Sdk.Model.BackgroundQueryCancelResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HadData** | **bool** |  | [optional] 
**PreviousStatus** | **TaskStatus** |  | [optional] 
**PreviousState** | **BackgroundQueryState** |  | [optional] 
**Progress** | **string** |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

bool hadData = //"True";
string progress = "example progress";

BackgroundQueryCancelResponse backgroundQueryCancelResponseInstance = new BackgroundQueryCancelResponse(
    hadData: hadData,
    previousStatus: previousStatus,
    previousState: previousState,
    progress: progress);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
