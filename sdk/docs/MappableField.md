# Finbourne.Luminesce.Sdk.Model.MappableField
Information about a field that can be designed on (regardless if it currently is)  Kind of a \"mini-available catalog entry\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the field in need of mapping (The field name from within the Table Parameter itself) | [optional] 
**Type** | **DataType** |  | [optional] 
**Description** | **string** | Description of the field (just for rendering to the user) | [optional] 
**DisplayName** | **string** | Display Name of the field (just for rendering to the user) | [optional] 
**SampleValues** | **string** | Example values for the field (just for rendering to the user) | [optional] 
**AllowedValues** | **string** | Any set of exactly allowed values for the field (perhaps just for rendering to the user, if nothing else) | [optional] 
**MandatoryForActions** | **string** | Which &#x60;Actions&#x60; is this mandatory for? If any (and potentially when), perhaps just for rendering to the user, if nothing else | [optional] 
**Mapping** | [**ExpressionWithAlias**](ExpressionWithAlias.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

