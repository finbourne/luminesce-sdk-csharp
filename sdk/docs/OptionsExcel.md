# Finbourne.Luminesce.Sdk.Model.OptionsExcel
Additional options applicable to the given SourceType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnNames** | **string** | Column Names either overrides the header row or steps in when there is no header row (comma delimited list) | [optional] 
**ColumnTypes** | **string** | Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified) | [optional] 
**InferTypeRowCount** | **int** | If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified | [optional] 
**NoHeader** | **bool** | Set this if there is no header row | [optional] 
**Calculate** | **bool** | Whether to attempt a calculation of the imported cell range prior to import | [optional] 
**Password** | **string** | If specified will be used as the password used for password protected workbooks | [optional] 
**Worksheet** | **string** | The worksheet containing the cell range to import (name or index, will default to first) | [optional] 
**RangeOrTable** | **string** | The cell range to import as either a specified range or a table name | [optional] 
**IgnoreInvalidCells** | **bool** | If specified cells which can not be successfully converted to the target type will be ignored | [optional] 
**IgnoreBlankRows** | **bool** | If the entire rows has only blank cells it will be ignored will be ignored | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

string columnNames = "example columnNames";
string columnTypes = "example columnTypes";
bool noHeader = //"True";
bool calculate = //"True";
string password = "example password";
string worksheet = "example worksheet";
string rangeOrTable = "example rangeOrTable";
bool ignoreInvalidCells = //"True";
bool ignoreBlankRows = //"True";

OptionsExcel optionsExcelInstance = new OptionsExcel(
    columnNames: columnNames,
    columnTypes: columnTypes,
    inferTypeRowCount: inferTypeRowCount,
    noHeader: noHeader,
    calculate: calculate,
    password: password,
    worksheet: worksheet,
    rangeOrTable: rangeOrTable,
    ignoreInvalidCells: ignoreInvalidCells,
    ignoreBlankRows: ignoreBlankRows);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
