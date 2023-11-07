# Finbourne.Luminesce.Sdk.Model.FieldDesign
Treatment of a single field within a QueryDesign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Field | 
**Alias** | **string** | Alias if any (if none the Name is used) | [optional] 
**DataType** | **DataType** |  | [optional] 
**ShouldSelect** | **bool** | Should this be selected? False would imply it is only being filtered on.  Ignored when Aggregations are present | [optional] 
**Filters** | [**List&lt;FilterTermDesign&gt;**](FilterTermDesign.md) | Filter clauses to apply to this field (And&#39;ed together) | [optional] 
**Aggregations** | [**List&lt;Aggregation&gt;**](Aggregation.md) | Aggregations to apply (as opposed to simply selecting) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

