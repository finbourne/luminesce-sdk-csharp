# Finbourne.Luminesce.Sdk.Model.QueryDesign
Representation of a \"designable Query\" suitable for formatting to SQL or being built from compliant SQL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TableName** | **string** | Name of the table being designed | 
**Alias** | **string** | Alias for the table in the generated SQL, if any | [optional] 
**Fields** | [**List&lt;FieldDesign&gt;**](FieldDesign.md) | Fields to be selected, aggregated over and/or filtered on | 
**OrderBy** | [**List&lt;OrderByTermDesign&gt;**](OrderByTermDesign.md) | Order By clauses to apply | [optional] 
**Limit** | **int?** | Row limit to apply, if any | [optional] 
**Warnings** | **List&lt;string&gt;** | Any warnings to show the user when converting from SQL to this representation | [optional] 
**AvailableFields** | [**List&lt;AvailableField&gt;**](AvailableField.md) | Fields that are known to be available for design when parsing SQL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

