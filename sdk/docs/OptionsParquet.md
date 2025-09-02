# Finbourne.Luminesce.Sdk.Model.OptionsParquet
Additional options applicable to the given SourceType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnNamesWanted** | **string** | Column (by Name) that should be returned (comma delimited list) | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string columnNamesWanted = "example columnNamesWanted";

OptionsParquet optionsParquetInstance = new OptionsParquet(
    columnNamesWanted: columnNamesWanted);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
