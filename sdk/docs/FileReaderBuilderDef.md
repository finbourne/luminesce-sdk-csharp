# Finbourne.Luminesce.Sdk.Model.FileReaderBuilderDef
Information on how to construct a file-read sql query

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoDetect** | **AutoDetectType** |  | [optional] 
**Columns** | [**List&lt;ColumnInfo&gt;**](ColumnInfo.md) | Column information for the results | [optional] 
**Limit** | **int** | What limit be added to the load query?  Less than or equal to zero means none | [optional] 
**Source** | [**Source**](Source.md) |  | [optional] 
**AvailableSources** | [**List&lt;Source&gt;**](Source.md) | The source locations the user has access to.  The provider in essence. | [optional] 
**VariableName** | **string** | The name of the variable for the &#x60;use&#x60; statement | [optional] 
**FilePath** | **string** | The file (or folder) path | [optional] 
**FolderFilter** | **string** | The filter to apply to a folder (all matching files then being read) a RegExp | [optional] 
**ZipFilter** | **string** | The filter to apply to folder structures with zip archives (all matching files then being read) a RegExp | [optional] 
**AddFileName** | **bool** | Should a file name column be added to the output? | [optional] 
**Csv** | [**OptionsCsv**](OptionsCsv.md) |  | [optional] 
**Excel** | [**OptionsExcel**](OptionsExcel.md) |  | [optional] 
**SqLite** | [**OptionsSqLite**](OptionsSqLite.md) |  | [optional] 
**Xml** | [**OptionsXml**](OptionsXml.md) |  | [optional] 
**Parquet** | [**OptionsParquet**](OptionsParquet.md) |  | [optional] 

```csharp
using Finbourne.Luminesce.Sdk.Model;
using System;

List<ColumnInfo> columns = new List<ColumnInfo>();
Source? source = new Source();

List<Source> availableSources = new List<Source>();
string variableName = "example variableName";
string filePath = "example filePath";
string folderFilter = "example folderFilter";
string zipFilter = "example zipFilter";
bool addFileName = //"True";
OptionsCsv? csv = new OptionsCsv();

OptionsExcel? excel = new OptionsExcel();

OptionsSqLite? sqLite = new OptionsSqLite();

OptionsXml? xml = new OptionsXml();

OptionsParquet? parquet = new OptionsParquet();


FileReaderBuilderDef fileReaderBuilderDefInstance = new FileReaderBuilderDef(
    autoDetect: autoDetect,
    columns: columns,
    limit: limit,
    source: source,
    availableSources: availableSources,
    variableName: variableName,
    filePath: filePath,
    folderFilter: folderFilter,
    zipFilter: zipFilter,
    addFileName: addFileName,
    csv: csv,
    excel: excel,
    sqLite: sqLite,
    xml: xml,
    parquet: parquet);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
