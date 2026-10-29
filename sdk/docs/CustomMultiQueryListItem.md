# Finbourne.Luminesce.Sdk.Model.CustomMultiQueryListItem
A custom multi-query the calling user currently has results of available to them

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | ExecutionId of the multi-query, its queries having ExecutionIds of &#x60;{ExecutionId}_{Name}&#x60; | [optional] 
**QueryName** | **string** | The QueryName given in the original request | [optional] 
**State** | **BackgroundQueryState** |  | [optional] 
**StartedAt** | **DateTimeOffset?** | When it was started (UTC) | [optional] 
**When** | **DateTimeOffset** | When the state of it was last updated (UTC) | [optional] 
**ExpiresAt** | **DateTimeOffset** | When it (and the data of its queries) may be removed (UTC) | [optional] 
**ExportedTo** | **string** | The Drive path its results were saved to once done, if it was started with an &#x60;export&#x60; and they were | [optional] 
**Queries** | [**List&lt;CustomMultiQueryListItemQuery&gt;**](CustomMultiQueryListItemQuery.md) | Its queries whose results may be fetched (those that are external results), in request order | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string executionId = "example executionId";
string queryName = "example queryName";
string exportedTo = "example exportedTo";
List<CustomMultiQueryListItemQuery> queries = new List<CustomMultiQueryListItemQuery>();

CustomMultiQueryListItem customMultiQueryListItemInstance = new CustomMultiQueryListItem(
    executionId: executionId,
    queryName: queryName,
    state: state,
    startedAt: startedAt,
    when: when,
    expiresAt: expiresAt,
    exportedTo: exportedTo,
    queries: queries);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
