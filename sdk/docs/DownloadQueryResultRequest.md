# Finbourne.Luminesce.Sdk.Model.DownloadQueryResultRequest
How to download the results of a background query: in what format, which of them, and (so far for csv only) formatted as the grid shows them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **ExportType** |  | [optional] 
**SortBy** | **string** | Order the results by these fields. Use the &#x60;-&#x60; sign to denote descending order, e.g. &#x60;-MyFieldName&#x60;.  Numeric indexes may be used also, e.g. &#x60;2,-3&#x60;. Multiple fields can be denoted by a comma e.g. &#x60;-MyFieldName,AnotherFieldName,-AFurtherFieldName&#x60;. Default is null, the sort order specified in the query itself. | [optional] 
**Filter** | **string** | Further limits the fetched results beyond that of the original query. - An ODATA filter per Finbourne.Filtering syntax, e.g. &#x60;SomeField eq &#39;Hello&#39;&#x60; - may be combined with &#x60;sqlFilter&#x60;. | [optional] 
**SqlFilter** | **string** | Further limits the fetched results beyond that of the original query. - Raw SQL for filtering, e.g. &#x60;strftime(&#39;%Y-%m&#39;, SomeDateField) &#x3D; &#39;2026-06&#39;&#x60; - may be combined with &#x60;filter&#x60; while supporting additional syntax that cannot. | [optional] 
**Select** | **string** | Default is null (meaning return all columns in the original query itself). The values are in terms of the result column name from the original data set and are comma delimited, and may aggregate the data, e.g. &#x60;some_field, count(*) as a, max(x) as b&#x60; (where &#x60;groupBy&#x60; would likely be &#x60;1&#x60;). The columns of &#x60;formatting&#x60; are in terms of the columns selected. | [optional] 
**GroupBy** | **string** | Groups by the specified fields: a comma delimited list of 1 based numeric indexes into &#x60;select&#x60;, or repeats of its expressions. Default is null (meaning no grouping will be performed on the selected columns). | [optional] 
**DateTimeFormat** | **string** | Format to apply for DateTime data not otherwise formatted, leaving blank gives the Luminesce Exporter default, currently &#x60;yyyy-MM-dd HH:mm:ss.fff&#x60; | [optional] 
**LoadWaitMilliseconds** | **int** | Optional maximum additional wait period for post execution platform processing. | [optional] 
**Formatting** | [**ExportFormatting**](ExportFormatting.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string sortBy = "example sortBy";
string filter = "example filter";
string sqlFilter = "example sqlFilter";
string select = "example select";
string groupBy = "example groupBy";
string dateTimeFormat = "example dateTimeFormat";
ExportFormatting? formatting = new ExportFormatting();


DownloadQueryResultRequest downloadQueryResultRequestInstance = new DownloadQueryResultRequest(
    format: format,
    sortBy: sortBy,
    filter: filter,
    sqlFilter: sqlFilter,
    select: select,
    groupBy: groupBy,
    dateTimeFormat: dateTimeFormat,
    loadWaitMilliseconds: loadWaitMilliseconds,
    formatting: formatting);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
