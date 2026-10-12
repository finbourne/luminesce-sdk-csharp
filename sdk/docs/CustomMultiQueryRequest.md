# Finbourne.Luminesce.Sdk.Model.CustomMultiQueryRequest
A caller-supplied set of queries to run in the background, as one multi-query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | An explicit ExecutionId to use.  This must be blank OR assigned to a valid GUID-as-a-string. | [optional] 
**ScalarParameters** | **Dictionary&lt;string, string&gt;** | Scalar parameter values, handed to every query that runs (e.g. filling in &#x60;:someParameter:defaultValue&#x60; style references). At most 100, each named as an identifier of at most 256 characters, with a value of at most 4096. | [optional] 
**Queries** | [**List&lt;CustomMultiQueryItem&gt;**](CustomMultiQueryItem.md) | The queries to run.  Those ready are started in the order given here (one still waiting on those it refers to does not hold up a later one), and each may only refer to queries earlier in the list. | 
**MaxInParallel** | **int?** | Maximum number of the queries that may run concurrently.  Defaults to 1, meaning they run one after another. Explicitly null means as many as their dependencies allow. | [optional] 
**TimeoutSeconds** | **int** | Maximum time each query may run for, in seconds, timed from when it starts: &lt;0 → ∞, 0 → 1200s (20m). There is no limit on the set as a whole. | [optional] 
**KeepForSeconds** | **int** | Maximum time the results may be kept for, in seconds: &lt;0 → 1200 (20m), 0 → 28800 (8h), max &#x3D; 2,678,400 (31d) | [optional] 
**QueryName** | **string** | A name for this set of queries.  This goes into logs and is returned when listing the sets of queries. | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string executionId = "example executionId";
Dictionary<string, string> scalarParameters = new Dictionary<string, string>();
List<CustomMultiQueryItem> queries = new List<CustomMultiQueryItem>();
string queryName = "example queryName";

CustomMultiQueryRequest customMultiQueryRequestInstance = new CustomMultiQueryRequest(
    executionId: executionId,
    scalarParameters: scalarParameters,
    queries: queries,
    maxInParallel: maxInParallel,
    timeoutSeconds: timeoutSeconds,
    keepForSeconds: keepForSeconds,
    queryName: queryName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
