# Finbourne.Luminesce.Sdk.Model.BackgroundMultiQueryResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutionId** | **Guid** |  | [optional] [readonly] 
**Progress** | [**Link**](Link.md) |  | [optional] 
**Cancel** | [**Link**](Link.md) |  | [optional] 
**FetchJson** | [**List&lt;Link&gt;**](Link.md) | Json (as a string) data request links for all of the child queries | [optional] [readonly] 
**FetchJsonProper** | [**List&lt;Link&gt;**](Link.md) | Json-proper data request links for all of the child queries | [optional] [readonly] 
**FetchXml** | [**List&lt;Link&gt;**](Link.md) | Xml data request links for all of the child queries | [optional] [readonly] 
**FetchParquet** | [**List&lt;Link&gt;**](Link.md) | Parquet data request links for all of the child queries | [optional] [readonly] 
**FetchCsv** | [**List&lt;Link&gt;**](Link.md) | CSV data request links for all of the child queries | [optional] [readonly] 
**FetchPipe** | [**List&lt;Link&gt;**](Link.md) | Pipe delimited data request links for all of the child queries | [optional] [readonly] 
**FetchExcel** | [**List&lt;Link&gt;**](Link.md) | Excel workbook data request links for all of the child queries | [optional] [readonly] 
**FetchSqlite** | [**List&lt;Link&gt;**](Link.md) | SqLite DB data request links for all of the child queries | [optional] [readonly] 
**Histogram** | [**List&lt;Link&gt;**](Link.md) | Histogram links for all of the child queries | [optional] [readonly] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

Guid executionId = "example executionId";
Link? progress = new Link();

Link? cancel = new Link();

List<Link> fetchJson = new List<Link>();
List<Link> fetchJsonProper = new List<Link>();
List<Link> fetchXml = new List<Link>();
List<Link> fetchParquet = new List<Link>();
List<Link> fetchCsv = new List<Link>();
List<Link> fetchPipe = new List<Link>();
List<Link> fetchExcel = new List<Link>();
List<Link> fetchSqlite = new List<Link>();
List<Link> histogram = new List<Link>();

BackgroundMultiQueryResponse backgroundMultiQueryResponseInstance = new BackgroundMultiQueryResponse(
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
