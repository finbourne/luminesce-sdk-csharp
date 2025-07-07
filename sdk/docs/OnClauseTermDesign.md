# Finbourne.Luminesce.Sdk.Model.OnClauseTermDesign
A single on clause term (a pair of columns to join or a column to filter on)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftTableField** | **string** | Name of field in the left table to join to (complex expressions are not supported at this time) | [optional] 
**RightTableField** | **string** | Name of field in the left table to join to (complex expressions are not supported at this time) | [optional] 
**Operator** | **QueryDesignerBinaryOperator** |  | 
**FilterValue** | **string** | The value to compare against (always as a string, but will be formatted to the correct type) | [optional] 
**FilterValueDataType** | **DataType** |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

