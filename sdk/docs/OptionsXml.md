# Finbourne.Luminesce.Sdk.Model.OptionsXml
Additional options applicable to the given SourceType

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ColumnTypes** | **string** | Column types (comma delimited list of: &#39;{types}&#39;, some columns may be left blank while others are specified) | [optional] 
**InferTypeRowCount** | **int** | If non-zero and &#39;types&#39; is not specified (or not specified for some columns) this will look through N rows to attempt to work out the column types for columns not pre-specified | [optional] 
**ValuesToMakeNull** | **string** | Regex of values to map to &#39;null&#39; in the returned data. | [optional] 
**ColumnNames** | **string** | Column Names either overrides the header row or steps in when there is no header row (comma delimited list) | [optional] 
**NodePath** | **string** | XPath query that selects the nodes to map to rows | [optional] 
**Namespaces** | **string** | Selected prefix(es) and namespace(s):prefix1&#x3D;namespace1-uri1,prefix2&#x3D;namespace2-uri2,...prefixN&#x3D;namespaceN-uriN | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

