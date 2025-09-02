# Finbourne.Luminesce.Sdk.Model.BackgroundQueryResponse
Response for Background Query Start requests

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **string** | ExecutionId of the started-query | [optional] 
**Progress** | [**Link**](Link.md) |  | [optional] 
**Cancel** | [**Link**](Link.md) |  | [optional] 
**FetchJson** | [**Link**](Link.md) |  | [optional] 
**FetchJsonProper** | [**Link**](Link.md) |  | [optional] 
**FetchXml** | [**Link**](Link.md) |  | [optional] 
**FetchParquet** | [**Link**](Link.md) |  | [optional] 
**FetchCsv** | [**Link**](Link.md) |  | [optional] 
**FetchPipe** | [**Link**](Link.md) |  | [optional] 
**FetchExcel** | [**Link**](Link.md) |  | [optional] 
**FetchSqlite** | [**Link**](Link.md) |  | [optional] 
**Histogram** | [**Link**](Link.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string executionId = "example executionId";
Link? progress = new Link();

Link? cancel = new Link();

Link? fetchJson = new Link();

Link? fetchJsonProper = new Link();

Link? fetchXml = new Link();

Link? fetchParquet = new Link();

Link? fetchCsv = new Link();

Link? fetchPipe = new Link();

Link? fetchExcel = new Link();

Link? fetchSqlite = new Link();

Link? histogram = new Link();


BackgroundQueryResponse backgroundQueryResponseInstance = new BackgroundQueryResponse(
    executionId: executionId,
    progress: progress,
    cancel: cancel,
    fetchJson: fetchJson,
    fetchJsonProper: fetchJsonProper,
    fetchXml: fetchXml,
    fetchParquet: fetchParquet,
    fetchCsv: fetchCsv,
    fetchPipe: fetchPipe,
    fetchExcel: fetchExcel,
    fetchSqlite: fetchSqlite,
    histogram: histogram);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
