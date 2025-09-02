# Finbourne.Luminesce.Sdk.Model.FileReaderBuilderResponse
Information on how to construct a file-read sql query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | The generated SQL | [optional] 
**Error** | **string** | The error from running generated SQL Query, if any | [optional] 
**Columns** | [**List&lt;ColumnInfo&gt;**](ColumnInfo.md) | Column information for the results | [optional] 
**Data** | **Object** | The resulting data from running the Query | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string query = "example query";
string error = "example error";
List<ColumnInfo> columns = new List<ColumnInfo>();

FileReaderBuilderResponse fileReaderBuilderResponseInstance = new FileReaderBuilderResponse(
    query: query,
    error: error,
    columns: columns,
    data: data);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
