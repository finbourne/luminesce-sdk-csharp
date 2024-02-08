# Finbourne.Luminesce.Sdk.Model.WriterDesign
Representation of a \"designable Query for a writer\" suitable for formatting to SQL or being built from compliant SQL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sql** | **string** | Original SQL that started this off | 
**AvailableToMapFrom** | [**List&lt;ExpressionWithAlias&gt;**](ExpressionWithAlias.md) | The data able to be mapped from as derived from the Sql | [optional] 
**Parameter** | [**AvailableParameter**](AvailableParameter.md) |  | [optional] 
**AvailableParameters** | [**List&lt;AvailableParameter&gt;**](AvailableParameter.md) | All the parameter the user may wish to design | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

