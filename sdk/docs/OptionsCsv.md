# Finbourne.Luminesce.Sdk.Model.OptionsCsv
Additional options applicable to the given SourceType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnNames** | **string** | Column Names either overrides the header row or steps in when there is no header row (comma delimited list) | [optional] 
**ColumnNamesWanted** | **string** | Column (by Name) that should be returned (comma delimited list) | [optional] 
**ColumnTypes** | **string** | Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified) | [optional] 
**InferTypeRowCount** | **int** | If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified | [optional] 
**NoHeader** | **bool** | Set this if there is no header row | [optional] 
**Delimiter** | **string** | The delimiter between values (\\t for tab) | [optional] 
**Escape** | **string** | Character used to escape the &#39;Quote&#39; character when within a value | [optional] 
**Quote** | **string** | Character used around any field containing the &#39;delimiter&#39; or a line break. | [optional] 
**ValuesToMakeNull** | **string** | Regex of values to map to &#39;null&#39; in the returned data. | [optional] 
**SkipPreHeader** | **bool** | Number of rows to ignore before the header row | [optional] 
**SkipPostHeader** | **bool** | Number of rows to ignore after the header row | [optional] 
**SkipInvalidRows** | **bool** | Skip invalid data rows (totally invalid ones),   This also allows for potentially wrong data if it can be handled somewhat e.g. embedded quotes misused (and still returns such rows).  In either case a warning will show in the progress feedback. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

