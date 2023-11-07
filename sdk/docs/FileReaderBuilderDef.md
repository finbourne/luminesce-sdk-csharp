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

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

