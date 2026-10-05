# Finbourne.Luminesce.Sdk.Model.BackgroundQueryListItem
A background query the calling user currently has available to them

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | ExecutionId of the query | [optional] 
**Query** | **string** | The LuminesceSql of the original request | [optional] 
**QueryName** | **string** | The QueryName given in the original request | [optional] 
**State** | **BackgroundQueryState** |  | [optional] 
**When** | **DateTimeOffset** | When the state of this query (and so its data) was last updated (UTC) | [optional] 
**ExpiresAt** | **DateTimeOffset** | When the query (and its data) may be removed (UTC) | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string executionId = "example executionId";
string query = "example query";
string queryName = "example queryName";

BackgroundQueryListItem backgroundQueryListItemInstance = new BackgroundQueryListItem(
    executionId: executionId,
    query: query,
    queryName: queryName,
    state: state,
    when: when,
    expiresAt: expiresAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
