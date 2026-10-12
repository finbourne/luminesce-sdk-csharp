# Finbourne.Luminesce.Sdk.Model.CustomMultiQueryItem
One query within a Finbourne.Honeycomb.WebApi.BackgroundQueries.MultiQuery.CustomMultiQueryRequest, given as either raw LuminesceSql or a saved query reference.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Unique name of the query, of at most 31 characters. Later queries refer to this one&#39;s results as &#x60;@Name&#x60;, and it names the result in any export. | 
**Sql** | **string** | The LuminesceSql to run.  Exactly one of this and &#x60;SavedQuery&#x60; must be given. | [optional] 
**SavedQuery** | **string** | A key within the Saved Queries (of the Workspaces API) to load the SQL from.  Exactly one of this and &#x60;Sql&#x60; must be given. e.g. &#x60;personal/YourUserId/items/queries/SomeQuery&#x60; or &#x60;shared/SomeWorkspace/items/queries/SomeQuery&#x60;. | [optional] 
**IsExternalResult** | **bool** | Should the results of this query be fetchable / exported?  If false it is only an intermediate step for later queries. | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string name = "name";
string sql = "example sql";
string savedQuery = "example savedQuery";
bool isExternalResult = //"True";

CustomMultiQueryItem customMultiQueryItemInstance = new CustomMultiQueryItem(
    name: name,
    sql: sql,
    savedQuery: savedQuery,
    isExternalResult: isExternalResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
