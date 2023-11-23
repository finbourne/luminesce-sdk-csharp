# Finbourne.Luminesce.Sdk.Model.ConvertToViewData
Representation of view data where will template the data into a 'create view' sql

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | view query | 
**Name** | **string** | Name of view | 
**Description** | **string** | Description of view | [optional] 
**DocumentationLink** | **string** | Documentation link | [optional] 
**ViewParameters** | [**List&lt;ViewParameter&gt;**](ViewParameter.md) | View parameters | [optional] 
**OtherParameters** | **Dictionary&lt;string, string&gt;** | Other parameters not explicitly handled by the ConvertToView generation.  These will be populated by the \&quot;From SQL\&quot; and should simply be returned by  the web GUI should the user edit / update / regenerate | [optional] 
**StartingVariableName** | **string** | Which variable the this start with, null if not started from a full Create View Sql Statement. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

